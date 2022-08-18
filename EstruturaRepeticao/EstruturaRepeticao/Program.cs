using System;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Codicional Simples-----------");
            int x = 10;
            Console.WriteLine("Bom dia!");

            if (x < 5)
            {
                Console.WriteLine("Boa tarde!");
            }

            Console.WriteLine("Boa noite!");

            Console.WriteLine("-----------Condicional Composta-----------");
            Console.WriteLine("Entre com um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if ( numero % 2 == 0)
            {
                Console.WriteLine(numero + " é par!!!");
            }
            else
            {
                Console.WriteLine(numero + " é ímpar!!!");
            }

            Console.WriteLine("-----------Condicional Encadeamentos-----------");
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
