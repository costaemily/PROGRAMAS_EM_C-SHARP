using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCondominio.BLL
{
    class usuarioBLL
    {
        int codusu;

        public int Codusu
        {
            get { return codusu; }
            set { codusu = value; }
        }
        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        string nomeUsuario;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
