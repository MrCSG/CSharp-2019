using System;

namespace EjerciciosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            string choosedOption = "";
            Console.WriteLine("Ingrese el número de ejercicio que desea ver: (1...16)");
            choosedOption = Console.ReadLine();

            switch(choosedOption)
            {
                case "1":
                    Ejercicio1 greetings = new Ejercicio1();
                    greetings.HelloName();
                    break;
                case "2":
                    Ejercicio2 sum = new Ejercicio2();
                    sum.Addition();
                    break;
                default:
                    Console.WriteLine("Esa opción no existe.");
                    break;
            }
            //
            Console.Write("Presione ENTER para salir...");
            Console.ReadLine();
        }
    }
}
