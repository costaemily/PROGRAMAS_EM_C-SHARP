using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoFeedback.DAL
{
    class AdoreiDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.AdoreiBLL aBLL)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO ADOREI (VALORADOREI)
            VALUES (@VALORADOREI)", con.Conectar());

            cmd.Parameters.AddWithValue("@VALORADOREI", aBLL.ValorAdorei);

            cmd.ExecuteNonQuery();//Executando o comando
            con.Desconectar();//
        }
    }
}
