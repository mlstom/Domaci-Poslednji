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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == ""  )
            {
                MessageBox.Show("Morate uneti sve podatke!!!");
                return;

            }
            else
            {
                if (txtPass.Text == "")
                {
                    MessageBox.Show("Morate uneti sve podatke!!!");
                    return;
                }
                else
                {
                    try
                    {
                        SqlConnection veza = Konekcija.Connect();
                        SqlCommand Komanda = new SqlCommand("Select * from osoba where email=@username",veza);
                        Komanda.Parameters.AddWithValue("@username", txtEmail.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(Komanda);
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);
                        int brojac = tabela.Rows.Count;
                        if (brojac == 1)
                        {
                            if (String.Compare(tabela.Rows[0]["pass"].ToString(),txtPass.Text ) == 0)
                            {
                                MessageBox.Show("Login Succesful");
                                Program.userIme = tabela.Rows[0]["ime"].ToString();
                                Program.userPrezime = tabela.Rows[0]["prezime"].ToString();
                              
                                this.Hide();
                                Glavna frm_Glavna = new Glavna();
                                frm_Glavna.Show();
                            }
                            else
                            {
                                MessageBox.Show("Pogresna lozinka");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nepostoji takav email");
                        }
                    }
                    catch(Exception greska)
                    {
                        MessageBox.Show(greska.Message);
                    }
                }
            }
            

        }
    }
}
