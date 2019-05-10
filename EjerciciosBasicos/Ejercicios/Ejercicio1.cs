//1. Write a C# Sharp program to print Hello and your name in a separate line.
//Expected Output : Hello: Iván Franco

using System;

namespace EjerciciosBasicos
{
    class Ejercicio1
    {
        public void HelloName()
        {
            string fullName = "";
            Console.WriteLine("Cómo te llamás?");
            fullName = Console.ReadLine();
            Console.WriteLine($"Hola {fullName}");
        }
    }
}