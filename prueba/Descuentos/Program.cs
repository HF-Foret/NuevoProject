using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos
{
    internal class Progra
    {
        static void Main(string[] args)
        {
            do
            {
                int unit;
                double price, total, porcent;
                Console.WriteLine("\n Se va acclular el porcetaje de descuento en la compra de unos muebles \n " +
                    "10% por compra minima de 5 muebles, 20% para una compra de 5 a 10 muebles \n " +
                    "y un 40% en una compra superior a 10 muebles\n ");
                Console.WriteLine("El costo de cada mueble es de 6500 pesos: ");

                Console.WriteLine("Ingresa la cantidad de muebles que se van a comprar:");
                unit = int.Parse(Console.ReadLine());
                if (unit < 5)
                {
                    price = (unit * 6500);
                    porcent = (price * 0.1);
                    total = (price - porcent);
                    Console.WriteLine($"Gracias por su compra el total del importe es ${price} \n Ud esta ahorrando ${porcent} \n El monto apagar es de ${total}");
                }
                else if (unit >= 5 && unit < 10)
                {
                    price = (unit * 6500);
                    porcent = (price * 0.2);
                    total = (price - porcent);
                    Console.WriteLine($"Gracias por su compra el total del importe es ${price} \n Ud esta ahorrando ${porcent} \n El monto apagar es de ${total}");
                }
                else
                {
                    price = (unit * 6500);
                    porcent = (price * 0.4);
                    total = (price - porcent);
                    Console.WriteLine($"Gracias por su compra el total del importe es ${price} \n Ud esta ahorrando ${porcent} \n El monto a pagar es de ${total}");
                }

                Console.WriteLine("\nPresione enter para continuar o Ctr + C para fianlizar\n");
                Console.ReadKey();
            } while (true);
        }
    }
}
