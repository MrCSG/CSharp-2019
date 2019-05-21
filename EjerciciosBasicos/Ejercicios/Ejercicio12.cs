/* 12. Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
Test Data:
	Enter a digit: 25 
	Expected Output:
	25 25 25 25 
	25252525 
	25 25 25 25 
	25252525 */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio12
    {
        public void WriteTest()
        {
            int number;
            Console.Write("Ingrese un número:");
            number = Int32.Parse(Console.ReadLine());
            
            for(int i=0; i<2 ; i++)
            {
                for(int j=0; j<4 ; j++)
                {
                    Console.Write("{0} ",number);  
                }
                Console.WriteLine();
                for(int j=0; j<4 ; j++)
                {
                    Console.Write("{0}",number);  
                }
                Console.WriteLine();
            }
        }
    }
}