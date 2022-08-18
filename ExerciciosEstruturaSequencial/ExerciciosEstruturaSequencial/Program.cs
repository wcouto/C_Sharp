using System;
using System.Globalization;

namespace ExerciciosEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Exercicio I-----------");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine("SOMA = " + soma);

            Console.WriteLine("-----------Exercicio II-----------");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double areaCirculo = pi * Math.Pow(raio, 2);

            Console.WriteLine("A = " + areaCirculo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("-----------Exercicio III-----------");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + diferenca);

            Console.WriteLine("-----------Exercicio IV-----------");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            int valorHora = int.Parse(Console.ReadLine());
            double hrsTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = (double)valorHora * hrsTrabalhadas;

            Console.WriteLine("NUMBER = " + numeroFuncionario + "\n" + "SALARY = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-----------Exercicio V-----------");
            string[] infoPeca = Console.ReadLine().Split(' ');
            int codigoPeca = int.Parse(infoPeca[0]);
            int qtdPeca = int.Parse(infoPeca[1]);
            double precoPeca = double.Parse(infoPeca[2], CultureInfo.InvariantCulture);

            double valorPagar = (double)qtdPeca * precoPeca;

            infoPeca = Console.ReadLine().Split(' ');
            codigoPeca = int.Parse(infoPeca[0]);
            qtdPeca = int.Parse(infoPeca[1]);
            precoPeca = double.Parse(infoPeca[2], CultureInfo.InvariantCulture);

            valorPagar += (double)qtdPeca * precoPeca;

            Console.WriteLine("VALOR A PAGAR: " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-----------Exercicio VI-----------");
            string[] ABC = Console.ReadLine().Split(' ');
            double A2 = double.Parse(ABC[0], CultureInfo.InvariantCulture);
            double B2 = double.Parse(ABC[1], CultureInfo.InvariantCulture);
            double C2 = double.Parse(ABC[2], CultureInfo.InvariantCulture);

            double triangulo = (A2 * C2) / 2;
            double circulo = pi * Math.Pow(C2, 2);
            double trapezio = ((A2 + B2) * C2) / 2;
            double quadrado = Math.Pow(B2, 2);
            double retangulo = A2 * B2;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
