using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoCondominio.DAL
{
    class visitaDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.VisitaBLL viBLL)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO VISITA
            (DATA, HORA,CODVISITANTE, CODMORADOR, OBSERVACAO) VALUES
            (@DATA, @HORA, @CODVISITANTE, @CODMORADOR, @OBSERVACAO)", con.conectar());

            cmd.Parameters.AddWithValue("@DATA", viBLL.Data);
            cmd.Parameters.AddWithValue("@HORA", viBLL.Hora);
            cmd.Parameters.AddWithValue("@CODVISITANTE", viBLL.Codvisitante);
            cmd.Parameters.AddWithValue("@CODMORADOR", viBLL.Codmorador);
            cmd.Parameters.AddWithValue("@OBSERVACAO", viBLL.Observacao);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da =
            new SqlDataAdapter(@"", con.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorNome(BLL.VisitaBLL viBLL)
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM VISITA WHERE CODVISITANTE LIKE @CODVISITANTE", con.conectar());
            da.SelectCommand.Parameters.AddWithValue("@CODVISITANTE", viBLL.Codvisitante + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.VisitaBLL viBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM VISITA WHERE CODVISITA = @CODVISITA", con.conectar());

            cmd.Parameters.AddWithValue("@CODVISITA", viBLL.Codvisita);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public void Alterar(BLL.VisitaBLL viBLL)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE VISITA SET
             HORA = @HORA,
             DATA = @DATA,
             CODVISITANTE = @CODVISITANTE,
             CODMORADOR = @CODMORADOR,
             
             OBSERVACAO = @OBSERVACAO
             WHERE CODVISITA = @CODVISITA", con.conectar());

            cmd.Parameters.AddWithValue("@HORA", viBLL.Hora);
            cmd.Parameters.AddWithValue("@DATA", viBLL.Data);
            cmd.Parameters.AddWithValue("@CODVISITANTE", viBLL.Codvisitante);
            cmd.Parameters.AddWithValue("@CODMORADOR", viBLL.Codmorador);
            cmd.Parameters.AddWithValue("@OBSERVACAO", viBLL.Observacao);
            cmd.Parameters.AddWithValue("@CODVISITA", viBLL.Codvisita);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public BLL.VisitaBLL RetornarDados(BLL.VisitaBLL viBLL)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM VISITA
            WHERE CODVISITA = @CODVISITA", con.conectar());//Passando comando SQL

            cmd.Parameters.AddWithValue("@CODVISITA", viBLL.Codvisita);//referencia parametro
            SqlDataReader dr = cmd.ExecuteReader();//Executando leitura dos dados
            if (dr.Read())//conseguiu ler od dados
            {
                //preenchendo as variaveis da classe VisitanteBLL com 
                viBLL.Codvisita = Convert.ToInt16(dr["CODVISITA"]);
                viBLL.Hora = Convert.ToDateTime( dr["HORA"]);
                viBLL.Data = Convert.ToDateTime( dr["DATA"]);
                viBLL.Codvisitante = Convert.ToInt16(dr["CODVISITANTE"]);
                viBLL.Codmorador = Convert.ToInt16(dr["CODMORADOR"]);
                viBLL.Observacao = dr["OBSERVACAO"].ToString();
            }
            dr.Close();//fechando leitura dos dados
            con.Desconectar();//fechando a conexao
            return viBLL;//retornando o objeto VisitanteBLL com todas
        }
    }
}
