using System;
using System.Collections.Generic;

namespace Desafios_CSharp.Desenvolvendo_algoritmos_com_CSharp
{
  public class AlbumDaCopa
    {
        public static void Resolucao()
        {
            int numeroDeFigurinhas = int.Parse(Console.ReadLine());
            int numeroDeFigurinhasCompradas = int.Parse(Console.ReadLine());

            List<int> albumDeFigurinha = new List<int>();

            for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
            {
                int figurinha = int.Parse(Console.ReadLine());
                if (!albumDeFigurinha.Contains(figurinha))
                {
                    albumDeFigurinha.Add(figurinha);
                }
            }

            int totalDeFigurinhas = numeroDeFigurinhas - albumDeFigurinha.Count;
            Console.WriteLine(totalDeFigurinhas);
        }
    }
}
