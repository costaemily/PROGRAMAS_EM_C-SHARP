using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoFeedback.DAL
{
    class GosteiDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.GosteiBLL gBLL)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO GOSTEI (VALORGOSTEI)
            VALUES (@VALORGOSTEI)", con.Conectar());

            cmd.Parameters.AddWithValue("@VALORGOSTEI", gBLL.ValorGostei);

            cmd.ExecuteNonQuery();//Executando o comando
            con.Desconectar();//
        }
    }
}
