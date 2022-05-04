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
    public partial class Osoba : Form
    {
        int trenutni = 0;
        DataTable tabela;
        public Osoba()
        {
            InitializeComponent();
        }
        private void Ucitaj()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void TxtPromena()
        {
            if (trenutni == -1)
            {
                txtId.Text = "";
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtAdresa.Text = "";
                txtJmbg.Text = "";
                txtEmail.Text = "";
                txtPass.Text = "";
                txtUloga.Text = "";
            }
            else
            {
                txtId.Text = tabela.Rows[trenutni]["id"].ToString();
                txtIme.Text = tabela.Rows[trenutni]["ime"].ToString();
                txtPrezime.Text = tabela.Rows[trenutni]["prezime"].ToString();
                txtAdresa.Text = tabela.Rows[trenutni]["adresa"].ToString();
                txtJmbg.Text = tabela.Rows[trenutni]["jmbg"].ToString();
                txtEmail.Text = tabela.Rows[trenutni]["email"].ToString();
                txtPass.Text = tabela.Rows[trenutni]["pass"].ToString();
                txtUloga.Text = tabela.Rows[trenutni]["uloga"].ToString();


            }
            if (trenutni == -1)
            {
                btnPrvi.Enabled = false;
                btnProsli.Enabled = false;
                btnPromeni.Enabled = false;
                btnObrisi.Enabled = false;
            }
            else
            {
                btnPrvi.Enabled = true;
                btnProsli.Enabled = true;
                btnPromeni.Enabled = true;
                btnObrisi.Enabled = true;
            }
            if(trenutni == tabela.Rows.Count - 1)
            {
                btnSledeci.Enabled = false;
                btnZadnji.Enabled = false;
            }
            else
            {
                btnSledeci.Enabled = true;
                btnZadnji.Enabled = true;
            }

           
        }
        private void Osoba_Load(object sender, EventArgs e)
        {
            Ucitaj();
            TxtPromena();
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            trenutni = 0;
            TxtPromena();
        }

        private void btnProsli_Click(object sender, EventArgs e)
        {
            if(trenutni != -1)
            {
                trenutni--;
                TxtPromena();
            }
        }

        private void btnSledeci_Click(object sender, EventArgs e)
        {
            if (trenutni != tabela.Rows.Count-1)
            {
                trenutni++;
                TxtPromena();
            }
        }

        private void btnZadnji_Click(object sender, EventArgs e)
        {
            trenutni = tabela.Rows.Count - 1;
            TxtPromena();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {


            string naredba = "insert into osoba (ime,prezime,adresa,jmbg,email,pass,uloga) values ('" + txtIme.Text + "', '" + txtPrezime.Text + "', '" + txtAdresa.Text + "', '" + txtJmbg.Text + "', '" + txtEmail.Text + "', '" + txtPass.Text + "', '" + txtUloga.Text + "')";
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            Ucitaj();
            trenutni = tabela.Rows.Count - 1;
            TxtPromena();

        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {

            string naredba = "update osoba set ime= '" + txtIme.Text+"', prezime= '"+ txtPrezime.Text+"', adresa = '" + txtAdresa.Text +"', jmbg = '"+txtJmbg.Text+"', email = '" +txtEmail.Text+"', pass = '"+txtPass.Text+"', uloga = '"+txtUloga.Text+"' where id =" + txtId.Text;
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
            Ucitaj();
            TxtPromena();

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            string naredba = "delete from osoba where id =" + txtId.Text;
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
    }
}
