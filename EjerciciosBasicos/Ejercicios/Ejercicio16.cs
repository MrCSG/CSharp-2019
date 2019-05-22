/* 16. Write a C# program to create a new string from a given string where the first and last characters will change their positions. 
Test Data:
	ivanfranco
	Python
	Sample Output:
	ovanfranci
	nythoP */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio16
    {
        public void SwapFirstChar()
        {
            string text1, text2, swapText1 = "", swapText2 = "", aux;
            Console.WriteLine("Ingrese 2 textos:");
            text1 = Console.ReadLine();
            text2 = Console.ReadLine();
            aux = text1[0].ToString();
            for (int i = 1; i < text1.Length; i++)
            {
                swapText1 += text1[i].ToString();
            }
            swapText1 += aux;
            aux = text2[0].ToString();
            for (int i = 1; i < text2.Length; i++)
            {
                swapText2 += text2[i].ToString();
            }
            swapText2 += aux;

            Console.WriteLine("Primera letra de los textos movidas al finál:\n{0}\n{1}", swapText1, swapText2);
        }
    }
}