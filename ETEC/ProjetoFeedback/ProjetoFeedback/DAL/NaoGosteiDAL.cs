using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoFeedback.DAL
{
    class NaoGosteiDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.NaoGosteiBLL nBLL)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO NAOGOSTEI (VALORNAOGOSTEI)
            VALUES (@VALORNAOGOSTEI)", con.Conectar());

            cmd.Parameters.AddWithValue("@VALORNAOGOSTEI", nBLL.ValorNaoGostei);

            cmd.ExecuteNonQuery();//Executando o comando
            con.Desconectar();//
        }
    }
}
