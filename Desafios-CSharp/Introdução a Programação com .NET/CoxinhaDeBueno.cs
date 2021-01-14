using System;

namespace Desafios_CSharp.Introdução_a_Programação_com_.NET
{
    public class CoxinhaDeBueno
    {
        public static void Resolucao()
        {
            string[] line = Console.ReadLine().Split(" ");
            double coxinhas = int.Parse(line[0]);
            double participantes = int.Parse(line[1]);
            double media = coxinhas / participantes;
            Console.WriteLine(media.ToString("N2"));
        }
    }
}
