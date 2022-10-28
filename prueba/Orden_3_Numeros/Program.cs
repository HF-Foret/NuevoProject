using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_3_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int a,b,c;

                Console.WriteLine("Ordenar 3 numeros de mayor a menor");
                Console.WriteLine("Ingrese primer numero para ordenarlo");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero para ordenalo");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tercer numero para ordenarlo");
                c = Int32.Parse(Console.ReadLine());

                if (a > b && b > c)
                {
                    Console.WriteLine($" El numero {a} es mayor, el numero {b} el de enmedio y el numero {c} es el menor");
                }
                else if (a > c && c > b)
                {
                    Console.WriteLine($"El numero {a} es mayor,el numero {c} es el del enmedio y el numero {b} es el menor");
                }
                else if (b > a && a > c)
                {
                    Console.WriteLine($"el numero {b} es mayor, el numero {a} es el de enmedio y el numero {c} es el menor ");
                }
                else if (b > c && c > a)
                {
                    Console.WriteLine($"El numero {b} es mayor, el numero {c} es el de enmedio y el numero {a} es el menor");
                }
                else if (c > a && a > b)
                {
                    Console.WriteLine($"El numero {c} es mayor, el numero {a} es el de enmedio y el numero {b} es el menor");
                }
                else if (c > b && b > a)
                {
                    Console.WriteLine($"El numero {c} es mayor, el numero {b} es el de enmedio y el numero {a} es el menor");
                }
                else
                {
                    Console.WriteLine("No ingreso un numero valido vuelve a intentarlo");
                }

                Console.WriteLine("\nPresione enter para continuar o Ctr + C para fianlizar\n");
                Console.ReadKey();
            } while (true);
        }
    }
}
