/*4. Write a C# Sharp program to print the result of the specified operations.
Test data:
   * -1 + 4 * 6 -> Expected Output: 23
   * ( 35+ 5 ) % 7 -> Expected Output: 5
   * 14 + -4 * 6 / 11 -> Expected Output: 12
   * 2 + 15 / 6 * 1 - 7 % 2 -> Expected Output: 3*/
using System;

namespace EjerciciosBasicos
{
    class Ejercicio4
    {
        public void Operations()
        {
            string choosedOption;
            int u,v,w,x,y,z;
            Console.WriteLine("Elija la operación a realizar:\n1) x + y * z = ?\n2) ( x + y ) % z = ?\n3) w + x * y / z = ?\n4) u + v / w * x - y % z = ?");
            choosedOption = Console.ReadLine();
            Console.Clear();
            switch (choosedOption)
            {
                case "1":
                    Console.WriteLine("1) x + y * z = ?");
                    Console.Write("x = ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.Write("y = ");
                    y = Int32.Parse(Console.ReadLine());
                    Console.Write("z = ");
                    z = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"{x} + {y} * {z} = {x+y*z}");
                    break;
                case "2":
                    Console.WriteLine("2) ( x + y ) % z = ?");
                    Console.Write("x = ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.Write("y = ");
                    y = Int32.Parse(Console.ReadLine());
                    Console.Write("z = ");
                    z = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"( {x} + {y} ) % {z} = {(x+y)%z}");
                    break;
                case "3":
                    Console.WriteLine("3) w + x * y / z = ?");
                    Console.Write("w = ");
                    w = Int32.Parse(Console.ReadLine());
                    Console.Write("x = ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.Write("y = ");
                    y = Int32.Parse(Console.ReadLine());
                    Console.Write("z = ");
                    z = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"{w} + {x} * {y} / {z} = {w+x*y/z}");
                    break;
                case "4":
                    Console.WriteLine("4) u + v / w * x - y % z = ?");
                    Console.Write("u = ");
                    u = Int32.Parse(Console.ReadLine());
                    Console.Write("v = ");
                    v = Int32.Parse(Console.ReadLine());
                    Console.Write("w = ");
                    w = Int32.Parse(Console.ReadLine());
                    Console.Write("x = ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.Write("y = ");
                    y = Int32.Parse(Console.ReadLine());
                    Console.Write("z = ");
                    z = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"{u} + {v} / {w} * {x} - {y} % {z} = {u+v/w*x-y%z}");
                    break;
                default:
                    break;
            }
        }
    }
}