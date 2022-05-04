using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace Esdnevnik
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            string Cs;
            Cs = "Data Source = DESKTOP-CQJ6GR7; Initial Catalog = Esdnevnik; Integrated Security=true";
            SqlConnection veza = new SqlConnection(Cs);
            return veza;
        }
    }
}
