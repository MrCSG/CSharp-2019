/*5. Write a C# Sharp program to swap two numbers.
Test Data:
	Input the First Number : 5
	Input the Second Number : 6
	Expected Output: 
	After Swapping :
	First Number : 6 
	Second Number : 5*/
using System;

namespace EjerciciosBasicos
{
    class Ejercicio5
    {
        public void SwapNumbers()
        {
            int firstNumber, secondNumber, aux;
            Console.Write("Ingrese el primer número:");
            if(Int32.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.Write("Ingrese el segundo número:");
                if(Int32.TryParse(Console.ReadLine(), out secondNumber))
                {
                    aux = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = aux;
                    Console.WriteLine($"Cambiando posición de números...\nPrimer número: {firstNumber}\nSegundo número: {secondNumber}");
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