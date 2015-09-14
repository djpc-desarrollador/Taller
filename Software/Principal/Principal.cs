using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void menuItemH1_Click(object sender, EventArgs e)
        {
            H1.VistaTipoAreas vista = new H1.VistaTipoAreas();
            vista.ShowDialog(this);
        }

        private void menuItemH2_Click(object sender, EventArgs e)
        {
            H2.VistaTipoAsociados vista = new H2.VistaTipoAsociados();
            vista.ShowDialog(this);
        }

        private void menuItemH3_Click(object sender, EventArgs e)
        {
            H3.VistaAreas vista = new H3.VistaAreas();
        }
        private void menuItemH4_Click(object sender, EventArgs e)
        {
            H4.VistaProfesores vista = new H4.VistaProfesores();
            vista.ShowDialog(this);
        }

        private void menuItemH5_Click(object sender, EventArgs e)
        {
            H5.VistaDeporte vista = new H5.VistaDeporte();
            vista.ShowDialog(this);
        }

        private void menuItemH6_Click(object sender, EventArgs e)
        {
            H6.VistaCursos vista = new H6.VistaCursos();
            vista.ShowDialog(this);
        }
    }
}
