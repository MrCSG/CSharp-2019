using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;

            Console.WriteLine("Ingrese los datos del 1° Alumno:");
            Console.Write("Nombre: ");
            name = Console.ReadLine();
            Console.Write("Edad: ");
            age = UInt16.Parse(Console.ReadLine());
            Alumno a1 = new Alumno(name,age);
            Console.WriteLine("Ingrese los datos del 2° Alumno:");
            Console.Write("Nombre: ");
            name = Console.ReadLine();
            Console.Write("Edad: ");
            age = UInt16.Parse(Console.ReadLine());
            Alumno a2 = new Alumno(name,age);
            Console.WriteLine("Ingrese los datos del 3° Alumno:");
            Console.Write("Nombre: ");
            name = Console.ReadLine();
            Console.Write("Edad: ");
            age = UInt16.Parse(Console.ReadLine());
            Alumno a3 = new Alumno(name,age);

            a1.ShowData();
            a2.ShowData();
            a3.ShowData();

            a1.LegalAge();
            a2.LegalAge();
            a3.LegalAge();
        }
    }
}
