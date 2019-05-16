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
                case "3":
                    Ejercicio3 div = new Ejercicio3();
                    div.Division();
                    break;
                case "4":
                    Ejercicio4 oper = new Ejercicio4();
                    oper.Operations();
                    break;
                case "5":
                    Ejercicio5 swap = new Ejercicio5();
                    swap.SwapNumbers();
                    break;
                case "6":
                    Ejercicio6 mult = new Ejercicio6();
                    mult.Multiply3Numbers();
                    break;
                case "7":
                    Ejercicio7 oper5 = new Ejercicio7();
                    oper5.Operations5();
                    break;
                default:
                    Console.WriteLine("Esa opción no existe.");
                    break;
            }

            Console.Write("Presione ENTER para salir...");
            Console.ReadLine();
        }
    }
}
