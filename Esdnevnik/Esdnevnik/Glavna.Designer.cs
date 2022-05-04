
namespace Esdnevnik
{
    partial class Glavna
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
            this.jedanBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedanSAFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaSaFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIme = new System.Windows.Forms.Label();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskaGodinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedanBezToolStripMenuItem,
            this.jedanSAFKToolStripMenuItem,
            this.tabelaSaFKToolStripMenuItem,
            this.izvestajiToolStripMenuItem,
            this.tabelaBezToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jedanBezToolStripMenuItem
            // 
            this.jedanBezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobeToolStripMenuItem});
            this.jedanBezToolStripMenuItem.Name = "jedanBezToolStripMenuItem";
            this.jedanBezToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.jedanBezToolStripMenuItem.Text = "Jedan Bez";
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.osobeToolStripMenuItem.Text = "Osobe";
            this.osobeToolStripMenuItem.Click += new System.EventHandler(this.osobeToolStripMenuItem_Click);
            // 
            // jedanSAFKToolStripMenuItem
            // 
            this.jedanSAFKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspodelaToolStripMenuItem});
            this.jedanSAFKToolStripMenuItem.Name = "jedanSAFKToolStripMenuItem";
            this.jedanSAFKToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.jedanSAFKToolStripMenuItem.Text = "Jedan SaFK";
            // 
            // tabelaSaFKToolStripMenuItem
            // 
            this.tabelaSaFKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smeroviToolStripMenuItem,
            this.predmetiToolStripMenuItem,
            this.skolskaGodinaToolStripMenuItem});
            this.tabelaSaFKToolStripMenuItem.Name = "tabelaSaFKToolStripMenuItem";
            this.tabelaSaFKToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.tabelaSaFKToolStripMenuItem.Text = "Tabela SaFK";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(499, 37);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(35, 13);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "label1";
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            this.raspodelaToolStripMenuItem.Click += new System.EventHandler(this.raspodelaToolStripMenuItem_Click);
            // 
            // tabelaBezToolStripMenuItem
            // 
            this.tabelaBezToolStripMenuItem.Name = "tabelaBezToolStripMenuItem";
            this.tabelaBezToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.tabelaBezToolStripMenuItem.Text = "Tabela Bez";
            // 
            // smeroviToolStripMenuItem
            // 
            this.smeroviToolStripMenuItem.Name = "smeroviToolStripMenuItem";
            this.smeroviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smeroviToolStripMenuItem.Text = "smerovi";
            this.smeroviToolStripMenuItem.Click += new System.EventHandler(this.smeroviToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.predmetiToolStripMenuItem.Text = "predmeti";
            this.predmetiToolStripMenuItem.Click += new System.EventHandler(this.predmetiToolStripMenuItem_Click);
            // 
            // skolskaGodinaToolStripMenuItem
            // 
            this.skolskaGodinaToolStripMenuItem.Name = "skolskaGodinaToolStripMenuItem";
            this.skolskaGodinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.skolskaGodinaToolStripMenuItem.Text = "skolska godina";
            this.skolskaGodinaToolStripMenuItem.Click += new System.EventHandler(this.skolskaGodinaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna_FormClosed);
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jedanBezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedanSAFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaSaFKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smeroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskaGodinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaBezToolStripMenuItem;
    }
}