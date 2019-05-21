/* 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
	Enter the First number: 10 
	Enter the Second number: 15 
	Enter the third number: 20 
	Enter the four number: 30 


Expected Output:
The average of 10 , 15 , 20 , 30 is: 18 */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio9
    {
        public void Average()
        {
            float average;
            int number1,number2,number3,number4;
            Console.Write("Ingrse el primer número: ");
            number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrse el segundo número: ");
            number2 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrse el tercer número: ");
            number3 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrse el cuarto número: ");
            number4 = Int32.Parse(Console.ReadLine());
            average = (number1+number2+number3+number4)/4.0f;
            Console.WriteLine($"El promedio es: {average}");
        }
    }
}