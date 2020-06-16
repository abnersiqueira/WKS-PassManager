using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=wks.ct8ezavef84l.sa-east-1.rds.amazonaws.com;Initial Catalog=wks;User ID=admin;Password=$Rv#passmanager";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

    }
}


