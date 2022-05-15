using static System.Console;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string nomeDoVendedor = ReadLine();

        double salario = Convert.ToDouble(ReadLine(), CultureInfo.InvariantCulture);

        double vendaMensal = Convert.ToDouble(ReadLine(), CultureInfo.InvariantCulture);

        double comissao = 15.00 / 100.00;
        double salarioMensal = salario + (vendaMensal * comissao);
        salarioMensal = Math.Round(salarioMensal, 2);

        WriteLine("TOTAL = R$ {0:0.00}", salarioMensal);

        ReadKey();
    }
}
