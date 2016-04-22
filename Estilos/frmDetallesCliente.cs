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
    public partial class frmDetallesCliente : Form
    {
        public frmDetallesCliente(string id)
        {
            InitializeComponent();
            var bd = new clsBD();
            var tablaCliente = bd.select("nombreCliente NOMBRE", "Cliente", "codigoCliente=" + id);
            var tablaEstilos = bd.selectEstilos(id);
            var nombre = tablaCliente.Rows[0]["NOMBRE"].ToString();
            dgvEstilos.DataSource = tablaEstilos;
            lblNombre.Text = nombre;
        }
    }
}
