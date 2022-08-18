using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Operadores Logicos----------");
            bool c1 = 2 > 3 || 4 != 5;
            bool c3 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c3);

            Console.WriteLine("----------Procedencia----------");
            bool c4 = 10 < 5;
            bool c5 = c1 || c3 && c4;

            Console.WriteLine(c5);
        }
    }
}
