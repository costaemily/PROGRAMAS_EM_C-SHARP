using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCondominio.BLL
{
    class VisitanteBLL
    {
        int codvisitante;

        public int Codvisitante
        {
            get { return codvisitante; }
            set { codvisitante = value; }
        }
        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        string observacao;

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

    }
}
