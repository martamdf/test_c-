using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<char, int>();
            char[] testchars = args[0].ToCharArray();
            int length = testchars.Length;
            foreach (char c in testchars)
            {
                if (!map.ContainsKey(c))
                {
                    map[c] = 0;
                }
                map[c] = map[c] + 1;
            }
            // Cabecera de la Tabla
            Console.WriteLine("----------------------");
            Console.WriteLine("| CHAR. | % REPETICIÓN");
            Console.WriteLine("----------------------");

            // Resultados
            foreach (var caracter in map)
            {
                double result = ((double)caracter.Value / length) * 100;
                Console.WriteLine("|   " + caracter.Key + "   |    " + Math.Round(result, 2) + "%");
            }
        }
    }
}

