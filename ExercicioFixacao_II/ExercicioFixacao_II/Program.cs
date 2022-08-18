using System;
using System.Globalization;

namespace ExercicioFixacao_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Entrada de dados----------");
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] infos = Console.ReadLine().Split();

            string sobreNome = infos[0];
            int idade = int.Parse(infos[1]);
            double altura = double.Parse(infos[2], CultureInfo.InvariantCulture);

            Console.WriteLine("----------Saida de dados----------");
            Console.WriteLine(nomeCompleto + "\n" + qtdQuartos + "\n" + precoProduto.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(sobreNome + "\n" + idade + "\n" + altura.ToString(CultureInfo.InvariantCulture));

        }
    }
}
