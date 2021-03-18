using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoCondominio.DAL
{
    class MoradorDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.MoradorBLL mBLL)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO MORADOR
            (NOME,TELEFONE,CELULAR,EMAIL,CPF,RUA,NUMERO,RG) VALUES
            (@NOME,@TELEFONE,@CELULAR,@EMAIL,@CPF,@RUA,@NUMERO,@RG)", con.conectar());

            cmd.Parameters.AddWithValue("@NOME", mBLL.Nome);
            cmd.Parameters.AddWithValue("@TELEFONE", mBLL.Telefone);
            cmd.Parameters.AddWithValue("@CELULAR", mBLL.Celular);
            cmd.Parameters.AddWithValue("@EMAIL", mBLL.Email);
            cmd.Parameters.AddWithValue("@CPF", mBLL.Cpf);
            cmd.Parameters.AddWithValue("@RUA", mBLL.Rua);
            cmd.Parameters.AddWithValue("@NUMERO", mBLL.Numero);
            cmd.Parameters.AddWithValue("@RG", mBLL.Rg);

            cmd.ExecuteNonQuery();
            con.Desconectar();

        }
        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM MORADOR", con.conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable ConsultarPorNome(BLL.MoradorBLL mBLL)
        {
            SqlDataAdapter da =
            new SqlDataAdapter("SELECT * FROM MORADOR WHERE NOME LIKE @NOME", con.conectar());
            da.SelectCommand.Parameters.AddWithValue("@NOME", mBLL.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.MoradorBLL  mBLL)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM MORADOR WHERE CODMORADOR = @CODMORADOR", con.conectar());

            cmd.Parameters.AddWithValue("@CODMORADOR", mBLL.Codmorador);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public void Alterar(BLL.MoradorBLL mBLL)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE MORADOR SET
            NOME = @NOME,
            TELEFONE = @TELEFONE,
            CELULAR = @CELULAR,
            EMAIL = @EMAIL,
            CPF = @CPF,
            RUA = @RUA,
            NUMERO = @NUMERO,
            RG = @RG
            WHERE CODMORADOR = @CODMORADOR", con.conectar());

            cmd.Parameters.AddWithValue("@NOME", mBLL.Nome);
            cmd.Parameters.AddWithValue("@TELEFONE", mBLL.Telefone);
            cmd.Parameters.AddWithValue("@RG", mBLL.Rg);
            cmd.Parameters.AddWithValue("@CPF", mBLL.Cpf);
            cmd.Parameters.AddWithValue("@CELULAR", mBLL.Celular);
            cmd.Parameters.AddWithValue("@EMAIL", mBLL.Email);
            cmd.Parameters.AddWithValue("@RUA", mBLL.Rua);
            cmd.Parameters.AddWithValue("@NUMERO", mBLL.Numero);

            cmd.Parameters.AddWithValue("@CODMORADOR", mBLL.Codmorador);

            cmd.ExecuteNonQuery(); //executando o comando
            con.Desconectar(); //fechar conexão
        }

        public BLL.MoradorBLL RetornarDados(BLL.MoradorBLL uBLL)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM MORADOR
            WHERE CODMORADOR = @CODMORADOR", con.conectar());//Passando comando SQL

            cmd.Parameters.AddWithValue("@CODMORADOR", uBLL.Codmorador);//referencia parametro
            SqlDataReader dr = cmd.ExecuteReader();//Executando leitura dos dados
            if (dr.Read())//conseguiu ler od dados
            {
                //preenchendo as variaveis da classe VisitanteBLL com 
                uBLL.Codmorador = Convert.ToInt16(dr["CODMORADOR"]);
                uBLL.Telefone = dr["TELEFONE"].ToString();
                uBLL.Nome = dr["NOME"].ToString();
                uBLL.Email = dr["EMAIL"].ToString();
                uBLL.Rua = dr["RUA"].ToString();
                uBLL.Cpf = dr["CPF"].ToString();
                uBLL.Rg = dr["RG"].ToString();
                uBLL.Numero = dr["NUMERO"].ToString();
                uBLL.Celular = dr["CELULAR"].ToString();
            }
            dr.Close();//fechando leitura dos dados
            con.Desconectar();//fechando a conexao
            return uBLL;//retornando o objeto VisitanteBLL com todas
        }
    }
}
