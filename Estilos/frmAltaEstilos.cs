using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Estilos
{
    public partial class frmAltaEstilos : Form
    {
        clsBD bd = new clsBD();
        globales g = new globales();
        string tabla;
        string campos;
        List<int> indexClientes, indexColor;

        public frmAltaEstilos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblEstatus.Text = "";

            if (cboColor.SelectedIndex != -1 && cboCliente.SelectedIndex != -1 && txtCodigo.Text != "" && txtNombre.Text != "")
            {
                var codigo = txtCodigo.Text;
                var nombre = txtNombre.Text;
                var color = indexColor[cboColor.SelectedIndex].ToString();
                var cliente = indexClientes[cboCliente.SelectedIndex].ToString();

                if(guardarEstilo(new string[] { codigo, nombre, color, cliente }))
                {
                    lblEstatus.Text = "GUARDADO CORRECTAMENTE";
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    cboColor.SelectedIndex = -1;
                    cboCliente.SelectedIndex = -1;
                }
                else
                {
                    lblEstatus.Text = "ERROR AL GUARDAR";
                }
            }
            else
            {
                lblEstatus.Text = "LLENE TODOS LOS CAMPOS";
            }
        }
        bool guardarEstilo(string[] campos)
        {
            tabla = "Estilo";
            if (bd.insert(tabla, "codigoEstilo, nombreEstilo, idColor, idCliente", g.arraytofields(campos)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void frmAltaEstilos_Load(object sender, EventArgs e)
        {
            tabla = "Cliente";
            var campos = "codigoCliente codigo, nombreCliente nombre";
            indexClientes = new List<int>();
            indexColor = new List<int>();

            foreach (DataRow row in bd.select(campos, tabla).Rows)
            {
                cboCliente.Items.Add(row.ItemArray[1]);
                indexClientes.Add(int.Parse(row.ItemArray[0].ToString()));
            }

            tabla = "Color";
            campos = "idColor id, nombreColor nombre";

            foreach (DataRow row in bd.select(campos, tabla).Rows)
            {
                cboColor.Items.Add(row.ItemArray[1]);
                indexColor.Add(int.Parse(row.ItemArray[0].ToString()));
            }
        }
    }
}
