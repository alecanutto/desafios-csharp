using System;

namespace Desafios_CSharp.Resolvendo_algoritmos
{
    public class CardapioAereo
    {
        public static void Resolucao()
        {
            string[] reifecoes = Console.ReadLine().Split();
            string[] pedidos = Console.ReadLine().Split();
            double quantidade = 0;

            for (int i = 0; i < reifecoes.Length; i++)
            {
                if (int.Parse(pedidos[i]) > int.Parse(reifecoes[i]))
                {
                    quantidade += int.Parse(pedidos[i]) - int.Parse(reifecoes[i]);
                }
            }

            Console.WriteLine(quantidade);
        }
    }
}
