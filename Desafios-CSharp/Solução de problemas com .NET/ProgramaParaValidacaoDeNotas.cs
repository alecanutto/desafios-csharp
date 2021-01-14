using System;
using System.Collections.Generic;
using System.Globalization;

namespace Desafios_CSharp.Solução_de_problemas_com_.NET
{
    public class ProgramaParaValidacaoDeNotas
    {
        public static void Resolucao()
        {
            List<double> notas = new List<double>();
            int opcao;
            do
            {
                while (notas.Count < 2)
                {
                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (nota < 0 || nota > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        notas.Add(nota);
                    }
                }
                double media = (notas[0] + notas[1]) / 2;
                Console.WriteLine("media = " + media.ToString("N2"));
                notas.Clear();

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                } while (opcao != 1 && opcao != 2);

            } while (opcao == 1);
        }
    }
}
