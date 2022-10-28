using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int n,cont,f;
                Console.WriteLine("Calculo de un numero para saber si es factorial");
                Console.WriteLine("ingrese un numero para validar: ");

                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine($" El factorial de {n} es 1");
                }
                else
                {
                    f = n;
                    for (cont = n; cont > 1; cont--)
                    {
                        f = f*(cont - 1);
                    }    
                    Console.WriteLine($" El factorial de {n} es {f}");
                    if (f == 0)
                        Console.WriteLine($"el numero {n} no tiene factorial ");
                }


                Console.WriteLine("\nPresione enter para continuar o Ctr + C para fianlizar\n");
                Console.ReadKey();
            } while (true);
        }
    }
}
