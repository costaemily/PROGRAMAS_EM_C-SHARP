using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Aluno:Carolina
             Data:16/03/2018
             Funcionalidade:Calculadora*/

            double c1, c2;
            int op, opc;
            do
            {
                Console.WriteLine("1- Calculadora\n2- Sair");

               opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número:");
                        c1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número:");
                        c2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("Selecione uma opção");
                        Console.WriteLine("");
                        Console.WriteLine("Digite 5 para somar");
                        Console.WriteLine("...................");
                        Console.WriteLine("Digite 6 para subtrair");
                        Console.WriteLine("......................");
                        Console.WriteLine("Digite 7 para multiplicar");
                        Console.WriteLine(".........................");
                        Console.WriteLine("Digite 8 para dividir");
                        Console.WriteLine("......................");
                        Console.WriteLine("Digite 9 para sair");
                        Console.WriteLine("********************");

                        op = int.Parse(Console.ReadLine());

                        switch (op)
                        {
                            case 5:
                                Console.WriteLine("{0} + {1}= {2}", c1, c2, c1 + c2);
                                break;

                            case 6:
                                Console.WriteLine("{0} - {1}= {2}", c1, c2, c1 - c2);
                                break;

                            case 7:
                                Console.WriteLine("{0} X {1}= {2}", c1, c2, c1 * c2);
                                break;

                            case 8:
                                Console.WriteLine("{0} / {1}= {2}", c1, c2, c1 / c2);
                                break;

                            case 9:
                                Environment.Exit(1);
                                break;

                            default:
                                Console.WriteLine("Escolha inválida");
                                break;
                        }
                        break;

                    case 2:
                        Environment.Exit(1);
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
            while (opc == 1);
        }

    }
}
    


