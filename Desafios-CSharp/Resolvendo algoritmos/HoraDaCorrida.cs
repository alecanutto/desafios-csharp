using System;
using System.Collections.Generic;

namespace Desafios_CSharp.Resolvendo_algoritmos
{
  public class HoraDaCorrida
    {
        public static void Resolucao()
        {
            string[] line = Console.ReadLine().Split();
            int numeroVoltas = int.Parse(line[0]);
            int numeroPlacas = int.Parse(line[1]);

            double quantidade = numeroVoltas * numeroPlacas;
            List<int> placas = new List<int>();
            for (int i = 10; i < 100; i+=10)
            {
                placas.Add(int.Parse(Math.Ceiling((quantidade * i) / 100).ToString()));
            }
            Console.WriteLine(string.Join(" ", placas));
        }
    }
}
