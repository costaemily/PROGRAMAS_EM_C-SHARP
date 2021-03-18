using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoCondominio.DAL
{
    class registroDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.RegistroBLL rBLL)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO REGISTRO
            (DATA, HORA,CODMORADOR, OBSERVACAO) VALUES
            (@DATA, @HORA, @CODMORADOR, @OBSERVACAO)", con.conectar());

            cmd.Parameters.AddWithValue("@DATA", rBLL.Data);
            cmd.Parameters.AddWithValue("@HORA", rBLL.Hora);
            cmd.Parameters.AddWithValue("@CODMORADOR", rBLL.Codmorador);
            cmd.Parameters.AddWithValue("@OBSERVACAO", rBLL.Obsrvacao);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM REGISTRO", con.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorNome(BLL.RegistroBLL rBLL)
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM VISITA WHERE CODVISITANTE LIKE @CODVISITANTE", con.conectar());
            da.SelectCommand.Parameters.AddWithValue("@CODMORADOR", rBLL.Codmorador + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.RegistroBLL rBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM REGISTRO WHERE CODREGISTRO = @CODREGISTRO", con.conectar());

            cmd.Parameters.AddWithValue("@CODREGISTRO", rBLL.Codregistro);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public void Alterar(BLL.RegistroBLL rBLL)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE REGISTRO SET
             HORA = @HORA,
             DATA = @DATA,
             CODVISITANTE = @CODVISITANTE,
             
             OBSERVACAO = @OBSERVACAO
             WHERE CODREGISTRO = @CODREGISTRO", con.conectar());

            cmd.Parameters.AddWithValue("@HORA", rBLL.Hora);
            cmd.Parameters.AddWithValue("@DATA", rBLL.Data);
            cmd.Parameters.AddWithValue("@CODMORADOR", rBLL.Codmorador);
            cmd.Parameters.AddWithValue("@OBSERVACAO", rBLL.Obsrvacao);
            cmd.Parameters.AddWithValue("@CODREGISTRO", rBLL.Codregistro);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public BLL.RegistroBLL RetornarDados(BLL.RegistroBLL rBLL)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM REGISTRO
            WHERE CODREGISTRO = @CODREGISTRO", con.conectar());//Passando comando SQL

            cmd.Parameters.AddWithValue("@CODREGISTRO", rBLL.Codregistro);//referencia parametro
            SqlDataReader dr = cmd.ExecuteReader();//Executando leitura dos dados
            if (dr.Read())//conseguiu ler od dados
            {
                //preenchendo as variaveis da classe VisitanteBLL com 
                rBLL.Codregistro = Convert.ToInt16(dr["CODREGISTRO"]);
                rBLL.Hora = Convert.ToDateTime(dr["HORA"]);
                rBLL.Data = Convert.ToDateTime(dr["DATA"]);
                rBLL.Codmorador = Convert.ToInt16(dr["CODMORADOR"]);
                rBLL.Obsrvacao = dr["OBSERVACAO"].ToString();
            }
            dr.Close();//fechando leitura dos dados
            con.Desconectar();//fechando a conexao
            return rBLL;//retornando o objeto VisitanteBLL com todas
        }
    }
}
