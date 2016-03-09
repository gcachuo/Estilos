using System;
using System.Windows.Forms;

namespace Estilos
{
    public partial class frmClientes : Form
    {
        clsBD bd = new clsBD();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void aLTADECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((new frmAltaClientes().ShowDialog().ToString()) == "Cancel")
            {
                cargarTabla();
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
        void cargarTabla()
        {
            var tabla = bd.select("codigoCliente CODIGO, nombreCliente CLIENTE", "Cliente");
            dgvClientes.DataSource = tabla;
        }

        private void dgvClientes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void dgvClientes_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            var a = e.Row.Cells;
        }
    }
}
