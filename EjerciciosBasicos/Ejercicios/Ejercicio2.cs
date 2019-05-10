//2. Write a C# Sharp program to print the sum of two numbers.
using System;

namespace EjerciciosBasicos
{
    class Ejercicio2
    {
        public void Addition()
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Ingrese 2 números a sumar:");
            if (Int32.TryParse(Console.ReadLine(),out firstNumber))
            {
                Console.WriteLine("+");
                if (Int32.TryParse(Console.ReadLine(),out secondNumber))
                {
                    Console.WriteLine($"=\n{firstNumber+secondNumber}");
                }
                else
                {
                    Console.WriteLine("El dato ingresado no es un número.");
                }
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un número.");
            }
        }
    }
}