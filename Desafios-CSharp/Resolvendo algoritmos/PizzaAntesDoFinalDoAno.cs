using System;
using System.Collections.Generic;

namespace Desafios_CSharp.Resolvendo_algoritmos
{
    public class PizzaAntesDoFinalDoAno
    {
        public static void Resolucao()
        {
            string[] line = Console.ReadLine().Split();
            int numeroPessoas = int.Parse(line[0]);
            int numeroDatas = int.Parse(line[1]);

            bool auxiliar;
            List<string> datas = new List<string>();

            for (int i = 0; i < numeroDatas; i++)
            {
                auxiliar = true;
                string[] respostas = Console.ReadLine().Split();
                for (int x = 1; x <= numeroPessoas; x++)
                {
                    if (int.Parse(respostas[x]) == 0)
                    {
                        auxiliar = false;
                        break;
                    }                    
                }
                if (auxiliar)
                {
                    datas.Add(respostas[0]);
                }
            }

            datas.Sort((a, b) => a.Replace("/", "").CompareTo(b.Replace("/", "")));
            if (datas.Count > 0 )
            {
                Console.WriteLine(datas[0]);
            }
            else
            {
                Console.WriteLine("Pizza antes de FdA");
            }            
           
        }
    }
}
