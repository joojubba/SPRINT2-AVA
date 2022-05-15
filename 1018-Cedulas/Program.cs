using static System.Console;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int numeroDeNotas = Convert.ToInt32(ReadLine());

        WriteLine(numeroDeNotas);
        WriteLine(numeroDeNotas / 100 + " nota(s) de R$ 100,00");
        numeroDeNotas = numeroDeNotas % 100;
        WriteLine(numeroDeNotas / 50 + " nota(s) de R$ 50,00");
        numeroDeNotas = numeroDeNotas % 50;
        WriteLine(numeroDeNotas / 20 + " nota(s) de R$ 20,00");
        numeroDeNotas = numeroDeNotas % 20;
        WriteLine(numeroDeNotas / 10 + " nota(s) de R$ 10,00");
        numeroDeNotas = numeroDeNotas % 10;
        WriteLine(numeroDeNotas / 5 + " nota(s) de R$ 5,00");
        numeroDeNotas = numeroDeNotas % 5;
        WriteLine(numeroDeNotas / 2 + " nota(s) de R$ 2,00");
        numeroDeNotas = numeroDeNotas % 2;
        WriteLine(numeroDeNotas / 1 + " nota(s) de R$ 1,00");

        ReadKey();
    }
}

