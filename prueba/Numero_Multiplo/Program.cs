using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Multiplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int a,b,x;

                Console.WriteLine(" Calcular numero multiplo de otro ");
                Console.WriteLine("Ingrese primer numero para evaluar");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero para evaluar");
                b = Int32.Parse(Console.ReadLine());

                x = (b % a);

                if (x == 0)
                {
                    Console.WriteLine($" El numero {b} es multiplo de {a} ");
                }
                else
                {
                    Console.WriteLine($" El numero {b} no es multiplo de {a} ");
                }

                Console.WriteLine("\nPresione enter para continuar o Ctr + C para fianlizar\n");
                Console.ReadKey();
            }while(true);
        }
    }
}
