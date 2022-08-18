using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Aula I-----");
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] vetor = Console.ReadLine().Split(' ');
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.Write(a + " ");
            Console.Write(b + " ");
            Console.Write(c);

            Console.WriteLine("-----Aula II-----");
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vetor2 = Console.ReadLine().Split(' ');

            string nome = vetor2[0];
            char sexo = char.Parse(vetor2[1]);
            int idade = int.Parse(vetor2[2]);
            double altura = double.Parse(vetor2[3], CultureInfo.InvariantCulture);

            Console.WriteLine(n1 + "\n" + ch + "\n" + n2.ToString(CultureInfo.InvariantCulture) + "\n" + nome + " " + sexo + " " + idade + " " + altura.ToString(CultureInfo.InvariantCulture));
        }
    }
}
