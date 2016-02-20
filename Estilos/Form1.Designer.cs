namespace Estilos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cATALOGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDENESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTILOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem,
            this.cATALOGOSToolStripMenuItem,
            this.oRDENESToolStripMenuItem,
            this.rEPORTESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cATALOGOSToolStripMenuItem
            // 
            this.cATALOGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.eSTILOSToolStripMenuItem,
            this.cOLORESToolStripMenuItem});
            this.cATALOGOSToolStripMenuItem.Name = "cATALOGOSToolStripMenuItem";
            this.cATALOGOSToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.cATALOGOSToolStripMenuItem.Text = "CATALOGOS";
            // 
            // oRDENESToolStripMenuItem
            // 
            this.oRDENESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLTAToolStripMenuItem});
            this.oRDENESToolStripMenuItem.Name = "oRDENESToolStripMenuItem";
            this.oRDENESToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.oRDENESToolStripMenuItem.Text = "ORDENES";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONFIGURACIÓNToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            // 
            // cONFIGURACIÓNToolStripMenuItem
            // 
            this.cONFIGURACIÓNToolStripMenuItem.Name = "cONFIGURACIÓNToolStripMenuItem";
            this.cONFIGURACIÓNToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cONFIGURACIÓNToolStripMenuItem.Text = "CONFIGURACIÓN";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // eSTILOSToolStripMenuItem
            // 
            this.eSTILOSToolStripMenuItem.Name = "eSTILOSToolStripMenuItem";
            this.eSTILOSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eSTILOSToolStripMenuItem.Text = "ESTILOS";
            // 
            // cOLORESToolStripMenuItem
            // 
            this.cOLORESToolStripMenuItem.Name = "cOLORESToolStripMenuItem";
            this.cOLORESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cOLORESToolStripMenuItem.Text = "COLORES";
            // 
            // aLTAToolStripMenuItem
            // 
            this.aLTAToolStripMenuItem.Name = "aLTAToolStripMenuItem";
            this.aLTAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aLTAToolStripMenuItem.Text = "ALTA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 416);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATALOGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDENESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTILOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLTAToolStripMenuItem;
    }
}

