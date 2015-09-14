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
            H1.H1_Vista vista = new H1.H1_Vista();
            vista.ShowDialog(this);
        }

        private void menuItemH2_Click(object sender, EventArgs e)
        {
            H2.H2_Vista vista = new H2.H2_Vista();
            vista.ShowDialog(this);
        }

        private void menuItemH3_Click(object sender, EventArgs e)
        {
            H3.H3_Vista vista = new H3.H3_Vista();
        }
        private void menuItemH4_Click(object sender, EventArgs e)
        {
            H4.H4_Vista vista = new H4.H4_Vista();
            vista.ShowDialog(this);
        }

        private void menuItemH5_Click(object sender, EventArgs e)
        {
            H5.H5_Vista vista = new H5.H5_Vista();
            vista.ShowDialog(this);
        }
    }
}
