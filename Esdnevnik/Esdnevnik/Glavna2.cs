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
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void oceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocena frm_ocena = new Ocena();
            frm_ocena.Show();
        }
    }
}
