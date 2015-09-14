using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.H4
{
    public partial class VistaProfesores : Form
    {
        public bool EstaBuscando { private set; get; }
        public bool EstaEditando { private set; get; }
        private NegocioProfesores negocio;
        private Datos.Profesor seleccion;
        private List<Datos.Profesor> registros;

        #region Metodos Generados.

        public VistaProfesores()
        {
            InitializeComponent();
            negocio = new NegocioProfesores();
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
                string titulo = "Actualizacion de profesores";
                try
                {
                    Datos.Profesor entidad = this.ArmarEntidad();
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
            string titulo = "Eliminacion de profesor";
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
                        Notificar(titulo, "Profesor eliminado");
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
            string titulo = "Registro de profesores";
            try
            {
                bool esValido = ValidarFormulario();
                if (esValido)
                {
                    Datos.Profesor entidad = this.ArmarEntidad();
                    bool seHaRegistrado = this.negocio.Insertar(entidad);
                    if (seHaRegistrado)
                    {
                        LimpiarVista();
                        this.Notificar(titulo, "Profesor registrado correctamente.");
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
                String titulo = "Busqueda de profesores.";
                try
                {
                    Datos.Profesor entidad = ArmarEntidad();
                    List<Datos.Profesor> resultados = negocio.Buscar(entidad);
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
            textBoxApellido1.Text = seleccion.Apellido1;
            textBoxApellido2.Text = seleccion.Apellido2;
            textBoxNombres.Text = seleccion.Nombres;
            textBoxCi.Text = seleccion.Ci;
            textBoxTelefono.Text = seleccion.Telefono;
        }

        #endregion

        #region Metodos manuales

        private Datos.Profesor ArmarEntidad()
        {
            // Extraer los datos.
            Int32 codigo = (String.IsNullOrEmpty(textBoxCodigo.Text)) ? -1 : Convert.ToInt32(textBoxCodigo.Text);
            String apellido1 = (String.IsNullOrEmpty(textBoxApellido1.Text)) ? null : textBoxApellido1.Text;
            String apellido2 = (String.IsNullOrEmpty(textBoxApellido2.Text)) ? null : textBoxApellido2.Text;
            String nombres = (String.IsNullOrEmpty(textBoxNombres.Text)) ? null : textBoxNombres.Text;
            String ci = (String.IsNullOrEmpty(textBoxCi.Text)) ? null : textBoxCi.Text;
            String telefono = (String.IsNullOrEmpty(textBoxTelefono.Text)) ? null : textBoxTelefono.Text;

            return new Datos.Profesor()
            {
                Id = codigo,
                Apellido1 = apellido1,
                Apellido2 = apellido2,
                Nombres = nombres,
                Ci = ci,
                Telefono = telefono
            };
        }

        private void CargarCodigo()
        {
            string stringCodigo = Convert.ToString(negocio.SiguienteCodigo());
            this.textBoxCodigo.Text = stringCodigo;
        }

        private void CargarRegistros(List<Datos.Profesor> registros)
        {
            this.registros = registros;
            this.dataGridViewRegistros.DataSource = registros;
        }

        private bool ConfirmarEliminacion()
        {
            DialogResult resultado = MessageBox.Show(
                this,
                "Confirme la eliminacion del profesor seleccionado.",
                "Confirmacion",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );
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

            textBoxCodigo.Enabled = false;
            textBoxApellido1.Enabled = true;
            textBoxApellido2.Enabled = true;
            textBoxNombres.Enabled = true;
            textBoxCi.Enabled = true;
            textBoxTelefono.Enabled = true;

            textBoxCodigo.Text = null;
            textBoxApellido1.Text = null;
            textBoxApellido2.Text = null;
            textBoxNombres.Text = null;
            textBoxCi.Text = null;
            textBoxTelefono.Text = null;

            // Operaciones.
            this.CargarCodigo();
            this.CargarRegistros(this.registros);
        }

        private void ModoBusquedaOn()
        {
            this.EstaBuscando = true;

            textBoxCodigo.Enabled = true;
            textBoxApellido1.Enabled = true;
            textBoxApellido2.Enabled = true;
            textBoxNombres.Enabled = true;
            textBoxCi.Enabled = true;
            textBoxTelefono.Enabled = true;

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
            textBoxCodigo.Enabled = false;
            textBoxApellido1.Enabled = false;
            textBoxApellido2.Enabled = false;
            textBoxNombres.Enabled = false;
            textBoxCi.Enabled = false;
            textBoxTelefono.Enabled = false;

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
            textBoxCodigo.Enabled = false;
            textBoxApellido1.Enabled = true;
            textBoxApellido2.Enabled = true;
            textBoxNombres.Enabled = true;
            textBoxCi.Enabled = true;
            textBoxTelefono.Enabled = true;

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

        private bool ValidarApellido1()
        {
            bool resultadoSalida;

            if (String.IsNullOrEmpty(textBoxApellido1.Text))
            {
                errorApellido1.SetError(textBoxApellido1, "Este campo es obligatorio.");
                resultadoSalida = false;
            }
            else
            {
                errorApellido1.SetError(textBoxApellido1, "");
                resultadoSalida = true;
            }
            return resultadoSalida;
        }

        private bool ValidarNombres()
        {
            bool resultadoSalida;

            if (String.IsNullOrEmpty(textBoxNombres.Text))
            {
                errorNombres.SetError(textBoxNombres, "Este campo es obligatorio.");
                resultadoSalida = false;
            }
            else
            {
                errorNombres.SetError(textBoxNombres, "");
                resultadoSalida = true;
            }
            return resultadoSalida;
        }

        private bool ValidarCi()
        {
            bool resultadoSalida;

            if (String.IsNullOrEmpty(textBoxCi.Text))
            {
                errorCi.SetError(textBoxCi, "Este campo es obligatorio.");
                resultadoSalida = false;
            }
            else
            {
                errorCi.SetError(textBoxCi, "");
                resultadoSalida = true;
            }
            return resultadoSalida;
        }

        private bool ValidarFormulario()
        {
            if (
                !ValidarApellido1() ||
                !ValidarNombres() ||
                !ValidarCi()
            )
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
