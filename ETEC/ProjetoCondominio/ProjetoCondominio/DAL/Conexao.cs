using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//precisa
using System.Data.SqlClient;//precisa

namespace ProjetoCondominio.DAL
{
    class Conexao
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);
                                                Initial Catalog=BDCONDOMINIO;
                                                Integrated Security=true;");

        public SqlConnection conectar() 
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
