using static System.Console;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        string[] peca1 = ReadLine().Split();
        int codigo1 = Convert.ToInt32(peca1[0]);
        int qtd1 = Convert.ToInt32(peca1[1]);
        double valor1 = Convert.ToDouble(peca1[2], CultureInfo.InvariantCulture);

        string[] peca2 = ReadLine().Split();
        int codigo2 = Convert.ToInt32(peca2[0]);
        int qtd2 = Convert.ToInt32(peca2[1]);
        double valor2 = Convert.ToDouble(peca2[2], CultureInfo.InvariantCulture);

        double totalUnitario1 = qtd1 * valor1;
        double totalUnitario2 = qtd2 * valor2;
        double valorTotal = totalUnitario1 + totalUnitario2;
        valorTotal = Math.Round(valorTotal, 2);

        WriteLine("VALOR A PAGAR: R$ {0:0.00}", valorTotal);

        ReadKey();
    }
}
