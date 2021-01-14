using System;
using System.Text.RegularExpressions;

namespace Desafios_CSharp.Resolvendo_algoritmos
{
    public class RodizioDeCavalosECarruagens
    {
        public static void Resolucao()
        {
            int limit = int.Parse(Console.ReadLine());
    
            for (int i = 0; i < limit; i++)
            {
                if (i > 1000) return;
                string placa = Console.ReadLine();
                Regex rx = new Regex("^[A-Z]{3}-[0-9]{4}$");
                Match match = rx.Match(placa);
                if (!match.Success)
                {
                    Console.WriteLine("FALHA");
                } else
                {
                    switch (placa.Substring(placa.Length - 1))
                    {
                        case "1":
                        case "2":
                            Console.WriteLine("SEGUNDA");
                            break;
                        case "3":
                        case "4":
                            Console.WriteLine("TERCA");
                            break;
                        case "5":
                        case "6":
                            Console.WriteLine("QUARTA");
                            break;
                        case "7":
                        case "8":
                            Console.WriteLine("QUINTA");
                            break;
                        case "0":
                        case "9":
                            Console.WriteLine("SEXTA");
                            break;
                    }
                }
                
            }

        }
    }
}
