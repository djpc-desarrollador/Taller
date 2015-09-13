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
    }
}
