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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var ventana = new frmClientes().ShowDialog();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAltaClientes_Click(object sender, EventArgs e)
        {
            var ventana = new frmAltaClientes().ShowDialog();
        }
    }
}
