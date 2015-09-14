using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Software.H6
{
    public partial class VistaCursos : Form
    {
        public bool EstaBuscando { private set; get; }
        public bool EstaEditando { private set; get; }
        // Profesor
        private H4.NegocioProfesores profesorNegocio;
        private Datos.Profesor profesorSeleccion;
        private List<Datos.Profesor> profesorRegistros;
        // Deporte
        private H5.NegocioDeportes deporteNegocio;
        private Datos.Deporte deporteSeleccion;
        private List<Datos.Deporte> deporteRegistros;
        // Curso
        private NegocioCursos cursoNegocio;
        private Datos.Curso cursoSeleccion;
        private List<Datos.Curso> cursoRegistros;

        #region Metodos Generados.

        public VistaCursos()
        {

            InitializeComponent();
            this.cursoNegocio = new NegocioCursos();
            this.profesorNegocio = new H4.NegocioProfesores();
            this.deporteNegocio = new H5.NegocioDeportes();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.LimpiarVista();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!this.EstaEditando)
            {
                this.ModoEdicionOn();
            }
            else
            {
                string titulo = "Actualizacion de cursos";
                try
                {
                    Datos.Curso entidad = this.ArmarEntidad();
                    bool haSidoActualizado = this.cursoNegocio.Actualizar(entidad);
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
            string titulo = "Eliminacion de cursos";
            bool confirmado = this.ConfirmarEliminacion();
            if (!confirmado)
            {
                MostrarError(titulo, "Operacion cancelada.");
            }
            else
            {
                try
                {
                    bool haSidoEliminado = this.cursoNegocio.Eliminar(this.cursoSeleccion);
                    if (haSidoEliminado)
                    {
                        Notificar(titulo, "Curso eliminado");
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
            string titulo = "Registro de curso";
            try
            {
                bool esValido = this.ValidarFormulario();
                if (esValido)
                {
                    Datos.Curso entidad = this.ArmarEntidad();
                    bool seHaRegistrado = this.cursoNegocio.Insertar(entidad);
                    if (seHaRegistrado)
                    {
                        this.LimpiarVista();
                        this.Notificar(titulo, "Curso registrado correctamente.");
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
                this.MostrarError(titulo, exception.Message);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarVista();
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
                    Datos.Curso entidad = this.ArmarEntidad();
                    List<Datos.Curso> resultados = this.cursoNegocio.Buscar(entidad);
                    Console.WriteLine("Resultados encontrados: " + resultados.Count);
                    this.Curso_CargarRegistros(resultados);
                }
                catch (Exception exception)
                {
                    this.MostrarError(titulo, exception.Message);
                }
            }
        }

        private void comboBoxDeporte_Format(object sender, ListControlConvertEventArgs e)
        {
            int codigo = ((Datos.Deporte)e.ListItem).Id;
            string descripcion = ((Datos.Deporte)e.ListItem).Descripcion;
            e.Value = Convert.ToString(codigo) + "-" + descripcion;
        }

        private void comboBoxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxDeporte.SelectedIndex != -1)
            {
                this.deporteSeleccion = this.deporteRegistros[this.comboBoxDeporte.SelectedIndex];
            }
            else
            {
                this.deporteSeleccion = null;
            }
        }

        private void comboBoxProfesor_Format(object sender, ListControlConvertEventArgs e)
        {
            Datos.Profesor item = ((Datos.Profesor)e.ListItem);
            string apellido1 = item.Apellido1;
            string apellido2 = item.Apellido2;
            string nombre = item.Nombres;

            e.Value = apellido1 + " " + apellido2 + " " + nombre;
        }

        private void comboBoxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxProfesor.SelectedIndex != -1)
            {
                this.profesorSeleccion = this.profesorRegistros[this.comboBoxProfesor.SelectedIndex];
            }
            else
            {
                this.profesorSeleccion = null;
            }
        }

        private void dataGridViewRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ModoEdicionOff();
            // Referenciar seleccion.
            int indiceSeleccion = this.dataGridViewRegistros.CurrentRow.Index;
            this.cursoSeleccion = this.cursoRegistros[indiceSeleccion];
            // Cargar datos de la seleccion.
            this.textBoxCodigo.Text = Convert.ToString(this.cursoSeleccion.Id);
            this.textBoxNombre.Text = this.cursoSeleccion.Nombre.Trim();
            this.textBoxObservaciones.Text = this.cursoSeleccion.Observacion;
            this.textBoxDuracion.Text = Convert.ToString(this.cursoSeleccion.Duracion);
            this.dateTimePickerFechaInicio.Value = this.cursoSeleccion.FechaInicio;
            this.dateTimePickerFechaFin.Value = (this.cursoSeleccion.FechaFin == null) ? new DateTime(0) : this.cursoSeleccion.FechaFin.Value;
            this.comboBoxDeporte.SelectedIndex = this.deporteRegistros.FindIndex(a => a.Id == this.cursoSeleccion.Deporte.Id);
            this.comboBoxProfesor.SelectedIndex = this.profesorRegistros.FindIndex(a => a.Id == this.cursoSeleccion.Profesor.Id);
        }

        #endregion

        #region Metodos manuales

        private Datos.Curso ArmarEntidad()
        {
            // Extraer los datos.
            Int32 codigo = (String.IsNullOrEmpty(this.textBoxCodigo.Text)) ? -1 : Convert.ToInt32(this.textBoxCodigo.Text);
            String nombre = (String.IsNullOrEmpty(this.textBoxNombre.Text)) ? null : this.textBoxNombre.Text;
            String observaciones = (String.IsNullOrEmpty(this.textBoxObservaciones.Text)) ? null : this.textBoxObservaciones.Text;
            Int32 duracion = (String.IsNullOrEmpty(this.textBoxDuracion.Text)) ? 0 : Convert.ToInt32(this.textBoxDuracion.Text);
            DateTime fechaInicio = this.dateTimePickerFechaInicio.Value;
            DateTime fechaFin = this.dateTimePickerFechaFin.Value;

            return new Datos.Curso()
            {
                Id = codigo,
                Nombre = nombre,
                Observacion = observaciones,
                Duracion = duracion,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                IdDeporte = this.deporteSeleccion.Id,
                Deporte = this.deporteSeleccion,
                IdProfesor = this.profesorSeleccion.Id,
                Profesor = this.profesorSeleccion
            };
        }

        private void Curso_CargarCodigo()
        {
            string stringCodigo = Convert.ToString(this.cursoNegocio.SiguienteCodigo());
            this.textBoxCodigo.Text = stringCodigo;
        }

        private void Curso_CargarRegistros(List<Datos.Curso> registros)
        {
            this.cursoRegistros = registros;
            this.dataGridViewRegistros.DataSource = this.cursoRegistros;
        }

        private void Deporte_CargarRegistros(List<Datos.Deporte> registros)
        {
            this.deporteRegistros = registros;
            this.comboBoxDeporte.DataSource = this.deporteRegistros;
            this.comboBoxDeporte.SelectedIndex = -1;
        }

        private bool ConfirmarEliminacion()
        {
            String mensaje = "Confirme la eliminacion del curso seleccionado.";
            DialogResult resultado = MessageBox.Show(this, mensaje, "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return resultado == DialogResult.OK;
        }

        private void LimpiarVista()
        {
            // Variables.
            this.cursoRegistros = this.cursoNegocio.ListarTodos();
            this.deporteRegistros = this.deporteNegocio.ListarTodos();
            this.profesorRegistros = this.profesorNegocio.ListarTodos();
            this.cursoSeleccion = null;
            this.deporteSeleccion = null;
            this.profesorSeleccion = null;

            this.EstaBuscando = false;
            this.EstaEditando = false;

            // Componentes.
            this.buttonInsertar.Enabled = true;
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;
            this.buttonActualizar.Text = "Editar";
            this.buttonSeleccionar.Text = "Búsqueda";

            this.textBoxCodigo.Enabled = false;
            this.textBoxNombre.Enabled = true;
            this.textBoxObservaciones.Enabled = true;
            this.textBoxDuracion.Enabled = true;
            this.dateTimePickerFechaInicio.Enabled = true;
            this.dateTimePickerFechaFin.Enabled = true;
            this.comboBoxDeporte.Enabled = true;
            this.comboBoxProfesor.Enabled = true;

            this.textBoxCodigo.Text = null;
            this.textBoxNombre.Text = null;
            this.textBoxObservaciones.Text = null;
            this.textBoxDuracion.Text = null;
            this.dateTimePickerFechaInicio.Value = DateTime.Now;
            this.dateTimePickerFechaFin.Value = DateTime.Now;

            // Operaciones.
            this.Curso_CargarCodigo();
            this.Curso_CargarRegistros(this.cursoRegistros);
            this.Deporte_CargarRegistros(this.deporteRegistros);
            this.Profesor_CargarRegistros(this.profesorRegistros);
        }

        private void ModoBusquedaOn()
        {
            this.EstaBuscando = true;
            this.deporteSeleccion = null;
            this.profesorSeleccion = null;

            this.textBoxCodigo.Text = "-1";
            this.textBoxNombre.Text = null;
            this.textBoxObservaciones.Text = null;
            this.textBoxDuracion.Text = null;
            this.comboBoxDeporte.SelectedIndex = -1;
            this.comboBoxProfesor.SelectedIndex = -1;

            this.textBoxCodigo.Enabled = true;
            this.textBoxNombre.Enabled = true;
            this.textBoxObservaciones.Enabled = true;
            this.textBoxDuracion.Enabled = true;
            this.dateTimePickerFechaInicio.Enabled = false;
            this.dateTimePickerFechaFin.Enabled = false;
            this.comboBoxDeporte.Enabled = true;
            this.comboBoxProfesor.Enabled = true;

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
            this.textBoxCodigo.Enabled = this.EstaEditando;
            this.textBoxNombre.Enabled = this.EstaEditando;
            this.textBoxObservaciones.Enabled = this.EstaEditando;
            this.textBoxDuracion.Enabled = this.EstaEditando;
            this.dateTimePickerFechaInicio.Enabled = this.EstaEditando;
            this.dateTimePickerFechaFin.Enabled = this.EstaEditando;
            this.comboBoxDeporte.Enabled = this.EstaEditando;
            this.comboBoxProfesor.Enabled = this.EstaEditando;

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
            this.textBoxCodigo.Enabled = this.EstaEditando;
            this.textBoxNombre.Enabled = this.EstaEditando;
            this.textBoxObservaciones.Enabled = this.EstaEditando;
            this.textBoxDuracion.Enabled = this.EstaEditando;
            this.dateTimePickerFechaInicio.Enabled = this.EstaEditando;
            this.dateTimePickerFechaFin.Enabled = this.EstaEditando;
            this.comboBoxDeporte.Enabled = this.EstaEditando;
            this.comboBoxProfesor.Enabled = this.EstaEditando;

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

        private void Profesor_CargarRegistros(List<Datos.Profesor> registros)
        {
            this.profesorRegistros = registros;
            this.comboBoxProfesor.DataSource = this.profesorRegistros;
            this.comboBoxProfesor.SelectedIndex = -1;
        }

        private bool ValidarDeporte()
        {
            bool resultadoSalida;

            if (this.comboBoxDeporte.SelectedIndex == -1)
            {
                this.errorDeporte.SetError(this.comboBoxDeporte, "Este campo es obligatorio.");
                resultadoSalida = false;
            }
            else
            {
                this.errorDeporte.SetError(this.comboBoxDeporte, "");
                resultadoSalida = true;
            }
            return resultadoSalida;
        }

        private bool ValidarDuracion()
        {
            bool resultadoSalida;

            if (String.IsNullOrEmpty(this.textBoxDuracion.Text))
            {
                this.errorDuracion.SetError(this.textBoxDuracion, "Este campo es obligatorio.");
                resultadoSalida = false;
            }
            else
            {
                this.errorDuracion.SetError(this.textBoxDuracion, "");
                resultadoSalida = true;
            }
            return resultadoSalida;
        }

        private bool ValidarFormulario()
        {
            bool salida = true;
            if (!this.ValidarDeporte())
            {
                salida = false;
            }
            if (!this.ValidarDuracion())
            {
                salida = false;
            }
            if (!this.ValidarNombre())
            {
                salida = false;
            }
            if (!this.ValidarProfesor())
            {
                salida = false;
            }
            return salida;
        }

        private bool ValidarNombre()
        {
            bool resultadoSalida;

            if (String.IsNullOrEmpty(this.textBoxNombre.Text))
            {
                this.errorNombre.SetError(this.textBoxNombre, "Este campo es obligatorio.");
                resultadoSalida = false;
            }
            else
            {
                this.errorNombre.SetError(this.textBoxNombre, "");
                resultadoSalida = true;
            }
            return resultadoSalida;
        }

        private bool ValidarProfesor()
        {
            bool resultadoSalida;

            if (this.comboBoxProfesor.SelectedIndex == -1)
            {
                this.errorProfesor.SetError(this.comboBoxProfesor, "Este campo es obligatorio.");
                resultadoSalida = false;
            }
            else
            {
                this.errorProfesor.SetError(this.comboBoxProfesor, "");
                resultadoSalida = true;
            }
            return resultadoSalida;
        }

        #endregion




        // Aqui va el nuevo bloque de codigo.

    }
}
