using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado1, lado2, lado3;
            int opc;

            do
            {
                Console.WriteLine("1- Calcular triângulo\n2- Sair");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Write down the first size:");
                        lado1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Write down the second size:");
                        lado2 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Write down the third size:");
                        lado3 = float.Parse(Console.ReadLine());



                        if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
                        {
                            Console.WriteLine("Triângulo Escaleno");
                        }
                        else if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || (lado2 != lado3 && lado1 != lado3))
                        {
                            Console.WriteLine("Triangulo Isósceles");
                        }
                        else
                        {
                            Console.WriteLine("Triangulo Equilátero");
                        }
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        Environment.Exit(1);
                        break;
                }
            }
            while (opc == 1);
        }
    }
}
