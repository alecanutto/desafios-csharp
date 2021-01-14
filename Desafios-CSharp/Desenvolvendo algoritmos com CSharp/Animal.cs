using System;

namespace Desafios_CSharp.Desenvolvendo_algoritmos_com_CSharp
{
    public class Animal
    {
        public static void Resolucao()
        {
            string primeiraDefinicao = Console.ReadLine().ToLower();
            string segundaDefinicao = Console.ReadLine().ToLower();
            string terceiraDefinicao = Console.ReadLine().ToLower();

            if (primeiraDefinicao == "vertebrado" && segundaDefinicao == "ave" && terceiraDefinicao == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (primeiraDefinicao == "vertebrado" && segundaDefinicao == "ave" && terceiraDefinicao == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            else if (primeiraDefinicao == "vertebrado" && segundaDefinicao == "mamifero" && terceiraDefinicao == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (primeiraDefinicao == "vertebrado" && segundaDefinicao == "mamifero" && terceiraDefinicao == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
            else if (primeiraDefinicao == "invertebrado" && segundaDefinicao == "inseto" && terceiraDefinicao == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (primeiraDefinicao == "invertebrado" && segundaDefinicao == "inseto" && terceiraDefinicao == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (primeiraDefinicao == "invertebrado" && segundaDefinicao == "anelideo" && terceiraDefinicao == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (primeiraDefinicao == "invertebrado" && segundaDefinicao == "anelideo" && terceiraDefinicao == "onivoro")
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}
