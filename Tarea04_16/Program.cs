using System;

namespace Tarea04_16
{
    class Program
    {
        static void Main(string[] args)
        {
            const int iva = 21;

            Console.Write("Introduce el precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Precio del artículo: {0} euros, IVA: {1}% .... Precio TOTAL ({2}% IVA Incluido): {3} euros.", precio, (precio * iva) / 100, iva, precio + (precio*iva)/100 );

            Console.ReadKey();

        }
    }
}
