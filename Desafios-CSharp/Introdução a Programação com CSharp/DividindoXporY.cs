using System;

namespace Desafios_CSharp.Introdução_a_Programação_com_CSharp
{
    public class DividindoXporY
    {
        public static void Resolucao()
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = X / Y;
                    Console.WriteLine(divisao.ToString("N1"));
                }
            }
        }
    }
}
