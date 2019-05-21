/* 13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
Test Data:
	Enter a number: 5 
	Expected Output:
	555 
	5 5
	5 5 
	5 5 
	555 */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio13
    {
        public void Rectangle35()
        {
            int number;
            Console.Write("Ingrese un número:");
            number = Int32.Parse(Console.ReadLine());
            for (int i=0 ; i<5 ; i++)
            {
                for(int j=0 ; j<3 ; j++)
                {
                    if(j==0 || i==0 || j==2 || i==4)
                    {
                        Console.Write("{0} ",number);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}