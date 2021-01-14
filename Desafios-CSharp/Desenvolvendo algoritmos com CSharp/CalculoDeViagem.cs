using System;

namespace Desafios_CSharp.Desenvolvendo_algoritmos_com_CSharp
{
    public class CalculoDeViagem
    {
        public static void Resolucao()
        {
            string[] valores = Console.ReadLine().Split();
            int tempo = int.Parse(valores[0]);
            int velocidade = int.Parse(valores[1]);
            int distancia = velocidade * tempo;
            double litros = distancia / (double)12;
            Console.WriteLine(litros.ToString("N3"));
        }
    }
}
