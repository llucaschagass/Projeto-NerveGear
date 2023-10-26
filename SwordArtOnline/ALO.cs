using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordArtOnline
{
    public class ALO
    {
        public ALO()
        {
            Console.WriteLine("Bem vindo ao mundo de Alfheim Online!");
            Console.WriteLine("Informe seu nome: ");
            string nomejogador = Console.ReadLine();
            Console.WriteLine($"Muito Prazer {nomejogador}!");
            Console.WriteLine("Você irá começar no nível 1, e irá progredir adquirindo experiencia ao derrotar inimigos");
            Console.WriteLine("");

            Console.WriteLine("Escolha sua arma:");
            Console.WriteLine("1. Espada");
            Console.WriteLine("2. Arco");
            Console.WriteLine("3. Magia");
            int armas = int.Parse(Console.ReadLine());
            string escolhaarma;

                switch (armas)
                {
                    case 1:
                        escolhaarma = "Espada";
                        break;
                    case 2:
                        escolhaarma = "Arco";
                        break;
                    case 3:
                        escolhaarma = "Magia";
                        break;
                    default:
                        Console.WriteLine("Arma desconhecida");
                        escolhaarma = "Arma desconhecida";
                        break;
                }

                Console.WriteLine($"Você escolheu a arma: {escolhaarma}");
                Console.WriteLine("");

                Console.WriteLine("Regras do jogo: ");
                Console.WriteLine("Diferente de Sword Art Online você não está preso");
                Console.WriteLine("Caso você morra no jogo você será revivido");
                Console.WriteLine("Boa jogatina e aproveite a experiencia");
                Console.WriteLine("");

                JogoBase basealo = new JogoBase(nomejogador, escolhaarma);
        }
    }
}

