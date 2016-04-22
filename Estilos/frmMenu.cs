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

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAltaClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnEstilos_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmClientes().ShowDialog();
        }

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAltaClientes().ShowDialog();
        }

        private void eSTILOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eSTILOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmEstilos().ShowDialog();
        }

        private void aLTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmAltaEstilos().ShowDialog();
        }

        private void aLTADECOLORESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
