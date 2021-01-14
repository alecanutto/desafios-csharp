using System;

namespace Desafios_CSharp.Resolvendo_algoritmos
{
    public class IdadeEmDias
    {
        public static void Resolucao()
        {
            int idadeDias = int.Parse(Console.ReadLine());
            int anos = idadeDias / 365;
            idadeDias -= anos * 365;
            int meses = idadeDias / 30;
            idadeDias -= meses * 30;
            int dias = idadeDias;
            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
        }
    }
}
