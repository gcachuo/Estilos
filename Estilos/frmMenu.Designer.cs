namespace Estilos
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAltaClientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEstilos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaClientes
            // 
            this.btnAltaClientes.Location = new System.Drawing.Point(12, 12);
            this.btnAltaClientes.Name = "btnAltaClientes";
            this.btnAltaClientes.Size = new System.Drawing.Size(148, 23);
            this.btnAltaClientes.TabIndex = 0;
            this.btnAltaClientes.Text = "ALTA DE CLIENTES";
            this.btnAltaClientes.UseVisualStyleBackColor = true;
            this.btnAltaClientes.Click += new System.EventHandler(this.btnAltaClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 42);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 23);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEstilos
            // 
            this.btnEstilos.Location = new System.Drawing.Point(13, 72);
            this.btnEstilos.Name = "btnEstilos";
            this.btnEstilos.Size = new System.Drawing.Size(147, 23);
            this.btnEstilos.TabIndex = 2;
            this.btnEstilos.Text = "ESTILOS";
            this.btnEstilos.UseVisualStyleBackColor = true;
            this.btnEstilos.Click += new System.EventHandler(this.btnEstilos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.btnEstilos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnAltaClientes);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEstilos;
    }
}