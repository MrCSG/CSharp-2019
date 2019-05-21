/* 8. Write a C# Sharp program that takes a number as input and print its multiplication table.
Test Data:
	Enter the number: 5
	Expected Output:
	5 * 0 = 0
	5 * 1 = 5
	5 * 2 = 10 
	5 * 3 = 15
	....
	5 * 10 = 50 */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio8
    {
        public void MultiplicationTable()
        {
            int numberToMult;
            Console.WriteLine("Ingrese un número para mostrar su tabla de múltiplicación:");
            numberToMult = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numberToMult} * {i} = {numberToMult*i}");
            }
        }

    }
}