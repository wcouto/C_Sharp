using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Operadores de Atribuicao---");

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "abc";
            Console.WriteLine(s);

            s += "def";
            Console.WriteLine(s);

            Console.WriteLine("---Operadores aritmeticos de atribuicao---");

            int b = 10;
            b++;
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);

            int c = 9;
            int d = c++; // ++ depois da variavel incrementa depois da atribuicao
            int e = ++c; // ++ antes da variavel incrementa antes da atribuicao
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
            Console.WriteLine("e: " + e);
        }
    }
}
