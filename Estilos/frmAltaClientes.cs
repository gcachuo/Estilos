using System;
using System.Data;
using System.Windows.Forms;

namespace Estilos
{
    public partial class frmAltaClientes : Form
    {
        clsBD bd = new clsBD();
        globales g = new globales();
        static Cliente cliente = new Cliente();
        string tabla = cliente.tabla;

        public frmAltaClientes()
        {
            InitializeComponent();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblEstatus.Text = "";
            if (txtNombre.Text == "" || txtCodigo.Text == "")
            {
                lblEstatus.Text = "Llene todos los campos";
                return;
            }
            string[] campos = { txtCodigo.Text, txtNombre.Text };
            guardarCliente(campos);
        }
        void guardarCliente(String[] campos)
        {
            if (bd.insert(tabla, "codigoCliente, nombreCliente", g.arraytofields(campos)))
            {
                lblEstatus.Text = "GUARDADO";
                txtCodigo.Text = obtenerUltimoCodigo().ToString();
                txtNombre.Text = "";
            }
            else
                lblEstatus.Text = "ERROR AL GUARDAR";
        }

        void selectClientes()
        {
            var campos = "*";

            foreach (DataRow row in bd.select(campos, tabla).Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    var a = item.ToString();
                }
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaClientes_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = obtenerUltimoCodigo().ToString();
        }
        int obtenerUltimoCodigo()
        {
            int codigo;
            try
            {
                codigo = int.Parse(bd.select(cliente.codigo, cliente.tabla, "", "1 desc").Rows[0]["CODIGO"].ToString()) + 1;
            }
            catch (Exception)
            {
                codigo = 1;
            }
            return codigo;
        }
    }
}
