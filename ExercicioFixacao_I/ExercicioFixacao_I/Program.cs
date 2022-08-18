﻿using System;
using System.Globalization;

namespace ExercicioFixacao_I
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:\n{produto1}, cujo preço é $ {preco1:F2}\nMesa de escritório, cujo preço é $ {preco2:F2}\n");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}\nArredondando (três casa decimais): {medida:F3}");
            Console.WriteLine("Separados decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
