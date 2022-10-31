using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Año_Bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int fecha;
                Console.WriteLine("Calcular si un año es Bisiesto o no \n ");
                Console.WriteLine("Ingresa un el año a evaluar: \n ");
                fecha = Int32.Parse(Console.ReadLine());

                if (fecha % 4 != 0 || (fecha % 100 == 0 && fecha % 400 != 0))
                {
                    Console.WriteLine(" Este año NO es Bisiesto");
                }
                else
                {
                    Console.WriteLine(" Este año SI es Bisiesto");
                }

                Console.WriteLine("\nPresione enter para continuar o Ctr + C para fianlizar\n");
                Console.ReadKey();
            } while (true);
        }
    }
}
