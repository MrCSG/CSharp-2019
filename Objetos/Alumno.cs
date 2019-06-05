using System;

namespace Objetos
{
    public class Alumno
    {
        private string name;
        private ushort age;

        public Alumno(string n, ushort a)
        {
            name = n;
            age = a;
        }
        public void ShowData()
        {
            Console.WriteLine($"El alumno {name} tiene {age} años.");
        }
        public void LegalAge()
        {
            if(age >= 18 )
            {
                Console.WriteLine($"El alumno {name} es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"El alumno {name} no es mayor de edad.");
            }
        }
    }
}