namespace Software.H6
{
    partial class VistaCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxTipoArea = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.groupBoxRegistros = new System.Windows.Forms.GroupBox();
            this.dataGridViewRegistros = new System.Windows.Forms.DataGridView();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDeporte = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.errorDuracion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDeporte = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProfesor = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTipoArea.SuspendLayout();
            this.groupBoxOperaciones.SuspendLayout();
            this.groupBoxRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTipoArea
            // 
            this.groupBoxTipoArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTipoArea.Controls.Add(this.label4);
            this.groupBoxTipoArea.Controls.Add(this.dateTimePickerFechaFin);
            this.groupBoxTipoArea.Controls.Add(this.label3);
            this.groupBoxTipoArea.Controls.Add(this.dateTimePickerFechaInicio);
            this.groupBoxTipoArea.Controls.Add(this.label2);
            this.groupBoxTipoArea.Controls.Add(this.textBoxDuracion);
            this.groupBoxTipoArea.Controls.Add(this.label1);
            this.groupBoxTipoArea.Controls.Add(this.textBoxObservaciones);
            this.groupBoxTipoArea.Controls.Add(this.labelDescripcion);
            this.groupBoxTipoArea.Controls.Add(this.labelCodigo);
            this.groupBoxTipoArea.Controls.Add(this.textBoxNombre);
            this.groupBoxTipoArea.Controls.Add(this.textBoxCodigo);
            this.groupBoxTipoArea.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTipoArea.Name = "groupBoxTipoArea";
            this.groupBoxTipoArea.Size = new System.Drawing.Size(421, 184);
            this.groupBoxTipoArea.TabIndex = 0;
            this.groupBoxTipoArea.TabStop = false;
            this.groupBoxTipoArea.Text = "1. Datos.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de culminacion:";
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(126, 151);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(268, 20);
            this.dateTimePickerFechaFin.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de inicio:";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(97, 125);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(297, 20);
            this.dateTimePickerFechaInicio.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duración (Días):";
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDuracion.Location = new System.Drawing.Point(97, 99);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(297, 20);
            this.textBoxDuracion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Observaciones:";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxObservaciones.Location = new System.Drawing.Point(93, 73);
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(301, 20);
            this.textBoxObservaciones.TabIndex = 5;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(6, 50);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(47, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Nombre:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(6, 23);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "&Código:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombre.Location = new System.Drawing.Point(59, 47);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(335, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(55, 20);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(87, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOperaciones.Controls.Add(this.buttonLimpiar);
            this.groupBoxOperaciones.Controls.Add(this.buttonSeleccionar);
            this.groupBoxOperaciones.Controls.Add(this.buttonEliminar);
            this.groupBoxOperaciones.Controls.Add(this.buttonActualizar);
            this.groupBoxOperaciones.Controls.Add(this.buttonInsertar);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(13, 325);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(421, 56);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "5. Operaciones.";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(335, 20);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "&Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(253, 20);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 3;
            this.buttonSeleccionar.Text = "Búsqueda";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(171, 20);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(89, 20);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 1;
            this.buttonActualizar.Text = "Editar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(7, 20);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertar.TabIndex = 0;
            this.buttonInsertar.Text = "Registrar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // groupBoxRegistros
            // 
            this.groupBoxRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegistros.Controls.Add(this.dataGridViewRegistros);
            this.groupBoxRegistros.Location = new System.Drawing.Point(13, 387);
            this.groupBoxRegistros.Name = "groupBoxRegistros";
            this.groupBoxRegistros.Size = new System.Drawing.Size(421, 242);
            this.groupBoxRegistros.TabIndex = 2;
            this.groupBoxRegistros.TabStop = false;
            this.groupBoxRegistros.Text = "3. Registros.";
            // 
            // dataGridViewRegistros
            // 
            this.dataGridViewRegistros.AllowUserToAddRows = false;
            this.dataGridViewRegistros.AllowUserToDeleteRows = false;
            this.dataGridViewRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRegistros.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRegistros.MultiSelect = false;
            this.dataGridViewRegistros.Name = "dataGridViewRegistros";
            this.dataGridViewRegistros.ReadOnly = true;
            this.dataGridViewRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegistros.ShowEditingIcon = false;
            this.dataGridViewRegistros.Size = new System.Drawing.Size(415, 223);
            this.dataGridViewRegistros.TabIndex = 0;
            this.dataGridViewRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegistros_CellClick);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxDeporte);
            this.groupBox1.Location = new System.Drawing.Point(13, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Deporte.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Se practicará:";
            // 
            // comboBoxDeporte
            // 
            this.comboBoxDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDeporte.FormattingEnabled = true;
            this.comboBoxDeporte.Location = new System.Drawing.Point(85, 20);
            this.comboBoxDeporte.Name = "comboBoxDeporte";
            this.comboBoxDeporte.Size = new System.Drawing.Size(271, 21);
            this.comboBoxDeporte.TabIndex = 1;
            this.comboBoxDeporte.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeporte_SelectedIndexChanged);
            this.comboBoxDeporte.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxDeporte_Format);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxProfesor);
            this.groupBox2.Location = new System.Drawing.Point(13, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 55);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3. Profesor.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lo dictará el profesor:";
            // 
            // comboBoxProfesor
            // 
            this.comboBoxProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProfesor.FormattingEnabled = true;
            this.comboBoxProfesor.Location = new System.Drawing.Point(121, 20);
            this.comboBoxProfesor.Name = "comboBoxProfesor";
            this.comboBoxProfesor.Size = new System.Drawing.Size(235, 21);
            this.comboBoxProfesor.TabIndex = 1;
            this.comboBoxProfesor.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfesor_SelectedIndexChanged);
            this.comboBoxProfesor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxProfesor_Format);
            // 
            // errorDuracion
            // 
            this.errorDuracion.ContainerControl = this;
            // 
            // errorDeporte
            // 
            this.errorDeporte.ContainerControl = this;
            // 
            // errorProfesor
            // 
            this.errorProfesor.ContainerControl = this;
            // 
            // H6_Vista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(446, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRegistros);
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.groupBoxTipoArea);
            this.Name = "H6_Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRACION DE CURSOS";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBoxTipoArea.ResumeLayout(false);
            this.groupBoxTipoArea.PerformLayout();
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProfesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTipoArea;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.GroupBox groupBoxRegistros;
        private System.Windows.Forms.DataGridView dataGridViewRegistros;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDeporte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProfesor;
        private System.Windows.Forms.ErrorProvider errorDuracion;
        private System.Windows.Forms.ErrorProvider errorDeporte;
        private System.Windows.Forms.ErrorProvider errorProfesor;
    }
}