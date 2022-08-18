using System;

namespace TiposBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("--------------------Overflow--------------------");
            Console.WriteLine("\n");
            //Overflow: Quando o calculo extrapola o limite da variavel
            byte tipoSbyte = 255;
            tipoSbyte++;
            Console.WriteLine(tipoSbyte);

            Console.WriteLine("\n");
            Console.WriteLine("--------------Tipos de Variaveis--------------");
            Console.WriteLine("\n");

            int tipoInt = 1000;
            int tipoLimiteInt = 2147483647;
            long tipoLong = 2147483648L; //L: Expecificar que estamos lidando com Long
            bool tipoBoolean = false;
            char tipoChar = 'F'; //Char precisa ser aspas simples
            float tipoFloat = 4.5f; //F: Expecificar que estamos lidando com float, se nao ele interpreta como double
            string tipoString = "Willian"; //String precisa ser aspas duplas
            object tipoObject = "Gabriel Couto"; //Aceita qualquer coisa
            object tipoObject2 = 4.6; //Aceita qualquer coisa

            Console.WriteLine(tipoInt);
            Console.WriteLine(tipoLimiteInt);
            Console.WriteLine(tipoLong);
            Console.WriteLine(tipoBoolean);
            Console.WriteLine(tipoChar);
            Console.WriteLine(tipoFloat);
            Console.WriteLine(tipoString);
            Console.WriteLine(tipoObject);
            Console.WriteLine(tipoObject2);

            Console.WriteLine("\n");
            Console.WriteLine("--------------Funcoes para valores Minimos e Maximos--------------");
            Console.WriteLine("\n");

            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);


        }
    }
}
