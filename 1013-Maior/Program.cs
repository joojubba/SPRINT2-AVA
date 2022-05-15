using static System.Console;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] maior = ReadLine().Split();
        int A = Convert.ToInt32(maior[0]);
        int B = Convert.ToInt32(maior[1]);
        int C = Convert.ToInt32(maior[2]);

        int maiorAB = (A + B + Math.Abs(A - B)) / 2;
        int oMaior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

        WriteLine(oMaior + " eh o maior");

        ReadKey();
    }
}
