using System;
using System.Globalization;
public class Logica
{
    public Logica()
    {
    }
        static void Main(string[] args)
        {
            bool completo = false;
            char genero1 = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome1 = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;
            Console.WriteLine(completo);
            Console.WriteLine(genero1);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome1);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


        double a;
        float b;
        a = 5.1;
        b = (float)a;
        Console.WriteLine(b);


        char genero = 'F';
        int idade = 32;
        double saldo = 10.35784;
        String nome = "Maria";
        Console.Write("Bom dia!");
        Console.WriteLine("Boa tarde!");
        Console.WriteLine("Boa noite!");
        Console.WriteLine("---------------------------");
        Console.WriteLine(genero);
        Console.WriteLine(idade);
        Console.WriteLine(saldo);
        Console.WriteLine(nome);
        Console.WriteLine(saldo.ToString("F2"));
        Console.WriteLine(saldo.ToString("F4"));
        Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

        int n11 = 3 + 4 * 2;
        int n21 = (3 + 4) * 2;
        int n31 = 17 % 3;
        double n41 = 10.0 / 8.0;
        double a1 = 1.0, b1 = -3.0, c1 = -4.0;
        double delta = Math.Pow(b, 2.0) - 4.0 * a * c1;
        double x1 = (-b1 + Math.Sqrt(delta)) / (2.0 * a1);
        double x2 = (-b1 - Math.Sqrt(delta)) / (2.0 * a1);
        Console.WriteLine(n11);
        Console.WriteLine(n21);
        Console.WriteLine(n31);
        Console.WriteLine(n41);
        Console.WriteLine(delta);
        Console.WriteLine(x1);
        Console.WriteLine(x2);
    }
    }

