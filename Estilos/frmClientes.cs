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
    public partial class frmClientes : Form
    {
        clsBD bd = new clsBD();
        string tabla = "Cliente";

        public frmClientes()
        {
            InitializeComponent();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                switch (txtCodigo.Text)
                {
                    case "1":
                        txtNombre.Text = "Juan Perez";
                        break;
                    case "2":
                        txtNombre.Text = "Francisco Mendez";
                        break;
                    case "3":
                        txtNombre.Text = "Agustin Melgar";
                        break;
                    default:
                        txtNombre.Text = "";
                        break;
                }



            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblEstatus.Text = "";
            string[] campos = { txtCodigo.Text, txtNombre.Text };
            if (guardarCliente(campos))
            {
                lblEstatus.Text = "Guardado Correcto";
                txtCodigo.Text = "";
                txtNombre.Text = "";
            }
            else
                lblEstatus.Text = "Error al guardar";
        }
        bool guardarCliente(String[] campos)
        {
            var values = arraytofields(campos);
            return (bd.insert(tabla, "codigoCliente, nombreCliente", values));
        }
        string arraytofields(string[] arrayCadena)
        {
            var cadena = "";
            var index = 0;
            foreach (string campo in arrayCadena)
            {
                if (index != 0)
                {
                    cadena += ",";
                }
                cadena += "'" + campo + "'";
                index++;
            }
            return cadena;
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
    }
}
