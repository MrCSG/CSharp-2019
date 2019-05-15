using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Ingrese la longitud del array:");
            i = Int32.Parse(Console.ReadLine());
            int [] numbers = new int [i];
            i = 0;
            Console.WriteLine("Ahora ingrese los {0} números:", numbers.Length);
            while(i < numbers.Length)
            {
                if(Int32.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    i++;
                }else
                {
                    Console.WriteLine("Ese no es un número, intente de nuevo.");
                }
            }
            i=0;
            while(i<numbers.Length)
            {
                Console.WriteLine("Valor del elemento {0} : {1}", i, numbers[i]);
                i++;
            }
        }
    }
}
