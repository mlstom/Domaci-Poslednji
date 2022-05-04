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
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter adapter;
        string imeTabele;
        public Sifarnik(string tabela)
        {
            imeTabele = tabela;
            InitializeComponent();
        }
        
        private void Sifarnik_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from " + imeTabele, Konekcija.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetDeleteCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.Close();
            }
        }
    }
}
