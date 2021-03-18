using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoCondominio.DAL
{
    class VisitanteDAL
    {
        //referencia para Classe de Conexão
        Conexao con = new Conexao();

        public void Cadastrar(BLL.VisitanteBLL vBLL)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO VISITANTE
            (NOME, CELULAR, RG, OBSERVACAO) VALUES
            (@NOME, @CELULAR, @RG, @OBSERVACAO)", con.conectar());

            cmd.Parameters.AddWithValue("@NOME", vBLL.Nome);
            cmd.Parameters.AddWithValue("@CELULAR", vBLL.Celular);
            cmd.Parameters.AddWithValue("@RG", vBLL.Rg);
            cmd.Parameters.AddWithValue("@OBSERVACAO", vBLL.Observacao);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM VISITANTE", con.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorNome(BLL.VisitanteBLL vBLL)
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM VISITANTE WHERE NOME LIKE @NOME", con.conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOME", vBLL.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.VisitanteBLL vBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM VISITANTE WHERE CODVISITANTE = @CODVISITANTE", con.conectar());

            cmd.Parameters.AddWithValue("@CODVISITANTE", vBLL.Codvisitante);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public void Alterar(BLL.VisitanteBLL vBLL)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE VISITANTE SET
            NOME = @NOME,
             CELULAR = @CELULAR, 
             RG = @RG, 
             OBSERVACAO = @OBSERVACAO
             WHERE CODVISITANTE = @CODVISITANTE", con.conectar());

            cmd.Parameters.AddWithValue("@NOME", vBLL.Nome);
            cmd.Parameters.AddWithValue("@CELULAR", vBLL.Celular);
            cmd.Parameters.AddWithValue("@RG", vBLL.Rg);
            cmd.Parameters.AddWithValue("@OBSERVACAO", vBLL.Observacao);
            cmd.Parameters.AddWithValue("@CODVISITANTE", vBLL.Codvisitante);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public BLL.VisitanteBLL RetornarDados(BLL.VisitanteBLL vBLL)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM VISITANTE
            WHERE CODVISITANTE = @CODVISITANTE", con.conectar());//Passando comando SQL

            cmd.Parameters.AddWithValue("@CODVISITANTE", vBLL.Codvisitante);//referencia parametro
            SqlDataReader dr = cmd.ExecuteReader();//Executando leitura dos dados
            if (dr.Read())//conseguiu ler od dados
            {
                //preenchendo as variaveis da classe VisitanteBLL com 
                vBLL.Codvisitante = Convert.ToInt16(dr["CODVISITANTE"]);
                vBLL.Celular = dr["CELULAR"].ToString();
                vBLL.Nome = dr["NOME"].ToString();
                vBLL.Observacao = dr["OBSERVACAO"].ToString();
                vBLL.Rg = dr["RG"].ToString();
            }
            dr.Close();//fechando leitura dos dados
            con.Desconectar();//fechando a conexao
            return vBLL;//retornando o objeto VisitanteBLL com todas
        }
    }
}
