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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTILOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTILOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aLTADECOLORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.eSTILOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem1,
            this.aLTAToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // cLIENTESToolStripMenuItem1
            // 
            this.cLIENTESToolStripMenuItem1.Name = "cLIENTESToolStripMenuItem1";
            this.cLIENTESToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cLIENTESToolStripMenuItem1.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem1.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem1_Click);
            // 
            // aLTAToolStripMenuItem
            // 
            this.aLTAToolStripMenuItem.Name = "aLTAToolStripMenuItem";
            this.aLTAToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aLTAToolStripMenuItem.Text = "ALTA";
            this.aLTAToolStripMenuItem.Click += new System.EventHandler(this.aLTAToolStripMenuItem_Click);
            // 
            // eSTILOSToolStripMenuItem
            // 
            this.eSTILOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTILOSToolStripMenuItem1,
            this.aLTAToolStripMenuItem1,
            this.aLTADECOLORESToolStripMenuItem});
            this.eSTILOSToolStripMenuItem.Name = "eSTILOSToolStripMenuItem";
            this.eSTILOSToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eSTILOSToolStripMenuItem.Text = "ESTILOS";
            this.eSTILOSToolStripMenuItem.Click += new System.EventHandler(this.eSTILOSToolStripMenuItem_Click);
            // 
            // eSTILOSToolStripMenuItem1
            // 
            this.eSTILOSToolStripMenuItem1.Name = "eSTILOSToolStripMenuItem1";
            this.eSTILOSToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.eSTILOSToolStripMenuItem1.Text = "ESTILOS";
            this.eSTILOSToolStripMenuItem1.Click += new System.EventHandler(this.eSTILOSToolStripMenuItem1_Click);
            // 
            // aLTAToolStripMenuItem1
            // 
            this.aLTAToolStripMenuItem1.Name = "aLTAToolStripMenuItem1";
            this.aLTAToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.aLTAToolStripMenuItem1.Text = "ALTA DE ESTILOS";
            this.aLTAToolStripMenuItem1.Click += new System.EventHandler(this.aLTAToolStripMenuItem1_Click);
            // 
            // aLTADECOLORESToolStripMenuItem
            // 
            this.aLTADECOLORESToolStripMenuItem.Name = "aLTADECOLORESToolStripMenuItem";
            this.aLTADECOLORESToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aLTADECOLORESToolStripMenuItem.Text = "ALTA DE COLORES";
            this.aLTADECOLORESToolStripMenuItem.Click += new System.EventHandler(this.aLTADECOLORESToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aLTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTILOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTILOSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aLTAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aLTADECOLORESToolStripMenuItem;
    }
}