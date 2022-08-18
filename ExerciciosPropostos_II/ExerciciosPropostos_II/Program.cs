using System;
using System.Globalization;

namespace ExerciciosPropostos_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Exercicio I------------");

            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            Console.WriteLine("----------Exercicio II-----------");

            int numero1 = int.Parse(Console.ReadLine());

            if (numero1 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

            Console.WriteLine("----------Exercicio III----------");

            string[] numeros = Console.ReadLine().Split();
            int mult1 = int.Parse(numeros[0]);
            int mult2 = int.Parse(numeros[1]);

            if (mult1 > mult2)
            {
                if (mult1 % mult2 == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }
            else
            {
                if (mult2 % mult1 == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }

            Console.WriteLine("----------Exercicio IV-----------");

            string[] horas = Console.ReadLine().Split();
            int inicio = int.Parse(horas[0]);
            int final = int.Parse(horas[1]);

            if (inicio == final)
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS");
            }
            else if (inicio > final)
            {
                int duracao = (24 - inicio) + final;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORAS");
            }
            else
            {
                int duracao = final - inicio;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }

            Console.WriteLine("----------Exercicio V------------");

            string[] info = Console.ReadLine().Split();
            int produto = int.Parse(info[0]);
            int qtd = int.Parse(info[1]);
            double total;

            if (produto == 1)
            {
                total = (double)qtd * 4;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (produto == 2)
            {
                total = qtd * 4.50;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (produto == 3)
            {
                total = (double)qtd * 5;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (produto == 4)
            {
                total = (double)qtd * 2;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (produto == 5)
            {
                total = qtd * 1.5;
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Produto nao cadastrado.");
            }

            Console.WriteLine("----------Exercicio VI-----------");

            double numero6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero6 >= 0 && numero6 <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero6 > 25 && numero6 <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero6 > 50 && numero6 <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (numero6 > 75 && numero6 <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }


            Console.WriteLine("----------Exercicio VII----------");

            string[] pontos = Console.ReadLine().Split();
            double ponto1 = double.Parse(pontos[0], CultureInfo.InvariantCulture);
            double ponto2 = double.Parse(pontos[1], CultureInfo.InvariantCulture);

            if (ponto1 == 0 && ponto2 == 0)
            {
                Console.WriteLine("Origem.");
            }
            else if (ponto1 > 0 && ponto2 > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (ponto1 < 0 && ponto2 > 0)
            {
                Console.WriteLine("Q3");
            }
            else if (ponto1 > 0 && ponto2 < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (ponto1 < 0 && ponto2 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (ponto1 == 0 && ponto2 != 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (ponto1 != 0 && ponto2 == 0)
            {
                Console.WriteLine("Eixo Y");
            }

            Console.WriteLine("----------Exercicio VIII---------");

            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if ( renda <= 2000 )
            {
                Console.WriteLine("Isento");
            }
            else if ( renda <= 3000 )
            {
                imposto = (renda - 2000) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (renda <= 4500)
            {
                imposto = (1000 * 0.08) + ((renda - 3000) * 0.18);
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                imposto = (1000 * 0.08) + (1500 * 0.18) + ((renda - 4500) * 0.28);
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
