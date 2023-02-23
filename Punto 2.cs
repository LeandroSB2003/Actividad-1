using System;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuál tipo de pizza desea? (1 para la vegetariana, 2 para la no vegetariana)");
            string tipodePizza = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingredientes disponibles para la pizza:");

            if (tipodePizza == "1")
            {
                Console.WriteLine("Pimiento");
                Console.WriteLine("Champiñones");
            }
            else if (tipodePizza == "2")
            {
                Console.WriteLine("Pepperoni");
                Console.WriteLine("Salami");
                Console.WriteLine("Pollo");
            }
            else
            {
                Console.WriteLine("Insertó un número incorrecto");
                return;
            }

            Console.WriteLine("Escribe el nombre del ingrediente que desea en su pizza:");

            string ingrediente = Console.ReadLine();

            string ingredientes = "mozzarella, tomate";

            if (tipodePizza == "1")
            {
                Console.WriteLine("La pizza es vegetariana y lleva los siguientes ingredientes: " + ingredientes + ", " + ingrediente);
            }
            else if (tipodePizza == "2")
            {
                Console.WriteLine("La pizza no es vegetariana y lleva los siguientes ingredientes: " + ingredientes + ", " + ingrediente);
            }
        }
    }
}
