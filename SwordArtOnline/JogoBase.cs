using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SwordArtOnline
{
    public class JogoBase
    {
        private int vidaJogador;
        private int vidaChefe;
        private int forcaAtaqueJogador;
        private int forcaAtaqueChefe;
        private Random random = new Random();

        public JogoBase(string nomeJogador, string armaEscolhida)
        {
            Console.WriteLine("Iniciando a jornada...");

            // Inicialização da vida e da força de ataque do jogador e do chefe
            vidaJogador = 100; 
            vidaChefe = 150;   
            forcaAtaqueJogador = 20; 
            forcaAtaqueChefe = 25;   

            for (int nivel = 1; nivel <= 10; nivel++)
            {
                Console.WriteLine($"Nível {nivel}: Enfrente um inimigo!");
                bool vitoria = EnfrentarInimigo();

                if (vitoria)
                {
                    Console.WriteLine("Você derrotou o inimigo e avançou para o próximo andar.");
                    forcaAtaqueJogador += 5; // Aumento de força de ataque a cada nível
                    forcaAtaqueChefe += 5;   // Aumento de força de ataque do chefe a cada nível
                }
                else
                {
                    Console.WriteLine("Você morreu no jogo. Consequências severas...");
                    break;
                }
            }

            Console.WriteLine("Parabéns! Você completou todos os andares!");
        }

        private bool EnfrentarInimigo()
        {
            // Lógica de combate entre o jogador e o chefe da fase
            while (vidaJogador > 0 && vidaChefe > 0)
            {
                Console.WriteLine("Escolha sua ação:");
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Defender");
                Console.WriteLine("");

                int acao = int.Parse(Console.ReadLine());

                if (acao == 1) // Atacar
                {
                    int danoJogador = forcaAtaqueJogador; 
                    int danoChefe = forcaAtaqueChefe;     

                    if (vidaChefe > 0)
                    {
                        vidaChefe -= danoJogador;
                    }

                    Console.WriteLine($"Você causou {danoJogador} de dano ao chefe.");
                    Console.WriteLine($"Vida do jogador: {vidaJogador}");
                    Console.WriteLine($"Vida do chefe: {vidaChefe}");

                    if (vidaChefe <= 0)
                    {
                        Console.WriteLine("Você derrotou o chefe da fase!");
                        return true;
                    }
                }
                else if (acao == 2) // Defender
                {
                    Console.WriteLine($"Vida do jogador: {vidaJogador}");
                    Console.WriteLine($"Vida do chefe: {vidaChefe}");
                   Console.WriteLine("O jogador escolheu defender e não sofreu dano.");
                }

                // Ação aleatória do chefe (atacar ou defender)
                int acaoChefe = random.Next(2); // Gera 0 ou 1 aleatoriamente
                if (acaoChefe == 0)
                {
                    int danoChefe = forcaAtaqueChefe; 
                    if (vidaJogador > 0)
                    {
                        vidaJogador -= danoChefe;
                    }
                    Console.WriteLine($"O chefe causou {danoChefe} de dano a você.");
                    Console.WriteLine($"Vida do jogador: {vidaJogador}");
                    Console.WriteLine($"Vida do chefe: {vidaChefe}");
                }
                else
                {
                    Console.WriteLine("O chefe escolheu defender e não causou dano a você.");
                    Console.WriteLine($"Vida do jogador: {vidaJogador}");
                    Console.WriteLine($"Vida do chefe: {vidaChefe}");
                }
            }

            return false; // Em caso de empate, o jogador perde
        }
    }
}
