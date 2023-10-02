using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejericio3_tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de artículos a comprar: ");
            int cantidadArticulos = Convert.ToInt32(Console.ReadLine());

            double precioPorArticulo;

            if (cantidadArticulos <= 10)
            {
                precioPorArticulo = 20.0;
            }
            else
            {
                precioPorArticulo = 15.0;
            }

            double total = cantidadArticulos * precioPorArticulo;

            Console.WriteLine($"Precio por artículo: ${precioPorArticulo}");
            Console.WriteLine($"Total a pagar: ${total}");











        }
    }
}
