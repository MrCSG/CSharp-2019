/* 6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
Test Data:
	Input the first number to multiply: 2
	Input the second number to multiply: 3
	Input the third number to multiply: 6
	Expected Output:
	2 x 3 x 6 = 36 */

using System;
namespace EjerciciosBasicos
{
    class Ejercicio6
    {
        public void Multiply3Numbers()
        {
            int numberToMultiply;
            Console.WriteLine("Ingrese 3 números a multiplicar:");
            numberToMultiply = Int32.Parse(Console.ReadLine());
            Console.WriteLine("*");
            numberToMultiply *= Int32.Parse(Console.ReadLine());
            Console.WriteLine("*");
            numberToMultiply *= Int32.Parse(Console.ReadLine());
            Console.WriteLine($"=\n{numberToMultiply}");
        }
    }
}