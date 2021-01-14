using System;
using System.Text.RegularExpressions;

namespace Desafios_CSharp.Solução_de_problemas_com_.NET
{
    public class ValidadorDeSenhasComRequisitos
    {
        public static void Resolucao()
        {
            while (true)
            {
                string senha = Console.ReadLine();

                if (string.IsNullOrEmpty(senha)) break;

                Regex rx = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,32}$");
                Match match = rx.Match(senha);
                if (match.Success)
                {
                    Console.WriteLine("Senha valida.");
                }
                else
                {
                    Console.WriteLine("Senha invalida.");
                }
            }
        }
    }
}
