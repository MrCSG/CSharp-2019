//3. Write a C# Sharp program to print the result of dividing two numbers.
using System;

namespace EjerciciosBasicos
{
    class Ejercicio3
    {
        public void Division()
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Ingrese 2 números a dividir:");
            if (Int32.TryParse(Console.ReadLine(),out firstNumber))
            {
                Console.WriteLine("/");
                if (Int32.TryParse(Console.ReadLine(),out secondNumber)&&(secondNumber!=0))
                {
                    Console.WriteLine($"=\n{(float)firstNumber / secondNumber}");
                }
                else
                {
                    Console.WriteLine("El dato ingresado no es un número o no es posible realizar la división.");
                }
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un número.");
            }
        }
    }
}