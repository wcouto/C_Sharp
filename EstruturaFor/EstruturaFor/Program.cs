using System;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores inteiros voce vai digitar?");
            int range = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int x = 1; x <= range; x++)
            {
                Console.Write("Valor #{0}: ", x);
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma = {0}", soma);
        }
    }
}
