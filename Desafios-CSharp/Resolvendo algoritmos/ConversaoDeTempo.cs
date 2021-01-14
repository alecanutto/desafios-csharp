using System;

namespace Desafios_CSharp.Resolvendo_algoritmos
{
    public class ConversaoDeTempo
    {
        public static void Resolucao()
        {
            int segundos = int.Parse(Console.ReadLine());
            TimeSpan hora = TimeSpan.FromSeconds(segundos);  
            Console.WriteLine(hora.ToString(@"h\:m\:s"));
        }
    }
}
