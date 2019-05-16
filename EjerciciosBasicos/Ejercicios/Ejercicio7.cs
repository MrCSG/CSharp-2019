/* 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
Test Data:
	Input the first number: 25
	Input the second number: 4
	Expected Output:
	25 + 4 = 29
	25 - 4 = 21
	25 x 4 = 100 
	25 / 4 = 6
	25 mod 4 = 1 */

using System;
namespace EjerciciosBasicos
{
    class Ejercicio7
    {
        public void Operations5()
        {
            Console.WriteLine("Ingrese 2 números a mostrar sus resultados entre diferentes operaciones:");
            int x,y;
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x+y}");
            Console.WriteLine($"{x} - {y} = {x-y}");
            Console.WriteLine($"{x} * {y} = {x*y}");
            Console.WriteLine($"{x} / {y} = {x/y}");
            Console.WriteLine($"{x} mod {y} = {x%y}");
        }
    }
}