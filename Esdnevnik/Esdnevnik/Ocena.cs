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
    public partial class Ocena : Form
    {
        public Ocena()
        {
            InitializeComponent();
        }
        DataTable dtGrid = new DataTable();
        private void Ocena_Load(object sender, EventArgs e)
        {
            cmb_GodinaPopulate();
            cmb_Predmet.Enabled = false;
            cmb_Odeljenje.Enabled = false;
            cmb_Ucenik.Enabled = false;

            cmb_Ocena.Items.Add(1);
            cmb_Ocena.Items.Add(2);
            cmb_Ocena.Items.Add(3);
            cmb_Ocena.Items.Add(4);
            cmb_Ocena.Items.Add(5);
            //cmb_Ocena.Enabled = false;

        }
        private void cmb_GodinaPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from skolskaGodina", veza);
            DataTable dtGodina = new DataTable();
            adapter.Fill(dtGodina);
            cmb_Godina.DataSource = dtGodina;
            cmb_Godina.ValueMember = "id";
            cmb_Godina.DisplayMember = "naziv";
            cmb_Godina.SelectedValue = 2;
            cmb_GodinaPopulate();
        }

        private void cmb_ProfesorPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("Select distinct osoba.id as id,ime+ '' + prezime as naziv from osoba");
            naredba.Append("join raspodela on osoba.id = nastavnik");
            naredba.Append("where godina = " + cmb_Godina.SelectedValue.ToString());
            textBox2.Text = naredba.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtProfesor = new DataTable();
            adapter.Fill(dtProfesor);
            cmb_Profesor.DataSource = dtProfesor;
            cmb_Profesor.ValueMember = "id";
            cmb_Profesor.DisplayMember = "naziv";
            cmb_Profesor.SelectedIndex = -1;
        }

        private void cmb_Godina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Godina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Godina.IsHandleCreated && cmb_Godina.Focused)
            {
                cmb_ProfesorPopulate();
                cmb_PredmetPopulate();
            }
        }

        private void cmb_Profesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Profesor.IsHandleCreated && cmb_Profesor.Focused)
            {
                cmb_PredmetPopulate();
                cmb_Predmet.Enabled = true;
                cmb_Odeljenje.SelectedValue = -1;
                cmb_Odeljenje.Enabled = false;

                cmb_Ucenik.SelectedValue = -1;
                cmb_Ucenik.Enabled = false;

                cmb_Ocena.SelectedValue = -1;
                cmb_Ocena.Enabled = false;

                Grid_Ocene.DataSource = dtGrid;

            }
        }
        private void cmb_PredmetPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("Select distinct predmet.id as id,naziv as naziv from predmet");
            naredba.Append("join raspodela on predmet.id = predmet");
            naredba.Append("where godina = " + cmb_Godina.SelectedValue.ToString());
            naredba.Append("And profesor = " + cmb_Profesor.SelectedValue.ToString());
            textBox2.Text = naredba.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtPredmet = new DataTable();
            adapter.Fill(dtPredmet);
            cmb_Predmet.DataSource = dtPredmet;
            cmb_Predmet.ValueMember = "id";
            cmb_Predmet.DisplayMember = "naziv";
            cmb_Predmet.SelectedIndex = -1;
        }

        private void cmb_Predmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Odeljenje.IsHandleCreated && cmb_Odeljenje.Focused)
            {
                cmb_PredmetPopulate();
                cmb_Predmet.Enabled = true;
                cmb_Odeljenje.SelectedValue = -1;
                cmb_Odeljenje.Enabled = false;

                cmb_Ucenik.SelectedValue = -1;
                cmb_Ucenik.Enabled = false;

                cmb_Ocena.SelectedValue = -1;
                cmb_Ocena.Enabled = false;

                Grid_Ocene.DataSource = dtGrid;
                cmb_OdeljenjePopulate();
                cmb_Odeljenje.Enabled = true;
                cmb_Odeljenje.SelectedIndex = -1;
            }
        }
        private void cmb_OdeljenjePopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("Select distinct odeljenje.id as id,str(razred) + '-' + index as naziv from odeljenje");
            naredba.Append("join raspodela on odeljenje.id = odeljenje");
            naredba.Append("where godina = " + cmb_Godina.SelectedValue.ToString());
            naredba.Append("And nastavnik = " + cmb_Profesor.SelectedValue.ToString());
            naredba.Append("And predmet = " + cmb_Predmet.SelectedValue.ToString());
            textBox2.Text = naredba.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtOdeljenje = new DataTable();
            adapter.Fill(dtOdeljenje);
            cmb_Odeljenje.DataSource = dtOdeljenje;
            cmb_Odeljenje.ValueMember = "id";
            cmb_Odeljenje.DisplayMember = "naziv";

        }

        private void cmb_Odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmb_Ucenik.IsHandleCreated && cmb_Ucenik.Focused)
            {
                cmb_UcenikPopulate();
                cmb_Ucenik.Enabled = true;
                GridPopulate();
                UcenikOcenaIdSet(0);
                cmb_Ocena.Enabled = true;

            }
        }
        private void cmb_UcenikPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("Select distinct ucenik.id as id,ime + '-' + prezime as naziv from osoba");
            naredba.Append("join upisnica on osoba.id = osoba");


            textBox2.Text = naredba.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtUcenik = new DataTable();
            adapter.Fill(dtUcenik);
            cmb_Ucenik.DataSource = dtUcenik;
            cmb_Ucenik.ValueMember = "id";
            cmb_Ucenik.DisplayMember = "naziv";
        }
        private void GridPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            StringBuilder naredba = new StringBuilder("Select ocene.id as id,ime + ' ' + prezime as naziv,ocena,upisnica.ucenik,datum from osoba");
            naredba.Append("join ocena on osoba.id = ucenik");
            naredba.Append("join raspodela on raspodela = raspodela.id");
            naredba.Append("where raspodela =");
            naredba.Append("select id from raspodela");
            naredba.Append("where godina = " + cmb_Godina.SelectedValue.ToString());
            naredba.Append("And nastavnik = " + cmb_Profesor.SelectedValue.ToString());
            naredba.Append("And predmet = " + cmb_Predmet.SelectedValue.ToString());
            naredba.Append("And odeljenje = " + cmb_Odeljenje.SelectedValue.ToString() + ")");
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);

            adapter.Fill(dtGrid);
            Grid_Ocene.DataSource = dtGrid;
            Grid_Ocene.AllowUserToAddRows = false;
            Grid_Ocene.Columns["ucenik"].Visible = false;
        }

        private void Grid_Ocene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UcenikOcenaIdSet(e.RowIndex);
            }
        }
        private void UcenikOcenaIdSet(int slog)
        {
            cmb_Ucenik.SelectedValue = dtGrid.Rows[slog]["ucenik"];
            cmb_Ocena.SelectedItem = dtGrid.Rows[slog]["ocena"];
            txt_Id.Text = dtGrid.Rows[slog]["id"].ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("SELECT id FROM raspodela");
            naredba.Append(" WHERE godina = " + cmb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik = " + cmb_Profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet = " + cmb_Predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje =" + cmb_Odeljenje.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            int id_raspodele = 0;
            try
            {
                veza.Open();
                id_raspodele = (int)Komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);

            }
            if (id_raspodele > 0)
            {
                naredba = new StringBuilder("INSERT INTO ocena (datum, raspodela, ucenik, ocena) VALUES('");
                DateTime datum = Datum.Value;
                naredba.Append(datum.ToString("yyyy-MM-dd") + "', '");
                naredba.Append(id_raspodele.ToString() + "', '");
                naredba.Append(cmb_Ucenik.SelectedValue.ToString() + "', '");
                naredba.Append(cmb_Ocena.SelectedItem.ToString() + "')");
                Komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
                GridPopulate();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_Id.Text) > 0)
            {
                DateTime datum = Datum.Value;
                StringBuilder naredba = new StringBuilder("UPDATE ocena SET ");
                naredba.Append(" ucenik= '" + cmb_Ucenik.SelectedValue.ToString() + "', ");
                naredba.Append(" ocena = '" + cmb_Ocena.SelectedItem.ToString() + "', ");
                naredba.Append(" datum = '" + datum.ToString("yyyy-MM-dd") + "' ");
                naredba.Append(" WHERE id = " + txt_Id.Text);
                SqlConnection veza = Konekcija.Connect();
                SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
                GridPopulate();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_Id.Text) > 0)
            {
                string naredba = "DELETE FROM ocena WHERE id = " + txt_Id.Text;
                SqlConnection veza = Konekcija.Connect();
                SqlCommand Komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                    GridPopulate();
                    UcenikOcenaIdSet(0);
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }
    }
}
