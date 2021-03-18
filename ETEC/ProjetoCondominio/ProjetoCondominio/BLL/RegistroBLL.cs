using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCondominio.BLL
{
    class RegistroBLL
    {
        int codregistro;

        public int Codregistro
        {
            get { return codregistro; }
            set { codregistro = value; }
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
        int codmorador;

        public int Codmorador
        {
            get { return codmorador; }
            set { codmorador = value; }
        }

        string obsrvacao;

        public string Obsrvacao
        {
            get { return obsrvacao; }
            set { obsrvacao = value; }
        }
    }
}
