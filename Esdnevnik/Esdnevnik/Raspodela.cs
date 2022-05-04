using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Esdnevnik
{
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int brojSloga = 0;
        public Raspodela()
        {
            InitializeComponent();
        }
        private void Load_data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }
        private void Raspodela_Load(object sender, EventArgs e)
        {
            Load_data();
            ComboFill();
        }
        private void ComboFill()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter;
            DataTable dtgod,dtnastavnik,dtpred,dtodeljenje;
            adapter = new SqlDataAdapter("Select * from SkolskaGodina", veza);
            dtgod = new DataTable();
            adapter.Fill(dtgod);

            adapter = new SqlDataAdapter("Select id, naziv from Predmet", veza);
            dtpred = new DataTable();
            adapter.Fill(dtpred);

            adapter = new SqlDataAdapter("Select id, str(razred)+ '-' + indeks from Odeljenje", veza);
            dtodeljenje = new DataTable();
            adapter.Fill(dtodeljenje);

            adapter = new SqlDataAdapter("Select id,ime+ prezime as naziv  from  Osoba where uloga = 2" , veza);
            dtnastavnik = new DataTable();
            adapter.Fill(dtnastavnik);

            cmbGodina.DataSource = dtgod;
            cmbGodina.ValueMember = "id";
            cmbGodina.DisplayMember = "naziv";
            


            cmbGodina.DataSource = dtpred;
            cmbGodina.ValueMember = "id";
            cmbGodina.DisplayMember = "naziv";
           

            cmbGodina.DataSource = dtnastavnik;
            cmbGodina.ValueMember = "id";
            cmbGodina.DisplayMember = "naziv";
            

            cmbGodina.DataSource = dtodeljenje;
            cmbGodina.ValueMember = "id";
            cmbGodina.DisplayMember = "naziv";


            textBox1.Text = raspodela.Rows[brojSloga]["id"].ToString();


            if (raspodela.Rows.Count == 0)
            {
                cmbGodina.SelectedValue = -1;
                cmbNastavnik.SelectedValue = -1;
                cmbOdeljenje.SelectedValue = -1;
                cmbPredmet.SelectedValue = -1;

            }
            else
            {
                cmbGodina.SelectedValue = raspodela.Rows[brojSloga]["skolskaGodina"];
                cmbNastavnik.SelectedValue = raspodela.Rows[brojSloga]["predmet"];
                cmbPredmet.SelectedValue = raspodela.Rows[brojSloga]["nastavnik"];
                cmbOdeljenje.SelectedValue = raspodela.Rows[brojSloga]["odeljenje"];
            }

            if (brojSloga == 0)
            {
                btnPrvi.Enabled = false;
                btnProsli.Enabled = false;
            }
            else
            {
                btnPrvi.Enabled = true;
                btnProsli.Enabled = true;
            }

            if (brojSloga == raspodela.Rows.Count - 1)
            {
                btnSledeci.Enabled = false;
                btnPoslednji.Enabled = false;
            }
            else
            {
                btnSledeci.Enabled = true;
                btnPoslednji.Enabled = true;
            }
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            brojSloga = 0;
            ComboFill();
        }

        private void btnProsli_Click(object sender, EventArgs e)
        {
            brojSloga--;
            ComboFill();
        }

        private void btnPoslednji_Click(object sender, EventArgs e)
        {
            brojSloga=raspodela.Rows.Count -1;
            ComboFill();
        }

        private void btnSledeci_Click(object sender, EventArgs e)
        {
            brojSloga++;
            ComboFill();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naredba = "insert into raspodela (skolskaGdoina,nastavnik,odeljenje,predmet) values ('" + cmbGodina.SelectedValue + "', '" + cmbNastavnik.SelectedValue + "', '" + cmbOdeljenje.SelectedValue + "', '" +cmbPredmet.SelectedValue +  "')";
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Load_data();
            brojSloga = raspodela.Rows.Count - 1;
            ComboFill();


        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            string naredba = "delete from raspodela where id =" + textBox1.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            string naredba = "update raspodela set skolskaGodina= '" + cmbGodina.SelectedValue + "', nastavnik= '" + cmbNastavnik.SelectedValue + "', predmet = '" + cmbPredmet.SelectedValue + "', odeljenje = '" + cmbOdeljenje.SelectedValue  + "' where id =" + textBox1.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Load_data();

            ComboFill();
        }
    }
}
