using System;
using System.Globalization;

namespace EntradaSaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Diferenca Write e WriteLine-----------");
            Console.Write("Bom dia!"); //Nao quebra linha no final
            Console.WriteLine("Boa tarde!"); //Quebra linha no final
            Console.WriteLine("Boa noite!");

            Console.WriteLine("-------Arredondamento de casas decimais-------");
   
            double saldo = 10.354985;

            Console.WriteLine(saldo.ToString("F1")); //variavel.ToString("Fx") - o x especifica o numero de
            //casas decimais
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); //Troca virgula por ponto

            Console.WriteLine("-----------Placeholders-----------");

            int idade = 28;
            double saldo2 = 19500.5985;
            string nome = "Willian";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais!", nome, idade, saldo2);

            Console.WriteLine("-----------Interpolacao-----------");

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo2:F2} reais!");

            Console.WriteLine("-----------Concatenacao-----------");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo2.ToString("F2") + " reais!");
        }
    }
}
