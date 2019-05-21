/* 15. Write a C# program remove specified a character from a non-empty string using index of a character.
Test Data:
	ivanfranco
	Sample Output:
	vanfranco
	vanfranc
	vanranc */

using System;
namespace EjerciciosBasicos
{
    public class Ejercicio15
    {
        public void RemoveChars()
        {
            string text, print="";
            Console.Write("Ingrese un texto:");
            text = Console.ReadLine();
            if (text!="")
            {
                for(int i=1 ; i<text.Length ; i++)
                {
                    print += text[i];
                }
                text = print;
                print = "";
                Console.WriteLine(text);
                for(int i=0 ; i<text.Length-1 ; i++)
                {
                    print += text[i];
                }
                text = print;
                print = "";
                Console.WriteLine(text);
                for(int i=0 ; i<text.Length ; i++)
                {
                    if(i!=3)
                    {
                        print += text[i];
                    }
                }
                text = print;
                print = "";
                Console.WriteLine(text);
            }
        }
    }
}