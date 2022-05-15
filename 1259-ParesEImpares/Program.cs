using static System.Console;
using System;
using System.Globalization;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int entrada = Convert.ToInt32(ReadLine());
        int[] array = new int[entrada];
        for (int i = 0; i < array.Length; i++) array[i] = Convert.ToInt32(ReadLine());
        foreach (var valor in array.Where(x => x % 2 == 0).OrderBy(x => x)) WriteLine(valor);
        foreach (var valor in array.Where(x => x % 2 != 0).OrderByDescending(x => x)) WriteLine(valor);
    }
}

