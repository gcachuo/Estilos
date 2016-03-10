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
            if ((new frmAltaClientes().ShowDialog().ToString()) == "Cancel")
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
            var tabla = bd.select("codigoCliente CODIGO, nombreCliente CLIENTE", "Cliente", "where estatusCliente=1");
            dgvClientes.DataSource = tabla;
        }

        private void dgvClientes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dgvClientes_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvClientes_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dialogResult = MessageBox.Show("¿DESEA ELIMINAR ESTE REGISTRO?", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                var codigo = dgvClientes.SelectedRows[0].Cells["CODIGO"].Value.ToString();
                bd.updateSingle("Cliente", "estatusCliente", "0", "codigoCliente = " + codigo);
            }
        }
    }
}