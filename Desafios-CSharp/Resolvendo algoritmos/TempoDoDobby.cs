using System;

namespace Desafios_CSharp.Resolvendo_algoritmos
{
    public class TempoDoDobby
    {
        public static void Resolucao()
        {
            int minutosRestante = int.Parse(Console.ReadLine());
            string[] minutos = Console.ReadLine().Split();
            if (minutosRestante < (int.Parse(minutos[0]) + int.Parse(minutos[1])))
            {
                Console.WriteLine("Deixa para amanha!");
            } else
            {
                Console.WriteLine("Farei hoje!");                
            }
        }

    }
}
