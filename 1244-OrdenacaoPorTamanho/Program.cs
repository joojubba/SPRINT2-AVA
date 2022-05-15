using static System.Console;
using System;
using System.Globalization;
using System.Text;
using System.Linq;


class Program
{
    static void Main(String[] args)
    {

        int entrada = Convert.ToInt32(ReadLine());
        string[] array = new string[entrada];

        for (int i = 0; i < array.Length; i++) array[i] = (ReadLine());
        foreach (var valor in array.OrderByDescending(x => x.Length)) WriteLine(valor);
    }
}


