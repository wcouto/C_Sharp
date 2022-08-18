using System;
using System.Globalization;

namespace ExerciciosPropostos_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o exercicio que deseja testar!");
            Console.WriteLine("|-----MENU DE EXERCICIOS-----|");
            Console.WriteLine("|--------EXERCICIO 1---------|");
            Console.WriteLine("|--------EXERCICIO 2---------|");
            Console.WriteLine("|--------EXERCICIO 3---------|");
            Console.WriteLine("|--------EXERCICIO 4---------|");
            Console.WriteLine("|--------EXERCICIO 5---------|");
            Console.WriteLine("|--------EXERCICIO 6---------|");
            Console.WriteLine("|--------EXERCICIO 7---------|");
            Console.WriteLine("|----------------------------|");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Ex1();
            } else if (opcao == 2)
            {
                Ex2();
            } else if (opcao == 3)
            {
                Ex3();
            } else if (opcao == 4)
            {
                Ex4();
            } else if (opcao == 5)
            {
                Ex5();
            } else if (opcao == 6)
            {
                Ex6();
            } else
            {
                Ex7();
            }

            static void Ex1()
            {
                Console.Write("Informe um numero entre 1 e 1000: ");
                int valor = int.Parse(Console.ReadLine());

                for (int i = 1; i <= valor; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void Ex2()
            {
                Console.Write("Quantos numeros voce vai digitar? ");
                int range = int.Parse(Console.ReadLine());
                int dentro = 0;
                int fora = 0;
                int valor;

                for (int i = 1; i <= range; i++)
                {
                    valor = int.Parse(Console.ReadLine());
                    if (valor >= 10 && valor <= 20)
                    {
                        dentro += 1;
                    } else
                    {
                        fora += 1;
                    }
                }
                Console.WriteLine("|-----|");
                Console.WriteLine("|{0} in |", dentro);
                Console.WriteLine("|{0} out|", fora);
                Console.WriteLine("|-----|");
            }

            static void Ex3()
            {
                Console.WriteLine("Indique a quantidade de casos de teste: ");
                int range = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double media;

                for (int i = 1; i <= range; i++)
                {
                    string[] numbers = Console.ReadLine().Split();
                    double n1 = double.Parse(numbers[0], CultureInfo.InvariantCulture);
                    double n2 = double.Parse(numbers[1], CultureInfo.InvariantCulture);
                    double n3 = double.Parse(numbers[2], CultureInfo.InvariantCulture);

                    media = ((2.0 * n1) + (3.0 * n2) + (5.0 * n3)) / (2 + 3 + 5);

                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            static void Ex4()
            {
                Console.WriteLine("Entre com a quatidade de pares: ");
                int range = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com os pares: ");

                double divisao;

                for (int i = 1; i <= range; i ++)
                {
                    string[] par = Console.ReadLine().Split();
                    int n1 = int.Parse(par[0]);
                    int n2 = int.Parse(par[1]);

                    if (n2 == 0)
                    {
                        Console.WriteLine("Divisao impossivel!");
                    }
                    else
                    {
                        divisao = (double)n1 / n2;
                        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
            }

            static void Ex5()
            {
                Console.WriteLine("Deseja calcular o fatorial de que numero? ");
                int numero = int.Parse(Console.ReadLine());
                int fatorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    fatorial = fatorial * i;
                }

                if (numero == 0 || numero == 1)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine(fatorial);
                }

            }

            static void Ex6()
            {
                Console.WriteLine("Entre com um numero para calcular seus divisores: ");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void Ex7()
            {
                Console.WriteLine("Entre com o numero para calular quadrado e cubo: ");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numero; i++)
                {
                    Console.WriteLine("{0} {1} {2}", i, Math.Pow(i, 2), Math.Pow(i, 3));
                }
            }
        }
    }
}
