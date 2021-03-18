using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoCondominio.DAL
{
    class UsuarioDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.usuarioBLL uBLL)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO USUARIO
            (NOME,RG,CPF,TELEFONE,NOMEUSUARIO,SENHA) VALUES
            (@NOME,@RG,@CPF,@TELEFONE,@NOMEUSUARIO,@SENHA)", con.conectar());

            cmd.Parameters.AddWithValue("@NOME", uBLL.Nome);
            cmd.Parameters.AddWithValue("@RG", uBLL.Rg);
            cmd.Parameters.AddWithValue("@CPF", uBLL.Cpf);
            cmd.Parameters.AddWithValue("@TELEFONE", uBLL.Telefone);
            cmd.Parameters.AddWithValue("@NOMEUSUARIO", uBLL.NomeUsuario);
            cmd.Parameters.AddWithValue("@SENHA", uBLL.Senha);

            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM USUARIO", con.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorNome(BLL.usuarioBLL uBLL)
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM USUARIO WHERE NOME LIKE @NOME", con.conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOME", uBLL.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.usuarioBLL uBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM USUARIO WHERE CODUSU = @CODUSU", con.conectar());

            cmd.Parameters.AddWithValue("@CODUSU", uBLL.Codusu);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }


        public void Alterar(BLL.usuarioBLL uBLL)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE USUARIO SET
            NOME = @NOME,
            RG = @RG,
            CPF = @CPF,
            TELEFONE = @TELEFONE,
            NOMEUSUARIO = @NOMEUSUARIO,
            SENHA = @SENHA
            WHERE CODUSU = @CODUSU", con.conectar());

            cmd.Parameters.AddWithValue("@NOME", uBLL.Nome);
            cmd.Parameters.AddWithValue("@TELEFONE", uBLL.Telefone);
            cmd.Parameters.AddWithValue("@RG", uBLL.Rg);
            cmd.Parameters.AddWithValue("@CPF", uBLL.Cpf);
            cmd.Parameters.AddWithValue("@NOMEUSUARIO", uBLL.NomeUsuario);
            cmd.Parameters.AddWithValue("@SENHA", uBLL.Senha);

            cmd.Parameters.AddWithValue("@CODUSU", uBLL.Codusu);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public BLL.usuarioBLL RetornarDados(BLL.usuarioBLL uBLL)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM USUARIO
            WHERE CODUSU = @CODUSU", con.conectar());//Passando comando SQL

            cmd.Parameters.AddWithValue("@CODUSU", uBLL.Codusu);//referencia parametro
            SqlDataReader dr = cmd.ExecuteReader();//Executando leitura dos dados
            if (dr.Read())//conseguiu ler od dados
            {
                //preenchendo as variaveis da classe VisitanteBLL com 
                uBLL.Codusu = Convert.ToInt16(dr["CODUSU"]);
                uBLL.Telefone = dr["TELEFONE"].ToString();
                uBLL.Nome = dr["NOME"].ToString();
                uBLL.NomeUsuario = dr["NOMEUSUARIO"].ToString();
                uBLL.Senha = dr["SENHA"].ToString();
                uBLL.Cpf = dr["CPF"].ToString();
                uBLL.Rg = dr["RG"].ToString();
            }
            dr.Close();//fechando leitura dos dados
            con.Desconectar();//fechando a conexao
            return uBLL;//retornando o objeto VisitanteBLL com todas
        }

        public BLL.usuarioBLL Logar(BLL.usuarioBLL uBLL)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM USUARIO
            WHERE NOMEUSUARIO = @NOMEUSUARIO
            AND SENHA = @SENHA", con.conectar());//Passando comando SQL

            cmd.Parameters.AddWithValue("@NOMEUSUARIO", uBLL.NomeUsuario);//referencia parametro
            cmd.Parameters.AddWithValue("@SENHA", uBLL.Senha);//referencia parametro
            SqlDataReader dr = cmd.ExecuteReader();//Executando leitura dos dados
            if (dr.Read())//conseguiu ler od dados
            {
                //preenchendo as variaveis da classe VisitanteBLL com 
                uBLL.Codusu = Convert.ToInt16(dr["CODUSU"]);
                uBLL.Telefone = dr["TELEFONE"].ToString();
                uBLL.Nome = dr["NOME"].ToString();
                uBLL.NomeUsuario = dr["NOMEUSUARIO"].ToString();
                uBLL.Senha = dr["SENHA"].ToString();
                uBLL.Cpf = dr["CPF"].ToString();
                uBLL.Rg = dr["RG"].ToString();
            }
            else
            {
                uBLL.NomeUsuario = null;
            }
            dr.Close();//fechando leitura dos dados
            con.Desconectar();//fechando a conexao
            return uBLL;//retornando o objeto VisitanteBLL com todas
        }

    }
}
