using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercio1progra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la tienda de camisas");

            
            Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
            int cantidadCamisas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio unitario de las camisas: ");
            double precioUnitario = double.Parse(Console.ReadLine());

            
            double precioTotal = cantidadCamisas * precioUnitario;

            
            double descuento = 0;

            if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                descuento = precioTotal * 0.15;
            }
            else if (cantidadCamisas > 5)
            {
                descuento = precioTotal * 0.20;
            }

            
            double precioTotalConDescuento = precioTotal - descuento;

            
            Console.WriteLine($"El precio total con descuento es: ${precioTotalConDescuento:N2}");









        }
    }
}
