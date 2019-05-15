using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la longitud del array:");
            int i = Int32.Parse(Console.ReadLine()), lookFor, quantity = 0;
            int [] numbers = new int [i];
            i = 0;
            while(i < numbers.Length)
            {
                Console.Write("Ingrese el valor del elemento {0} :", i);
                if(Int32.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    i++;
                }else
                {
                    Console.WriteLine("Ese no es un número, intente de nuevo.");
                }
            }
            Console.WriteLine("Qué número desea buscar en este array?");
            lookFor = Int32.Parse(Console.ReadLine());
            i = 0;
            while(i<numbers.Length)
            {
                if (numbers[i] == lookFor)
                {
                    quantity ++;
                }
                i++;
            }
            Console.WriteLine($"El número {lookFor} aparece {quantity} veces en el array");
        }
    }
}
