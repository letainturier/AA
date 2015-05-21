using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IndicateursAA
{
    class Class1
    {
        public SqlConnection cnx = new SqlConnection(@"Data Source=jordy-PC\LETAINTURIER;Initial Catalog=Avion;Integrated Security=True");
        public SqlDataReader dr;
        public string s;
    }

}
