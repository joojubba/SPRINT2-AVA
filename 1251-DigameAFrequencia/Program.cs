using static System.Console;
using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        string entrada = ReadLine();
        entrada = ReadLine();
        foreach (var valor in entrada)
        {
            WriteLine((int)valor);
        }
    }

}
