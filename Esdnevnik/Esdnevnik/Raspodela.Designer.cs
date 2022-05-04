
namespace Esdnevnik
{
    partial class Raspodela
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
            this.cmbNastavnik = new System.Windows.Forms.ComboBox();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.cmbOdeljenje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrvi = new System.Windows.Forms.Button();
            this.btnProsli = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSledeci = new System.Windows.Forms.Button();
            this.btnPoslednji = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbNastavnik
            // 
            this.cmbNastavnik.FormattingEnabled = true;
            this.cmbNastavnik.Location = new System.Drawing.Point(119, 53);
            this.cmbNastavnik.Name = "cmbNastavnik";
            this.cmbNastavnik.Size = new System.Drawing.Size(271, 21);
            this.cmbNastavnik.TabIndex = 0;
            // 
            // cmbGodina
            // 
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(119, 95);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(271, 21);
            this.cmbGodina.TabIndex = 1;
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(119, 141);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(271, 21);
            this.cmbPredmet.TabIndex = 2;
            // 
            // cmbOdeljenje
            // 
            this.cmbOdeljenje.FormattingEnabled = true;
            this.cmbOdeljenje.Location = new System.Drawing.Point(119, 185);
            this.cmbOdeljenje.Name = "cmbOdeljenje";
            this.cmbOdeljenje.Size = new System.Drawing.Size(271, 21);
            this.cmbOdeljenje.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nastavnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id";
            // 
            // btnPrvi
            // 
            this.btnPrvi.Location = new System.Drawing.Point(105, 346);
            this.btnPrvi.Name = "btnPrvi";
            this.btnPrvi.Size = new System.Drawing.Size(75, 23);
            this.btnPrvi.TabIndex = 11;
            this.btnPrvi.Text = "<<";
            this.btnPrvi.UseVisualStyleBackColor = true;
            this.btnPrvi.Click += new System.EventHandler(this.btnPrvi_Click);
            // 
            // btnProsli
            // 
            this.btnProsli.Location = new System.Drawing.Point(186, 346);
            this.btnProsli.Name = "btnProsli";
            this.btnProsli.Size = new System.Drawing.Size(75, 23);
            this.btnProsli.TabIndex = 12;
            this.btnProsli.Text = "<";
            this.btnProsli.UseVisualStyleBackColor = true;
            this.btnProsli.Click += new System.EventHandler(this.btnProsli_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(267, 346);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(348, 346);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 14;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(429, 346);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 15;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSledeci
            // 
            this.btnSledeci.Location = new System.Drawing.Point(515, 346);
            this.btnSledeci.Name = "btnSledeci";
            this.btnSledeci.Size = new System.Drawing.Size(75, 23);
            this.btnSledeci.TabIndex = 16;
            this.btnSledeci.Text = ">";
            this.btnSledeci.UseVisualStyleBackColor = true;
            this.btnSledeci.Click += new System.EventHandler(this.btnSledeci_Click);
            // 
            // btnPoslednji
            // 
            this.btnPoslednji.Location = new System.Drawing.Point(596, 346);
            this.btnPoslednji.Name = "btnPoslednji";
            this.btnPoslednji.Size = new System.Drawing.Size(75, 23);
            this.btnPoslednji.TabIndex = 17;
            this.btnPoslednji.Text = ">>";
            this.btnPoslednji.UseVisualStyleBackColor = true;
            this.btnPoslednji.Click += new System.EventHandler(this.btnPoslednji_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 18;
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPoslednji);
            this.Controls.Add(this.btnSledeci);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnProsli);
            this.Controls.Add(this.btnPrvi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOdeljenje);
            this.Controls.Add(this.cmbPredmet);
            this.Controls.Add(this.cmbGodina);
            this.Controls.Add(this.cmbNastavnik);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNastavnik;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.ComboBox cmbOdeljenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrvi;
        private System.Windows.Forms.Button btnProsli;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSledeci;
        private System.Windows.Forms.Button btnPoslednji;
        private System.Windows.Forms.TextBox textBox1;
    }
}