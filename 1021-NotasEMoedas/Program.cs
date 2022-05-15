using static System.Console;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        decimal valorFlutua = Convert.ToDecimal(ReadLine(), CultureInfo.InvariantCulture);
        int valorNotas = 0;

        WriteLine("NOTAS:");

        valorNotas = (int)(valorFlutua / 100);
        WriteLine(valorNotas + " nota(s) de R$ 100.00");
        valorFlutua = valorFlutua % 100.0m;

        valorNotas = (int)(valorFlutua / 50);
        WriteLine(valorNotas + " nota(s) de R$ 50.00");
        valorFlutua = valorFlutua % 50.0m;

        valorNotas = (int)(valorFlutua / 20);
        WriteLine(valorNotas + " nota(s) de R$ 20.00");
        valorFlutua = valorFlutua % 20.0m;

        valorNotas = (int)(valorFlutua / 10);
        WriteLine(valorNotas + " nota(s) de R$ 10.00");
        valorFlutua = valorFlutua % 10.0m;

        valorNotas = (int)(valorFlutua / 5);
        WriteLine(valorNotas + " nota(s) de R$ 5.00");
        valorFlutua = valorFlutua % 5.0m;

        valorNotas = (int)(valorFlutua / 2);
        WriteLine(valorNotas + " nota(s) de R$ 2.00");
        valorFlutua = valorFlutua % 2.0m;

        WriteLine("MOEDAS:");

        valorNotas = (int)(valorFlutua / 1);
        WriteLine(valorNotas + " moeda(s) de R$ 1.00");
        valorFlutua = valorFlutua % 1.0m;

        valorNotas = (int)(valorFlutua / 0.50m);
        WriteLine(valorNotas + " moeda(s) de R$ 0.50");
        valorFlutua = valorFlutua % 0.50m;

        valorNotas = (int)(valorFlutua / 0.25m);
        WriteLine(valorNotas + " moeda(s) de R$ 0.25");
        valorFlutua = valorFlutua % 0.25m;

        valorNotas = (int)(valorFlutua / 0.10m);
        WriteLine(valorNotas + " moeda(s) de R$ 0.10");
        valorFlutua = valorFlutua % 0.10m;

        valorNotas = (int)(valorFlutua / 0.05m);
        WriteLine(valorNotas + " moeda(s) de R$ 0.05");
        valorFlutua = valorFlutua % 0.05m;

        valorNotas = (int)(valorFlutua / 0.01m);
        WriteLine(valorNotas + " moeda(s) de R$ 0.01");

        ReadKey();
    }
}

