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
    public partial class Upisnica : Form
    {
        DataTable dtupisnica;
        public Upisnica()
        {
            InitializeComponent();
        }
       
        private void cmb_godina_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolskaGodina", veza);
            DataTable dtgodina = new DataTable();
            adapter.Fill(dtgodina);
            cmbGodina.DataSource = dtgodina;
            cmbGodina.ValueMember = "id";
            cmbGodina.DisplayMember = "naziv";
            cmbGodina.SelectedValue = 2;
        }
        private void cmb_odeljenje_populate()
        {
            string godina = cmbGodina.SelectedValue.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, str(razred)+ '-'+indeks AS naziv FROM odeljenje WHERE godina =" + godina, veza);
            DataTable dtodeljenje = new DataTable();
            adapter.Fill(dtodeljenje);
            cmbOdeljenje.DataSource = dtodeljenje;
            cmbOdeljenje.ValueMember = "id";
            cmbOdeljenje.DisplayMember = "naziv";

        }

        private void cmb_ucenik_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime+ prezime AS naziv FROM osoba WHERE uloga = 1", veza);
            DataTable dtucenik = new DataTable();
            adapter.Fill(dtucenik);
            cmbUcenik.DataSource = dtucenik;
            cmbUcenik.ValueMember = "id";
            cmbUcenik.DisplayMember = "naziv";

        }

        private void Grid_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT upisnica.id AS id, ime + prezime AS naziv, osoba.id AS ucenik FROM upisnica JOIN osoba ON osoba_id = osoba.id WHERE odeljenje_id=  " + cmbOdeljenje.SelectedValue.ToString(), veza);
            dtupisnica = new DataTable();
            adapter.Fill(dtupisnica);
            dataGridView1.DataSource = dtupisnica;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["ucenik"].Visible = false;
        }
        private void Upisnica_Load(object sender, EventArgs e)
        {
            cmb_godina_populate();
            cmb_odeljenje_populate();
            cmbOdeljenje.SelectedIndex = -1;
            cmbUcenik.Enabled = false;
            txtUpisnica.Enabled = false;
        }

        private void dataGridView1_CursorChanged(object sender, EventArgs e)
        {

        }

        int brojSloga = 0;
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int brojSloga = dataGridView1.CurrentRow.Index;
                if (dtupisnica.Rows.Count != 0 && brojSloga >= 0)
                {
                    cmbUcenik.SelectedValue = dataGridView1.Rows[brojSloga].Cells["ucenik"].Value.ToString();
                    txtUpisnica.Text = dataGridView1.Rows[brojSloga].Cells["id"].Value.ToString();
                }
            }
        }

        private void cmbGodina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbGodina.IsHandleCreated && cmbGodina.Focused)
            {
                cmb_odeljenje_populate();
                cmbOdeljenje.SelectedIndex = -1;


                while (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                }
                txtUpisnica.Text = "";
                cmbUcenik.SelectedIndex = -1;
                cmbUcenik.Enabled = false;
            }
        }

        private void cmbOdeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbOdeljenje.IsHandleCreated && cmbOdeljenje.Focused)
            {
                cmb_ucenik_populate();
                cmbUcenik.Enabled = true;
                Grid_populate();
            }
        }

        private void cmbUcenik_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("INSERT INTO upisnica(odeljenje, osoba) VALUES(' "+ cmbOdeljenje.SelectedValue.ToString() + "', '" + cmbUcenik.SelectedValue.ToString() + "')");
           
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                Grid_populate();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE upisnica SET"+ " osoba = '" + cmbUcenik.SelectedValue.ToString() + "' "+ " WHERE id = " + txtUpisnica.Text);
            
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                Grid_populate();
            }
            catch (Exception greska)
            {

                MessageBox.Show(greska.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM upisnica WHERE  id =" + txtUpisnica.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                Grid_populate();
            }
            catch (Exception greska)
            {

                MessageBox.Show(greska.Message);
            }
        }
    }
    }

