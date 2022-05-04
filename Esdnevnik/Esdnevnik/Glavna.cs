using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esdnevnik
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_Osoba = new Osoba();
            frm_Osoba.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            string user = Program.userIme + " " + Program.userPrezime;
            lblIme.Text = user;
            
        }

        private void smerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela frmraspodela = new Raspodela();
            frmraspodela.Show();
        }

        private void tabelaBezToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frmsifarnik = new Sifarnik("smer");
            frmsifarnik.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frmsifarnik = new Sifarnik("Predmet");
            frmsifarnik.Show();
        }

        private void skolskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frmsifarnik = new Sifarnik("SkolskaGodina");
            frmsifarnik.Show();
        }
    }
}
