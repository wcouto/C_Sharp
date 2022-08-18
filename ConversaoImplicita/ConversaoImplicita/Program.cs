using System;

namespace ConversaoImplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Conversao Implicita---");
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            Console.WriteLine("---Conversao Explicita (Casting)---");
            double a = 5.1;
            float b = (float)a; // Expecificacao é necessaria pois nesse caso double tem maior capacidade que float, podendo haver perda de dado
            Console.WriteLine(b);

            Console.WriteLine("---Perda de informacao devido conversao entre tipos incoerentes---");
            double z = 5.1;
            int w = (int)z;
            Console.WriteLine(w);

            int m = 5;
            int n = 2;

            // double res = m / n; Acontece uma divisao de inteiros, mesmo com o res sendo double ele trunca as casas decimais
            double res = (double) m / n;

            Console.WriteLine(res);
        }
    }
}
