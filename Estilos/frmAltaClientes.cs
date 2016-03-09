﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estilos
{
    public partial class frmAltaClientes : Form
    {
        clsBD bd = new clsBD();
        string tabla = "Cliente";

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
            if(bd.insert(tabla, "codigoCliente, nombreCliente", arraytofields(campos)))
            {
                lblEstatus.Text = "GUARDADO";
                txtCodigo.Text = "";
                txtNombre.Text = "";
            }
            else
                lblEstatus.Text = "ERROR AL GUARDAR";
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
