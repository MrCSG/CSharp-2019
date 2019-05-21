/* 14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
Test Data:
	Enter the amount of celsius: 30
	Expected Output:
	Kelvin = 303
	Fahrenheit = 86 */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio14
    {
        public void DegreeConverter()
        {
            float celsius,kelvin,fahrenheit;
            Console.Write("Ingrese cantidad de grados en Celsius: ");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = (celsius*1.8f) + 32;
            kelvin = celsius + 273.15f;
            Console.WriteLine("Kelvin = {0}°K",kelvin);
            Console.WriteLine("Fahrenheit = {0}°F",fahrenheit);
        }
    }
}