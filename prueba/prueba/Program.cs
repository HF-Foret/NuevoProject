using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_Menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       // Operadores unarios
            do
            {
                int num1,num2,num3;

                Console.WriteLine("Evaluar 3 numero cual es mayor y cual es menor");
                Console.WriteLine("Ingrese primer numero para evaluar");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero para evaluar");
                num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tercer numero para evaluar");
                num3 = Int32.Parse(Console.ReadLine());

                // abc,acb,bac,bca,cab,cba
                if (num1 > num2 && num2 > num3)
                {
                    Console.WriteLine($" El numero {num1} es mayor y el numero {num3} es el menor");
                }
                else if (num1 > num3 && num3 > num2)
                {
                    Console.WriteLine($" El numero {num1} es mayor y el numero {num2} es el menor");
                }
                else if (num2 > num1 && num1 > num3)
                {
                    Console.WriteLine($" El numero {num2} es mayor y el numero {num3} es el menor");
                }
                else if (num2 > num3 && num3 > num1)
                {
                    Console.WriteLine($" El numero {num2} es mayor y el numero {num1} es el menor");
                }
                else if (num3 > num1 && num1 > num2)
                {
                    Console.WriteLine($" El numero {num3} es mayor y el numero {num2} es el menor");
                }
                else if (num3 > num2 && num2 > num1)
                {
                    Console.WriteLine($" El numero {num3} es mayor y el numero {num1} es el menor");
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
