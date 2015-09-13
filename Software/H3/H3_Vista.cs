using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.H3
{
    public partial class H3_Vista : Form
    {
        public bool EstaBuscando { private set; get; }
        public bool EstaEditando { private set; get; }
        private H3_Negocio area_Negocio;
        private H1.H1_Negocio tipoArea_Negocio;
        private Datos.Area area_Seleccion;
        private Datos.TipoArea tipoArea_Seleccion;
        private List<Datos.TipoArea> tipoArea_Registros;
        private List<Datos.Area> area_Registros;

        #region Metodos Generados.

        public H3_Vista()
        {
            InitializeComponent();
            area_Negocio = new H3_Negocio();
            tipoArea_Negocio = new H1.H1_Negocio();
        }

        private void form_Load(object sender, EventArgs e)
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
                string titulo = "Actualizacion de areas";
                try
                {
                    Datos.Area entidad = this.ArmarEntidad();
                    bool haSidoActualizado = this.area_Negocio.Actualizar(entidad);
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
            string titulo = "Eliminacion de areas";
            bool confirmado = this.ConfirmarEliminacion();
            if (!confirmado)
            {
                MostrarError(titulo, "Operacion cancelada.");
            }
            else
            {
                bool haSidoEliminado = this.area_Negocio.Eliminar(this.area_Seleccion);
                if (haSidoEliminado)
                {
                    Notificar(titulo, "Area eliminada");
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
            string titulo = "Registro de areas";
            try
            {
                bool esValido = ValidarFormulario();
                if (esValido)
                {
                    Datos.Area entidad = this.ArmarEntidad();
                    bool seHaRegistrado = this.area_Negocio.Insertar(entidad);
                    if (seHaRegistrado)
                    {
                        LimpiarVista();
                        this.Notificar(titulo, "Area registrada correctamente.");
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
                String titulo = "Busqueda de areas";
                try
                {
                    Datos.Area entidad = ArmarEntidad();
                    List<Datos.Area> resultados = area_Negocio.Buscar(entidad);
                    Console.WriteLine("Resultados encontrados: " + resultados.Count);
                    Area_CargarRegistros(resultados);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(this, exception.Message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ModoEdicionOff();
            // Referenciar seleccion.
            int indiceSeleccion = dataGridViewRegistros.CurrentRow.Index;
            this.area_Seleccion = area_Registros[indiceSeleccion];
            // Cargar datos de la seleccion.
            this.textBoxCodigo.Text = Convert.ToString(this.area_Seleccion.Id);
            this.textBoxDescripcion.Text = this.area_Seleccion.Descripcion.Trim();
            int indiceCombo = tipoArea_Registros.FindIndex(a => a.Codigo == this.area_Seleccion.IdTipoArea);
            this.comboBoxTipoArea.SelectedIndex = indiceCombo;
        }

        #endregion

        #region Metodos manuales

        private void Area_CargarRegistros(List<Datos.Area> registros)
        {
            this.area_Registros = registros;
            this.dataGridViewRegistros.DataSource = registros;
        }

        private Datos.Area ArmarEntidad()
        {
            // Extraer los datos.
            Int32 codigo = (String.IsNullOrEmpty(textBoxCodigo.Text)) ? -1 : Convert.ToInt32(textBoxCodigo.Text);
            String descripcion = (String.IsNullOrEmpty(textBoxDescripcion.Text)) ? null : textBoxDescripcion.Text;
            return new Datos.Area() { Id = codigo, Descripcion = descripcion, IdTipoArea = (this.tipoArea_Seleccion == null) ? -1 : this.tipoArea_Seleccion.Codigo, TipoArea = this.tipoArea_Seleccion };
        }

        private void CargarCodigo()
        {
            string stringCodigo = Convert.ToString(area_Negocio.SiguienteCodigoGenerado());
            this.textBoxCodigo.Text = stringCodigo;
        }

        private bool ConfirmarEliminacion()
        {
            DialogResult resultado = MessageBox.Show(this, "Confirme la eliminacion del area seleccionada.", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return resultado == DialogResult.OK;
        }

        private void LimpiarVista()
        {
            // Variables.
            this.area_Registros = this.area_Negocio.ListarTodos();
            this.tipoArea_Registros = this.tipoArea_Negocio.ListarTodos();
            this.area_Seleccion = null;
            this.tipoArea_Seleccion = null;
            this.EstaBuscando = false;
            this.EstaEditando = false;

            // Componentes.
            this.buttonInsertar.Enabled = true;
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonActualizar.Text = "Editar";
            this.buttonSeleccionar.Text = "Búsqueda";

            this.comboBoxTipoArea.Enabled = true;

            this.textBoxCodigo.Enabled = false;
            this.textBoxDescripcion.Enabled = true;

            this.textBoxCodigo.Text = null;
            this.textBoxDescripcion.Text = null;

            // Operaciones.
            this.CargarCodigo();
            this.TipoArea_CargarRegistros(this.tipoArea_Registros);
            this.Area_CargarRegistros(this.area_Registros);
        }

        private void ModoBusquedaOn()
        {
            this.EstaBuscando = true;
            this.tipoArea_Seleccion = null;

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
            this.comboBoxTipoArea.Enabled = false;
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
            this.comboBoxTipoArea.Enabled = true;

        }

        private void MostrarError(string titulo, string mensaje)
        {
            MessageBox.Show(this, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Notificar(string titulo, string mensaje)
        {
            MessageBox.Show(this, mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TipoArea_CargarRegistros(List<Datos.TipoArea> registros)
        {
            this.comboBoxTipoArea.DataSource = this.tipoArea_Registros;
            this.comboBoxTipoArea.DisplayMember = "Descripcion";
            this.comboBoxTipoArea.SelectedIndex = -1;
        }

        private bool ValidarTipoArea()
        {
            bool resultadoSalida;

            if (this.comboBoxTipoArea.SelectedIndex != -1)
            {
                resultadoSalida = true;
                errorTipoArea.SetError(comboBoxTipoArea, "");
            }
            else
            {
                resultadoSalida = false;
                errorTipoArea.SetError(comboBoxTipoArea, "Seleccione un elemento de la lista.");
            }

            return resultadoSalida;
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
            if (
                !ValidarDescripcion() ||
                !ValidarTipoArea()
            )
            {
                return false;
            }


            return true;
        }

        #endregion

        private void comboBoxTipoArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoArea.SelectedIndex != -1)
            {
                this.tipoArea_Seleccion = tipoArea_Registros[comboBoxTipoArea.SelectedIndex];
            }
        }


    }
}
