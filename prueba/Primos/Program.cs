using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num;
                Console.WriteLine("Calculo de un numero para saber si es numero primo \n ");
                Console.WriteLine("ingrese un numero para validar: \n ");
                num = Convert.ToInt32(Console.ReadLine());

                bool primo;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    { 
                        primo = false;
                        Console.WriteLine($"El numero {i} no es primo");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {i} es primo");
                    }
                    


                }

                Console.WriteLine("\nPresione enter para continuar o Ctr + C para fianlizar\n");
                Console.ReadKey();
            } while (true);
        }
    }
}
