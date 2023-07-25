using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            byte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria";
            object obj1 = "Alex";
            int teste1 = int.MinValue;
            int idade = 31;
            double saldo = 10.35784;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(teste1);


            Console.WriteLine("{0} tem {1} anos e tem saldo igual {2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual {saldo:F2} reais");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais" );
        }   
    }
}