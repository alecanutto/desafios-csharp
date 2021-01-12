using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

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
            Console.WriteLine();
            Desafio4();
            Console.WriteLine();
            Desafio5();
            Console.WriteLine();
            Desafio6();
            Console.WriteLine();
            Desafio7();
            Console.WriteLine();
            Desafio8();
            Console.WriteLine();
            Desafio9();
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

        public static void Desafio4()
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                if (i > 100) return;
                string[] line = Console.ReadLine().Split(" ");
                string sheldon = line[0].ToLower();
                string raj = line[1].ToLower();

                switch (sheldon)
                {
                    case "pedra":
                        switch (raj)
                        {
                            case "lagarto":
                            case "tesoura":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "pedra":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    case "papel":
                        switch (raj)
                        {
                            case "pedra":
                            case "spock":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "papel":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    case "tesoura":
                        switch (raj)
                        {
                            case "papel":
                            case "lagarto":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "tesoura":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    case "lagarto":
                        switch (raj)
                        {
                            case "spock":
                            case "papel":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "lagarto":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    case "spock":
                        switch (raj)
                        {
                            case "tesoura":
                            case "pedra":
                                Console.WriteLine("Caso #" + i + ": Bazinga!");
                                break;
                            case "spock":
                                Console.WriteLine("Caso #" + i + ": De novo!");
                                break;
                            default:
                                Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public static void Desafio5()
        {
            string[] line = Console.ReadLine().Split(" ");
            double coxinhas = int.Parse(line[0]);
            double participantes = int.Parse(line[1]);
            double media = coxinhas / participantes;
            Console.WriteLine(media.ToString("N2"));
        }

        public static void Desafio6()
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

        public static void Desafio7()
        {
            int limit = int.Parse(Console.ReadLine());
            List<string> lista = new List<string>();
            for (int i = 0; i < limit; i++)
            {
                if (i > 100) return;
                string[] line = Console.ReadLine().Split(" ");
                for (int item = 0; item < line.Length; item++)
                {
                    if (item > 1000) return;
                    if (!lista.Contains(line[item]))
                    {
                        lista.Add(line[item]);
                    }
                }
                lista.Sort();
                Console.WriteLine(string.Join(" ", lista));
                lista.Clear();
            }
        }

        public static void Desafio8()
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

        public static void Desafio9()
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                if (i > 1000) return;
                int pessoas = int.Parse(Console.ReadLine());
                List<int> lista = new List<int>();
                string[] line = Console.ReadLine().Split(" ");
                foreach (string item in line)
                {
                    if (lista.Count > 1000) return;
                    lista.Add(int.Parse(item));
                }
                lista.Sort((a, b) => b.CompareTo(a));

                int quantidade = pessoas;
                for (int x = 0; x < lista.Count; x++)
                {
                    if (int.Parse(line[x]) != lista[x])
                    {
                        quantidade--;
                    }
                }
                Console.WriteLine(quantidade);
            }
        }
        
    }
}
