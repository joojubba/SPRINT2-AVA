using static System.Console;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int idadeEmDias = Convert.ToInt32(ReadLine());

        int totalAnos = idadeEmDias / 365;
        idadeEmDias = idadeEmDias % 365;

        int totalMeses = idadeEmDias / 30;
        idadeEmDias = idadeEmDias % 30;

        int totalDias = idadeEmDias;

        WriteLine(totalAnos + " ano(s)");
        WriteLine(totalMeses + " mes(es)");
        WriteLine(totalDias + " dia(s)");

        ReadKey();
    }
}
