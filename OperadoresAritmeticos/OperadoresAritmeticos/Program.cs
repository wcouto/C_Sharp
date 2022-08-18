﻿using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Operadores Aritimeticos---");
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8; // Colocar o '.0' para indicar expressao double ou usar casting (double)


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("---Formula de bascara---");

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = (Math.Pow(b, 2)) - (4.0 * a * c);

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);


        }
    }
}
