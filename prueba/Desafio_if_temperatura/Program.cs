using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_if_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string tem = "";
            int cal = 0;
            string mensajes = "";
            do
            {
                Console.WriteLine("\n Calcular la temperatura para salir. ");
                Console.WriteLine("Digite la temperatura: \n ");
                tem = Console.ReadLine();
                bool val = int.TryParse(tem, out cal);
                if (val == true)
                {
                    mensajes = cal <= 15 ? "Hace mucho frio abrigate bien" : "";
                    Console.WriteLine(mensajes);
                    mensajes = cal >= 16 && cal <= 28 ? "Hace un clima agradable puedes salir con ropa comoda" : "";
                    Console.WriteLine(mensajes);
                    mensajes = cal >= 28 && cal <= 50 ? "Hace mucho calor se antoja ir a la playa" : "";
                    Console.WriteLine(mensajes);
                }
                else
                {
                    Console.WriteLine("Temperatura no valida intente otra vez ");
                }
            } while (tem != "");

        }
    }
}
