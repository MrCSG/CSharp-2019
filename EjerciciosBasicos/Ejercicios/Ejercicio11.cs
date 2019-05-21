/* 11. Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". 
Test Data:
	Enter your age - 25
	Expected Output:
	You look older than 25 */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio11
    {
        public void YouLookOlder()
        {
            int age;
            Console.WriteLine("Cuántos años tienes?");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Tienes {age} años? Pareces mayor ...");
        }
    }
}