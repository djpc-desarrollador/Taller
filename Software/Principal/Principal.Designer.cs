namespace Software.Principal
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desarrolloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemH1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemH2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemH3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemH4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemH5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desarrolloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desarrolloToolStripMenuItem
            // 
            this.desarrolloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemH1,
            this.menuItemH2,
            this.menuItemH3,
            this.menuItemH4,
            this.menuItemH5});
            this.desarrolloToolStripMenuItem.Name = "desarrolloToolStripMenuItem";
            this.desarrolloToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.desarrolloToolStripMenuItem.Text = "Desarrollo";
            // 
            // menuItemH1
            // 
            this.menuItemH1.Name = "menuItemH1";
            this.menuItemH1.Size = new System.Drawing.Size(231, 22);
            this.menuItemH1.Text = "Administrar tipo de area";
            this.menuItemH1.Click += new System.EventHandler(this.menuItemH1_Click);
            // 
            // menuItemH2
            // 
            this.menuItemH2.Name = "menuItemH2";
            this.menuItemH2.Size = new System.Drawing.Size(231, 22);
            this.menuItemH2.Text = "Administrar tipo de asociados";
            this.menuItemH2.Click += new System.EventHandler(this.menuItemH2_Click);
            // 
            // menuItemH3
            // 
            this.menuItemH3.Name = "menuItemH3";
            this.menuItemH3.Size = new System.Drawing.Size(231, 22);
            this.menuItemH3.Text = "Administrar areas";
            this.menuItemH3.Click += new System.EventHandler(this.menuItemH3_Click);
            // 
            // menuItemH4
            // 
            this.menuItemH4.Name = "menuItemH4";
            this.menuItemH4.Size = new System.Drawing.Size(231, 22);
            this.menuItemH4.Text = "Administrar profesor";
            this.menuItemH4.Click += new System.EventHandler(this.menuItemH4_Click);
            // 
            // menuItemH5
            // 
            this.menuItemH5.Name = "menuItemH5";
            this.menuItemH5.Size = new System.Drawing.Size(231, 22);
            this.menuItemH5.Text = "Administrar deportes";
            this.menuItemH5.Click += new System.EventHandler(this.menuItemH5_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 386);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desarrolloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemH1;
        private System.Windows.Forms.ToolStripMenuItem menuItemH2;
        private System.Windows.Forms.ToolStripMenuItem menuItemH3;
        private System.Windows.Forms.ToolStripMenuItem menuItemH4;
        private System.Windows.Forms.ToolStripMenuItem menuItemH5;
    }
}