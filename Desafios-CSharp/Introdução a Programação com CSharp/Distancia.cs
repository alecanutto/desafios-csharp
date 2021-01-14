using System;

namespace Desafios_CSharp.Introdução_a_Programação_com_CSharp
{
    public class Distancia
    {
        public static void Resolucao()
        {
            int quilometros = int.Parse(Console.ReadLine());
            int minutos = quilometros * 2; 
            Console.WriteLine(minutos + " minutos");
        }
    }
}
