using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.H1
{
    public partial class H1_Vista : Form
    {
        public bool EstaBuscando { private set; get; }
        public bool EstaEditando { private set; get; }
        private H1_Negocio negocio;
        private Datos.TipoArea seleccion;
        private List<Datos.TipoArea> registros;

        #region Metodos Generados.

        public H1_Vista()
        {
            InitializeComponent();
            negocio = new H1_Negocio();
        }

        private void H1_Vista_Load(object sender, EventArgs e)
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
                string titulo = "Actualizacion de tipos de areas";
                try
                {
                    Datos.TipoArea entidad = this.ArmarEntidad();
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
            string titulo = "Eliminacion de tipo de area";
            bool confirmado = this.ConfirmarEliminacion();
            if (!confirmado)
            {
                MostrarError(titulo, "Operacion cancelada.");
            }
            else
            {
                bool haSidoEliminado = this.negocio.Eliminar(this.seleccion);
                if (haSidoEliminado)
                {
                    Notificar(titulo, "Tipo de area eliminada");
                    LimpiarVista();
                }
                else
                {
                    MostrarError(titulo, "Error desconocido.");
                }
            }
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            string titulo = "Registro de tipo de areas";
            try
            {
                bool esValido = ValidarFormulario();
                if (esValido)
                {
                    Datos.TipoArea entidad = this.ArmarEntidad();
                    bool seHaRegistrado = this.negocio.Insertar(entidad);
                    if (seHaRegistrado)
                    {
                        LimpiarVista();
                        this.Notificar(titulo, "Tipo de area registrado correctamente.");
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
                MessageBox.Show(this, exception.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ModoEdicionOff();
            // Referenciar seleccion.
            int indiceSeleccion = dataGridViewRegistros.CurrentRow.Index;
            this.seleccion = registros[indiceSeleccion];
            // Cargar datos de la seleccion.
            this.textBoxCodigo.Text = Convert.ToString(this.seleccion.Codigo);
            this.textBoxDescripcion.Text = this.seleccion.Descripcion.Trim();
        }

        #endregion

        #region Metodos manuales

        private Datos.TipoArea ArmarEntidad()
        {
            // Extraer los datos.
            Int32 codigo = (String.IsNullOrEmpty(textBoxCodigo.Text)) ? -1 : Convert.ToInt32(textBoxCodigo.Text);
            String descripcion = (String.IsNullOrEmpty(textBoxDescripcion.Text)) ? null : textBoxDescripcion.Text;
            return new Datos.TipoArea(codigo, descripcion);
        }

        private void CargarCodigo()
        {
            string stringCodigo = Convert.ToString(negocio.SiguienteCodigoGenerado());
            this.textBoxCodigo.Text = stringCodigo;
        }

        private bool ConfirmarEliminacion()
        {
            DialogResult resultado = MessageBox.Show(this, "Confirme la eliminacion del tipo de area.", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (!this.EstaBuscando)
            {
                this.ModoBusquedaOn();
            }
            else
            {
                Datos.TipoArea entidad = ArmarEntidad();
                List<Datos.TipoArea> resultados = negocio.Buscar(entidad);
                Console.WriteLine("Resultados encontrados: " + resultados.Count);
                CargarRegistros(resultados);
            }
        }

        private void CargarRegistros(List<Datos.TipoArea> registros)
        {
            this.registros = registros;
            this.dataGridViewRegistros.DataSource = registros;
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVista();
        }
    }
}
