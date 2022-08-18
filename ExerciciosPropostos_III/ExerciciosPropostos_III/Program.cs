using System;

namespace ExerciciosPropostos_III
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("|-----------MENU DE EXERCICIOS-----------|");
            Console.WriteLine("|   Digite 1 para testar o exercicio 1   |");
            Console.WriteLine("|   Digite 2 para testar o exercicio 2   |");
            Console.WriteLine("|   Digite 3 para testar o exercicio 3   |");
            Console.WriteLine("|----------------------------------------|");

            int opcao = int.Parse(Console.ReadLine());

            while ( opcao != 1 && opcao != 2 && opcao != 3)
            {
                Console.WriteLine("|-----------MENU DE EXERCICIOS-----------|");
                Console.WriteLine("|   Digite 1 para testar o exercicio 1   |");
                Console.WriteLine("|   Digite 2 para testar o exercicio 2   |");
                Console.WriteLine("|   Digite 3 para testar o exercicio 3   |");
                Console.WriteLine("|----------------------------------------|");

                opcao = int.Parse(Console.ReadLine());
            }

            if (opcao == 1)
            {
                Ex1();
            }
            else if (opcao == 2)
            {
                Ex2();
            }
            else if (opcao == 3)
            {
                Ex3();
            }
            else
            {
                Console.WriteLine("Opcao invalida");
            }

            static void Ex1()
            {
                int senha = 2002;

                Console.Write("Digite o numero secreto de quatro digitos: ");
                int input = int.Parse(Console.ReadLine());

                while (input != senha)
                {
                    Console.Write("Senha invalida! Digite novamente: ");
                    input = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Acesso permitido!");
            }

            static void Ex2()
            {
                Console.Write("Digite o par de coordenadas: ");
                string[] input = Console.ReadLine().Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);

                while (x != 0 && y != 0)
                {   
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Primeiro");
                    }
                    else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("Quarto");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("Terceiro");
                    }
                    else
                    {
                        Console.WriteLine("Segundo");
                    }

                    Console.Write("Digite o par de coordenadas: ");
                    input = Console.ReadLine().Split();
                    x = int.Parse(input[0]);
                    y = int.Parse(input[1]);
                }
            }

            static void Ex3()
            {
                int alcool = 0;
                int gas = 0;
                int diesel = 0;
                bool showMenu;

                int opcao = Input(showMenu = true);

                while (opcao != 4)
                {
                    if (opcao > 4 || opcao < 1)
                    {
                        Console.WriteLine("Opção invalida! Digite novamente!");
                        opcao = Input(showMenu = true);

                        if (opcao == 4)
                        {
                            Print(alcool, gas, diesel);
                            break;
                        }
                    }
                    if (opcao == 1)
                    {
                        alcool += 1;
                    }
                    else if (opcao == 2)
                    {
                        gas += 1;
                    }
                    else if (opcao == 3)
                    {
                        diesel += 1;
                    }

                    opcao = Input(showMenu = false);
                }

                Print(alcool, gas, diesel);

                static int Input(bool showMenu)
                {   
                    if (showMenu)
                    {
                        Console.WriteLine("|---MENU DE PRODUTOS---|");
                        Console.WriteLine("|      Alcool - 1      |");
                        Console.WriteLine("|     Gasolina - 2     |");
                        Console.WriteLine("|      Diesel - 3      |");
                        Console.WriteLine("|       Fim - 4        |");
                        Console.WriteLine("|----------------------|");
                    }

                    int opcao = int.Parse(Console.ReadLine());

                    return opcao;
                }

                static void Print(int alcool, int gas, int diesel)
                {
                    Console.WriteLine("|-----MUITO OBRIGADO-----|");
                    Console.WriteLine("|      Alcool - {0}      |", alcool);
                    Console.WriteLine("|     Gasolina - {0}     |", gas);
                    Console.WriteLine("|      Diesel - {0}      |", diesel);
                    Console.WriteLine("|------------------------|");
                }
            }
        }
    }
}
