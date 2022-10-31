using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do { 
                int x;

                Console.WriteLine("Evualuar si un numero es par o impar \n ");
                Console.WriteLine("Ingrese un numero para evaluar \n ");
                x = Int32.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    //contatenar 
                    //formato de texto
                    //interpolacion

                    Console.WriteLine($" numero {x} es par ");
                }
                else
                {
                    Console.WriteLine($" El numero {x} es impar ");
                }


                Console.WriteLine("\nPresione enter para continuar o Ctr + C para fianlizar\n");
                Console.ReadKey();
            }while (true);
        }
    }
}
