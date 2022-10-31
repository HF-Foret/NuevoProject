using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_loop_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cal = "";
            int exam = 0;
            int work = 0;
            int proyect = 0;
            double suma = 0;
            double promedio = 0;

            do
            {
                Console.WriteLine("se requiere calcular el promedio de un estudiante \n" +
                    " se pedira la nota de examen, trabajo proyecto \n");

                Console.WriteLine("Ingrese la calificacion de examen");
                cal = Console.ReadLine();
                exam = Convert.ToInt32(cal);
                Console.WriteLine("Ingrese la calificacion de trabajos");
                cal = Console.ReadLine();
                work = Convert.ToInt32(cal);
                Console.WriteLine("Ingrese la calificacion de proyecto");
                cal = Console.ReadLine();
                proyect = Convert.ToInt32(cal);
                int val = 3;
                 if (exam != 0 && work != 0 && promedio != 0)
                 {
                    suma = exam + work + proyect;
                    promedio = suma / val;
                 }
                  else
                  {
                   Console.WriteLine("Ingrese un valor valido");
                  }
               
            } while (true);
            promedio = suma / 3;
            Console.WriteLine($"El promedio es:{promedio}");
            Console.ReadKey();
            Console.Write("no compila");

        }
    }
}
