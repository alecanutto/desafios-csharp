using System;

namespace Desafios_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Desafio1();
            Console.WriteLine();
            Desafio2();
            Console.WriteLine();
            Desafio3();
        }

        public static void Desafio1()
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
                    double divisao = X / Y; // Digite aqui o calculo da divisao
                    Console.WriteLine(divisao.ToString("N1"));
                }
            }
        }

        public static void Desafio2()
        {
            int quilometros = int.Parse(Console.ReadLine());
            int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
            Console.WriteLine(minutos + " minutos");
        }

        public static void Desafio3()
        {
            int chico = 300 * int.Parse(Console.ReadLine());
            int bento = 1500 * int.Parse(Console.ReadLine());
            int bernardo = 600 * int.Parse(Console.ReadLine());
            int marina = 1000 * int.Parse(Console.ReadLine());
            int iara = 150 * int.Parse(Console.ReadLine());
            int marlene = 225;
            int total = chico + bento + bernardo + marina + iara + marlene; // Digite aqui o calculo total
            Console.WriteLine(total);
        }

    }
}
