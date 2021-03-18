using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTabuada
{
    class Tabuada
    {
        int i, z, result;

        public void Multiplicacao()
        {
            for (i = 0; i < 11; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("......Tabuada do " + i + "........");
                for (z = 1; z < 21; z++)
                {
                    result = i * z;
                    Console.WriteLine("\t" + i + "x" + z + "=" + result);//Comenta que \t é pra dar um tab 
                }
            }
            Console.ReadKey();
        }
    }
}
