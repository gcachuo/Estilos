using System;
using System.Windows.Forms;

namespace Estilos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new frmClientes().ShowDialog();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAltaClientes_Click(object sender, EventArgs e)
        {
            new frmAltaClientes().ShowDialog();
        }

        private void btnEstilos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
