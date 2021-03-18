using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCondominio.BLL
{
    class VisitaBLL
    {
        int codvisita;

        public int Codvisita
        {
            get { return codvisita; }
            set { codvisita = value; }
        }
        DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        DateTime hora;

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        int codvisitante;

        public int Codvisitante
        {
            get { return codvisitante; }
            set { codvisitante = value; }
        }

        int codmorador;

        public int Codmorador
        {
            get { return codmorador; }
            set { codmorador = value; }
        }
        string observacao;

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }
    }
}
