using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_if_juego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double punt;
                string name;
                double punt2 = 500;
                string name2 = "Gera";

                Console.WriteLine("Ingrese el nombre");
                name = Console.ReadLine();
                Console.WriteLine("Ingrese la puntuacion");
                punt = Double.Parse(Console.ReadLine());

             
                
                if (punt > punt2)
                {
                 Console.WriteLine($"{name} Es la persona que rompio el record");
                 Console.WriteLine($"Superando a {name2}");
                 Console.WriteLine($"Con los puntos: {punt}");
                }
                else
                {
                 Console.WriteLine($"{name2} Es la persona que aun tiene el puntaje record");
                 Console.WriteLine($"{punt2} Sigue siendo la mejor puntuacion");
                }
                

                Console.WriteLine("\nPresione enter para continuar o Ctr + C para fianlizar\n");
                Console.ReadKey();
            } while (true);
        }
    }
}
