
namespace Esdnevnik
{
    partial class Ocena
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
            this.cmb_Godina = new System.Windows.Forms.ComboBox();
            this.cmb_Profesor = new System.Windows.Forms.ComboBox();
            this.cmb_Predmet = new System.Windows.Forms.ComboBox();
            this.cmb_Odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_Ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_Ocena = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Grid_Ocene = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Godina
            // 
            this.cmb_Godina.FormattingEnabled = true;
            this.cmb_Godina.Location = new System.Drawing.Point(12, 42);
            this.cmb_Godina.Name = "cmb_Godina";
            this.cmb_Godina.Size = new System.Drawing.Size(179, 21);
            this.cmb_Godina.TabIndex = 0;
            this.cmb_Godina.SelectedIndexChanged += new System.EventHandler(this.cmb_Godina_SelectedIndexChanged);
            this.cmb_Godina.SelectedValueChanged += new System.EventHandler(this.cmb_Godina_SelectedValueChanged);
            // 
            // cmb_Profesor
            // 
            this.cmb_Profesor.FormattingEnabled = true;
            this.cmb_Profesor.Location = new System.Drawing.Point(218, 42);
            this.cmb_Profesor.Name = "cmb_Profesor";
            this.cmb_Profesor.Size = new System.Drawing.Size(179, 21);
            this.cmb_Profesor.TabIndex = 1;
            this.cmb_Profesor.SelectedValueChanged += new System.EventHandler(this.cmb_Profesor_SelectedValueChanged);
            // 
            // cmb_Predmet
            // 
            this.cmb_Predmet.FormattingEnabled = true;
            this.cmb_Predmet.Location = new System.Drawing.Point(424, 42);
            this.cmb_Predmet.Name = "cmb_Predmet";
            this.cmb_Predmet.Size = new System.Drawing.Size(179, 21);
            this.cmb_Predmet.TabIndex = 2;
            this.cmb_Predmet.SelectedValueChanged += new System.EventHandler(this.cmb_Predmet_SelectedValueChanged);
            // 
            // cmb_Odeljenje
            // 
            this.cmb_Odeljenje.FormattingEnabled = true;
            this.cmb_Odeljenje.Location = new System.Drawing.Point(609, 42);
            this.cmb_Odeljenje.Name = "cmb_Odeljenje";
            this.cmb_Odeljenje.Size = new System.Drawing.Size(179, 21);
            this.cmb_Odeljenje.TabIndex = 3;
            this.cmb_Odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_Odeljenje_SelectedValueChanged);
            // 
            // cmb_Ucenik
            // 
            this.cmb_Ucenik.FormattingEnabled = true;
            this.cmb_Ucenik.Location = new System.Drawing.Point(12, 156);
            this.cmb_Ucenik.Name = "cmb_Ucenik";
            this.cmb_Ucenik.Size = new System.Drawing.Size(179, 21);
            this.cmb_Ucenik.TabIndex = 4;
            // 
            // cmb_Ocena
            // 
            this.cmb_Ocena.FormattingEnabled = true;
            this.cmb_Ocena.Location = new System.Drawing.Point(218, 156);
            this.cmb_Ocena.Name = "cmb_Ocena";
            this.cmb_Ocena.Size = new System.Drawing.Size(179, 21);
            this.cmb_Ocena.TabIndex = 5;
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(571, 157);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(231, 20);
            this.Datum.TabIndex = 6;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(424, 157);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(122, 20);
            this.txt_Id.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(649, 223);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(72, 46);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Upisi";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(649, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 46);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(649, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 46);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Izmeni";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Grid_Ocene
            // 
            this.Grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ocene.Location = new System.Drawing.Point(33, 223);
            this.Grid_Ocene.Name = "Grid_Ocene";
            this.Grid_Ocene.Size = new System.Drawing.Size(538, 215);
            this.Grid_Ocene.TabIndex = 11;
            this.Grid_Ocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Ocene_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Godina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ucenik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ocena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Datum";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(707, 20);
            this.textBox2.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Ocene);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmb_Ocena);
            this.Controls.Add(this.cmb_Ucenik);
            this.Controls.Add(this.cmb_Odeljenje);
            this.Controls.Add(this.cmb_Predmet);
            this.Controls.Add(this.cmb_Profesor);
            this.Controls.Add(this.cmb_Godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Godina;
        private System.Windows.Forms.ComboBox cmb_Profesor;
        private System.Windows.Forms.ComboBox cmb_Predmet;
        private System.Windows.Forms.ComboBox cmb_Odeljenje;
        private System.Windows.Forms.ComboBox cmb_Ucenik;
        private System.Windows.Forms.ComboBox cmb_Ocena;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView Grid_Ocene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
    }
}