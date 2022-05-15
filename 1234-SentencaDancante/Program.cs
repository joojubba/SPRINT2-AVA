using static System.Console;
using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string entrada = ReadLine();

        while (entrada != null)
        {
            bool isPar = true;
            var sb = new StringBuilder();

            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] == ' ')

                {

                    sb.Append(entrada[i]);
                    continue;

                }

                var setenca = isPar ? Char.ToUpper(entrada[i]) : Char.ToLower(entrada[i]);
                isPar = !isPar;

                sb.Append(setenca);
            }

            WriteLine(sb.ToString());
            entrada = ReadLine();
        }
    }

}
