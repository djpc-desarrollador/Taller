using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.H5
{
    public partial class VistaDeporte : Form
    {
        public bool EstaBuscando { private set; get; }
        public bool EstaEditando { private set; get; }
        private NegocioDeportes negocio;
        private Datos.Deporte seleccion;
        private List<Datos.Deporte> registros;

        #region Metodos Generados.

        public VistaDeporte()
        {
            InitializeComponent();
            negocio = new NegocioDeportes();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LimpiarVista();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!this.EstaEditando)
            {
                this.ModoEdicionOn();
            }
            else
            {
                string titulo = "Actualizacion de deportes";
                try
                {
                    Datos.Deporte entidad = this.ArmarEntidad();
                    bool haSidoActualizado = this.negocio.Actualizar(entidad);
                    if (haSidoActualizado)
                    {
                        Notificar(titulo, "Datos actualizados.");
                        LimpiarVista();
                    }
                    else
                    {
                        MostrarError(titulo, "Error desconocido.");
                    }
                }
                catch (Exception exception)
                {
                    MostrarError(titulo, exception.Message);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string titulo = "Eliminacion de deportes";
            bool confirmado = this.ConfirmarEliminacion();
            if (!confirmado)
            {
                MostrarError(titulo, "Operacion cancelada.");
            }
            else
            {
                try
                {
                    bool haSidoEliminado = this.negocio.Eliminar(this.seleccion);
                    if (haSidoEliminado)
                    {
                        Notificar(titulo, "Deporte eliminado");
                        LimpiarVista();
                    }
                    else
                    {
                        MostrarError(titulo, "Error desconocido.");
                    }
                }
                catch (Exception exception)
                {
                    MostrarError(titulo, exception.Message);
                }
            }
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            string titulo = "Registro de deporte";
            try
            {
                bool esValido = ValidarFormulario();
                if (esValido)
                {
                    Datos.Deporte entidad = this.ArmarEntidad();
                    bool seHaRegistrado = this.negocio.Insertar(entidad);
                    if (seHaRegistrado)
                    {
                        LimpiarVista();
                        this.Notificar(titulo, "Deporte registrado correctamente.");
                    }
                    else
                    {
                        string mensaje = "Error desconocido";
                        this.MostrarError(titulo, mensaje);
                    }
                }
            }
            catch (Exception exception)
            {
                MostrarError(titulo, exception.Message);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVista();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (!this.EstaBuscando)
            {
                this.ModoBusquedaOn();
            }
            else
            {
                String titulo = "Busqueda de deportes";
                try
                {
                    Datos.Deporte entidad = ArmarEntidad();
                    List<Datos.Deporte> resultados = negocio.Buscar(entidad);
                    Console.WriteLine("Resultados encontrados: " + resultados.Count);
                    CargarRegistros(resultados);
                }
                catch (Exception exception)
                {
                    MostrarError(titulo, exception.Message);
                }
            }
        }

        private void dataGridViewRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ModoEdicionOff();
            // Referenciar seleccion.
            int indiceSeleccion = dataGridViewRegistros.CurrentRow.Index;
            this.seleccion = registros[indiceSeleccion];
            // Cargar datos de la seleccion.
            this.textBoxCodigo.Text = Convert.ToString(this.seleccion.Id);
            this.textBoxDescripcion.Text = this.seleccion.Descripcion.Trim();
        }

        #endregion

        #region Metodos manuales

        private Datos.Deporte ArmarEntidad()
        {
            // Extraer los datos.
            Int32 codigo = (String.IsNullOrEmpty(textBoxCodigo.Text)) ? -1 : Convert.ToInt32(textBoxCodigo.Text);
            String descripcion = (String.IsNullOrEmpty(textBoxDescripcion.Text)) ? null : textBoxDescripcion.Text;
            return new Datos.Deporte() { Id = codigo, Descripcion = descripcion };
        }

        private void CargarCodigo()
        {
            string stringCodigo = Convert.ToString(negocio.SiguienteCodigo());
            this.textBoxCodigo.Text = stringCodigo;
        }

        private void CargarRegistros(List<Datos.Deporte> registros)
        {
            this.registros = registros;
            this.dataGridViewRegistros.DataSource = registros;
        }

        private bool ConfirmarEliminacion()
        {
            String mensaje = "Confirme la eliminacion del deporte seleccionado.";
            DialogResult resultado = MessageBox.Show(this, mensaje, "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return resultado == DialogResult.OK;
        }

        private void LimpiarVista()
        {
            // Variables.
            this.registros = negocio.ListarTodos();
            this.seleccion = null;
            this.EstaBuscando = false;
            this.EstaEditando = false;

            // Componentes.
            this.buttonInsertar.Enabled = true;
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;
            this.buttonActualizar.Text = "Editar";
            this.buttonSeleccionar.Text = "Búsqueda";

            this.textBoxCodigo.Enabled = false;
            this.textBoxDescripcion.Enabled = true;

            this.textBoxCodigo.Text = null;
            this.textBoxDescripcion.Text = null;

            // Operaciones.
            this.CargarCodigo();
            this.CargarRegistros(this.registros);
        }

        private void ModoBusquedaOn()
        {
            this.EstaBuscando = true;

            this.textBoxCodigo.Enabled = true;
            this.textBoxDescripcion.Enabled = true;
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;
            this.buttonInsertar.Enabled = false;
            this.buttonSeleccionar.Text = "Buscar";
        }

        private void ModoEdicionOff()
        {
            // Variables.
            this.EstaEditando = false;
            // Componentes.
            this.textBoxCodigo.Enabled = false;
            this.textBoxDescripcion.Enabled = false;
            this.buttonActualizar.Text = "Editar";
            this.buttonActualizar.Enabled = true;
            this.buttonEliminar.Enabled = true;
            this.buttonInsertar.Enabled = false;
        }

        private void ModoEdicionOn()
        {
            // Variables.
            this.EstaEditando = true;
            // Componentes.
            this.textBoxCodigo.Enabled = false;
            this.textBoxDescripcion.Enabled = true;
            this.buttonActualizar.Text = "Guardar";
            this.buttonActualizar.Enabled = true;
            this.buttonEliminar.Enabled = true;
            this.buttonInsertar.Enabled = false;
        }

        private void MostrarError(string titulo, string mensaje)
        {
            MessageBox.Show(this, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Notificar(string titulo, string mensaje)
        {
            MessageBox.Show(this, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarDescripcion()
        {
            bool resultadoSalida;

            if (String.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                errorDescripcion.SetError(textBoxDescripcion, "Este campo es obligatorio.");
                resultadoSalida = false;
            }
            else
            {
                errorDescripcion.SetError(textBoxDescripcion, "");
                resultadoSalida = true;
            }
            return resultadoSalida;
        }

        private bool ValidarFormulario()
        {
            if (!ValidarDescripcion())
            {
                return false;
            }
            return true;
        }

        #endregion

        // Dejar siempre esta linea.

    }
}
