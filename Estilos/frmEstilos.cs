using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estilos
{
    public partial class frmEstilos : Form
    {
        clsBD bd = new clsBD();
        public frmEstilos()
        {
            InitializeComponent();
        }

        private void aLTADEESTILOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAltaEstilos().ShowDialog();
        }

        private void frmEstilos_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        void cargarTabla()
        {
            var tabla = bd.selectEstilos();
            dgvEstilos.DataSource = tabla;
        }
    }
}
