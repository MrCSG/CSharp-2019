/* 10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
Test Data:
	Enter first number - 5
	Enter second number - 6
	Enter third number - 7


Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72 */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio10
    {
        public void MultiplicationTest()
        {
            int x,y,z;
            Console.WriteLine("Ingrese 3 números:");
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            z = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"({x}+{y})*{z}={(x+y)*z}\n{x}*{y}+{y}*{z}={x*y+y*z}");
        }
    }
}