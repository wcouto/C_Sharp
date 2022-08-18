using System;
using System.Globalization;

namespace PrimeirosExerciciosOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|----MENU EXERCICIOS----|");
            Console.WriteLine("|------EXERCICIO 1------|");
            Console.WriteLine("|------EXERCICIO 2------|");
            Console.WriteLine("|-----------------------|");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Ex1();
            }
            else if(opcao == 2){
                Ex2();
            }

            static void Ex1()
            {
                Pessoa pessoa1, pessoa2;

                pessoa1 = new Pessoa();
                pessoa2 = new Pessoa();

                Console.WriteLine("Dados da primeira pessoa:");
                Console.Write("Nome: ");
                pessoa1.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                pessoa1.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados da segunda pessoa:");
                Console.Write("Nome: ");
                pessoa2.Nome = Console.ReadLine();
                Console.Write("Idade: ");
                pessoa2.Idade = int.Parse(Console.ReadLine());

                if (pessoa1.Idade > pessoa2.Idade)
                {
                    Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
                }
                else if (pessoa1.Idade < pessoa2.Idade)
                {
                    Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
                }
                else
                {
                    Console.WriteLine("As duas pessoas possuem idades iguais!");
                }
            }

            static void Ex2()
            {
                Funcionario funcionario1, funcionario2;

                funcionario1 = new Funcionario();
                funcionario2 = new Funcionario();

                Console.WriteLine("Dados do primeiro funcionario: ");
                Console.Write("Nome: ");
                funcionario1.Nome = Console.ReadLine();
                Console.Write("Salario: ");
                funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Dados do segundo funcionario: ");
                Console.Write("Nome: ");
                funcionario2.Nome = Console.ReadLine();
                Console.Write("Salario: ");
                funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2.0;

                Console.WriteLine("Salario medio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
