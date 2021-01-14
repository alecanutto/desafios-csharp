using System;

namespace Desafios_CSharp.Solução_de_problemas_com_.NET
{
    public class QuantaMadioca
    {
        public static void Resolucao()
        {
            int chico = 300 * int.Parse(Console.ReadLine());
            int bento = 1500 * int.Parse(Console.ReadLine());
            int bernardo = 600 * int.Parse(Console.ReadLine());
            int marina = 1000 * int.Parse(Console.ReadLine());
            int iara = 150 * int.Parse(Console.ReadLine());
            int marlene = 225;
            int total = chico + bento + bernardo + marina + iara + marlene;
            Console.WriteLine(total);
        }
    }
}