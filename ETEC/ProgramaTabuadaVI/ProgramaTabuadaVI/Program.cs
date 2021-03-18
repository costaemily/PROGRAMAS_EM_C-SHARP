using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTabuadaVI
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i, result, opc;
            do
            {
                Console.WriteLine("1- Tabuada\n2- Sair");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite um número:");
                        numero = int.Parse(Console.ReadLine());

                        if (numero > 10)
                        {
                            Console.WriteLine("Número inválido");
                        }
                        else
                        {
                            Console.WriteLine("........ Tabuada do " + numero + ".........");
                            for (i = 0; i < 21; i++)
                            {
                                result = numero * i;
                                Console.WriteLine("\t" + numero + "x" + i + "=" + result);
                            }
                        }
                        break;

                    case 2:
                        Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opc < 2);
        }
    }
}
