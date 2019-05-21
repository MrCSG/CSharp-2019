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
                case "8":
                    Ejercicio8 multTable = new Ejercicio8();
                    multTable.MultiplicationTable();
                    break;
                case "9":
                    Ejercicio9 avrg = new Ejercicio9();
                    avrg.Average();
                    break;
                case "10":
                    Ejercicio10 multTest = new Ejercicio10();
                    multTest.MultiplicationTest();
                    break;
                case "11":
                    Ejercicio11 old = new Ejercicio11();
                    old.YouLookOlder();
                    break;
                case "12":
                    Ejercicio12 writeTest = new Ejercicio12();
                    writeTest.WriteTest();
                    break;
                case "13":
                    Ejercicio13 rect35 = new Ejercicio13();
                    rect35.Rectangle35();
                    break;
                case "14":
                    Ejercicio14 degree = new Ejercicio14();
                    degree.DegreeConverter();
                    break;
                case "15":
                    Ejercicio15 remChar = new Ejercicio15();
                    remChar.RemoveChars();
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
