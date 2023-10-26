using System;

namespace SwordArtOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja iniciar o NerveGear? ");
            Console.WriteLine("Sim: 1");
            Console.WriteLine("Não: 0");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                // Iniciar o NerveGear
                NerveGear nerveGear = new NerveGear();
            }
            else if (escolha == 0)
            {
                // Não iniciar o NerveGear
                Console.WriteLine("NerveGear não foi iniciado.");
            }
            else
            {
                // Opção inválida
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}