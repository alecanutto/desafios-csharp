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
            Console.WriteLine();
            Desafio4();
            Console.WriteLine();
            Desafio5();
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
            double media =  coxinhas / participantes;
            Console.WriteLine(media.ToString("N2"));
        }


    }
}
