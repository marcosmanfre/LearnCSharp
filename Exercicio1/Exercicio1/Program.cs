﻿using System;
using System.Globalization;

public class Exercicio1
{
    public Exercicio1()
    {

    }
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

        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
        Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
        Console.WriteLine($"Registro: {idade}, código {codigo} e gênero: {genero}");

        Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");

        Console.WriteLine("Separador decimal invariant culture " + medida.ToString("F3", CultureInfo.InvariantCulture));


        int a  = 10;
        int b = ++a;
        Console.WriteLine(a);
        Console.WriteLine(b);

        int teste = 3 + 4 * 2;
        Console.WriteLine(teste);






    }

}