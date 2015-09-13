namespace Software.H4
{
    partial class H4_Vista
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
            this.labelApellido1 = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.groupBoxRegistros = new System.Windows.Forms.GroupBox();
            this.dataGridViewRegistros = new System.Windows.Forms.DataGridView();
            this.errorApellido1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.textBoxCi = new System.Windows.Forms.TextBox();
            this.labelCi = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.errorNombres = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTipoArea.SuspendLayout();
            this.groupBoxOperaciones.SuspendLayout();
            this.groupBoxRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTipoArea
            // 
            this.groupBoxTipoArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTipoArea.Controls.Add(this.labelTelefono);
            this.groupBoxTipoArea.Controls.Add(this.textBoxTelefono);
            this.groupBoxTipoArea.Controls.Add(this.labelCi);
            this.groupBoxTipoArea.Controls.Add(this.textBoxCi);
            this.groupBoxTipoArea.Controls.Add(this.labelNombres);
            this.groupBoxTipoArea.Controls.Add(this.textBoxNombres);
            this.groupBoxTipoArea.Controls.Add(this.labelApellido2);
            this.groupBoxTipoArea.Controls.Add(this.textBoxApellido2);
            this.groupBoxTipoArea.Controls.Add(this.labelApellido1);
            this.groupBoxTipoArea.Controls.Add(this.labelCodigo);
            this.groupBoxTipoArea.Controls.Add(this.textBoxApellido1);
            this.groupBoxTipoArea.Controls.Add(this.textBoxCodigo);
            this.groupBoxTipoArea.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTipoArea.Name = "groupBoxTipoArea";
            this.groupBoxTipoArea.Size = new System.Drawing.Size(416, 180);
            this.groupBoxTipoArea.TabIndex = 0;
            this.groupBoxTipoArea.TabStop = false;
            this.groupBoxTipoArea.Text = "1. Datos";
            // 
            // labelApellido1
            // 
            this.labelApellido1.AutoSize = true;
            this.labelApellido1.Location = new System.Drawing.Point(6, 50);
            this.labelApellido1.Name = "labelApellido1";
            this.labelApellido1.Size = new System.Drawing.Size(53, 13);
            this.labelApellido1.TabIndex = 3;
            this.labelApellido1.Text = "Apellido1:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(6, 23);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "Código:";
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApellido1.Location = new System.Drawing.Point(65, 46);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(321, 20);
            this.textBoxApellido1.TabIndex = 1;
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
            this.groupBoxOperaciones.Location = new System.Drawing.Point(10, 198);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(419, 56);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "2. Operaciones";
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
            this.groupBoxRegistros.Location = new System.Drawing.Point(13, 260);
            this.groupBoxRegistros.Name = "groupBoxRegistros";
            this.groupBoxRegistros.Size = new System.Drawing.Size(416, 261);
            this.groupBoxRegistros.TabIndex = 2;
            this.groupBoxRegistros.TabStop = false;
            this.groupBoxRegistros.Text = "3. Registros";
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
            this.dataGridViewRegistros.Size = new System.Drawing.Size(410, 242);
            this.dataGridViewRegistros.TabIndex = 0;
            this.dataGridViewRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegistros_CellClick);
            // 
            // errorApellido1
            // 
            this.errorApellido1.ContainerControl = this;
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApellido2.Location = new System.Drawing.Point(65, 72);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(321, 20);
            this.textBoxApellido2.TabIndex = 4;
            // 
            // labelApellido2
            // 
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Location = new System.Drawing.Point(6, 75);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(53, 13);
            this.labelApellido2.TabIndex = 5;
            this.labelApellido2.Text = "Apellido2:";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombres.Location = new System.Drawing.Point(64, 98);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(322, 20);
            this.textBoxNombres.TabIndex = 6;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(6, 101);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(52, 13);
            this.labelNombres.TabIndex = 7;
            this.labelNombres.Text = "Nombres:";
            // 
            // textBoxCi
            // 
            this.textBoxCi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCi.Location = new System.Drawing.Point(39, 124);
            this.textBoxCi.Name = "textBoxCi";
            this.textBoxCi.Size = new System.Drawing.Size(347, 20);
            this.textBoxCi.TabIndex = 8;
            // 
            // labelCi
            // 
            this.labelCi.AutoSize = true;
            this.labelCi.Location = new System.Drawing.Point(7, 131);
            this.labelCi.Name = "labelCi";
            this.labelCi.Size = new System.Drawing.Size(26, 13);
            this.labelCi.TabIndex = 9;
            this.labelCi.Text = "C.I.:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTelefono.Location = new System.Drawing.Point(65, 150);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(321, 20);
            this.textBoxTelefono.TabIndex = 10;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(7, 153);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 11;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // errorNombres
            // 
            this.errorNombres.ContainerControl = this;
            // 
            // errorCi
            // 
            this.errorCi.ContainerControl = this;
            // 
            // H1_Vista
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(441, 533);
            this.Controls.Add(this.groupBoxRegistros);
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.groupBoxTipoArea);
            this.Name = "H1_Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRAR PROFESOR";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBoxTipoArea.ResumeLayout(false);
            this.groupBoxTipoArea.PerformLayout();
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTipoArea;
        private System.Windows.Forms.Label labelApellido1;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.GroupBox groupBoxRegistros;
        private System.Windows.Forms.DataGridView dataGridViewRegistros;
        private System.Windows.Forms.ErrorProvider errorApellido1;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelCi;
        private System.Windows.Forms.TextBox textBoxCi;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.ErrorProvider errorNombres;
        private System.Windows.Forms.ErrorProvider errorCi;
    }
}