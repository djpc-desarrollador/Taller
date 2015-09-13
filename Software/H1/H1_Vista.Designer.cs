namespace Software.H1
{
    partial class H1_Vista
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.groupBoxRegistros = new System.Windows.Forms.GroupBox();
            this.dataGridViewRegistros = new System.Windows.Forms.DataGridView();
            this.errorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTipoArea.SuspendLayout();
            this.groupBoxOperaciones.SuspendLayout();
            this.groupBoxRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTipoArea
            // 
            this.groupBoxTipoArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTipoArea.Controls.Add(this.labelDescripcion);
            this.groupBoxTipoArea.Controls.Add(this.labelCodigo);
            this.groupBoxTipoArea.Controls.Add(this.textBoxDescripcion);
            this.groupBoxTipoArea.Controls.Add(this.textBoxCodigo);
            this.groupBoxTipoArea.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTipoArea.Name = "groupBoxTipoArea";
            this.groupBoxTipoArea.Size = new System.Drawing.Size(420, 77);
            this.groupBoxTipoArea.TabIndex = 0;
            this.groupBoxTipoArea.TabStop = false;
            this.groupBoxTipoArea.Text = "Datos del TIPO DE AREA";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(6, 50);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 3;
            this.labelDescripcion.Text = "&Descripción:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(6, 23);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "&Código:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(78, 47);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(224, 20);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(55, 20);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(87, 20);
            this.textBoxCodigo.TabIndex = 0;
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
            this.groupBoxOperaciones.Location = new System.Drawing.Point(13, 96);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(420, 56);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(335, 20);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "&Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(253, 20);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 3;
            this.buttonSeleccionar.Text = "Buscar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(171, 20);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
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
            this.groupBoxRegistros.Location = new System.Drawing.Point(13, 159);
            this.groupBoxRegistros.Name = "groupBoxRegistros";
            this.groupBoxRegistros.Size = new System.Drawing.Size(420, 311);
            this.groupBoxRegistros.TabIndex = 2;
            this.groupBoxRegistros.TabStop = false;
            this.groupBoxRegistros.Text = "Tipos de areas registrados";
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
            this.dataGridViewRegistros.Size = new System.Drawing.Size(414, 292);
            this.dataGridViewRegistros.TabIndex = 0;
            this.dataGridViewRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegistros_CellClick);
            // 
            // errorDescripcion
            // 
            this.errorDescripcion.ContainerControl = this;
            // 
            // H1_Vista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(445, 482);
            this.Controls.Add(this.groupBoxRegistros);
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.groupBoxTipoArea);
            this.Name = "H1_Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de area";
            this.Load += new System.EventHandler(this.H1_Vista_Load);
            this.groupBoxTipoArea.ResumeLayout(false);
            this.groupBoxTipoArea.PerformLayout();
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescripcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTipoArea;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.GroupBox groupBoxRegistros;
        private System.Windows.Forms.DataGridView dataGridViewRegistros;
        private System.Windows.Forms.ErrorProvider errorDescripcion;
    }
}