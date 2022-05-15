using static System.Console;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int tempoEmSegundos = Convert.ToInt32(ReadLine());

        int horaSegundo = 60 * 60;
        int totalHora = tempoEmSegundos / horaSegundo;
        tempoEmSegundos = tempoEmSegundos % horaSegundo;

        int totalmin = tempoEmSegundos / 60;
        tempoEmSegundos = tempoEmSegundos % 60;

        int totalseg = tempoEmSegundos;

        WriteLine(totalHora + ":" + totalmin + ":" + totalseg);

        ReadKey();
    }
}