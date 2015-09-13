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

        private H1_Negocio _Negocio;
        private Datos.TipoArea seleccion;

        public H1_Vista()
        {
            InitializeComponent();
            _Negocio = new H1_Negocio();
        }

        private void H1_Vista_Load(object sender, EventArgs e)
        {
            LimpiarVista();
            CargarCodigo();
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
                    bool seHaRegistrado = this._Negocio.Insertar(entidad);
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

        private void textBoxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            ValidarDescripcion();
        }

        /* Metodos manuales */
        
        private Datos.TipoArea ArmarEntidad()
        {
            // Extraer los datos.
            Int32 codigo = Convert.ToInt32(textBoxCodigo.Text);
            String descripcion = textBoxDescripcion.Text;
            return new Datos.TipoArea(codigo, descripcion);
        }

        private void CargarCodigo()
        {
            string stringCodigo = Convert.ToString(_Negocio.SiguienteCodigoGenerado());
            this.textBoxCodigo.Text = stringCodigo;
        }

        private void LimpiarVista()
        {
            this.textBoxCodigo.Text = null;
            this.textBoxDescripcion.Text = null;
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string titulo = "Eliminacion de tipo de area";
            bool confirmado = this.ConfirmarEliminacion();
            if (!confirmado)
            {
                MostrarError(titulo,"Operacion cancelada.");
            }
            else
            {
                this._Negocio.Eliminar(this.seleccion);
            }
        }

        private bool ConfirmarEliminacion()
        {
            DialogResult resultado = MessageBox.Show(this, "Confirme la eliminacion del tipo de area.", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return resultado == DialogResult.OK;
        }
    }
}
