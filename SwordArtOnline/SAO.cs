using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordArtOnline
{
    public class SAO 
    {
        public SAO()
        {
            Console.WriteLine("Bem vindo ao mundo de Sword Art Online!");
            Console.WriteLine("Informe seu nome: ");
            string nomejogador = Console.ReadLine();
            Console.WriteLine($"Muito Prazer {nomejogador}!");
            Console.WriteLine("Você irá começar no nível 1, e irá progredir adquirindo experiencia ao derrotar inimigos");
            Console.WriteLine("");

            Console.WriteLine("Escolha sua arma:");
            Console.WriteLine("1. Espada");
            Console.WriteLine("2. Arco");
            Console.WriteLine("3. Machado");
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
                        escolhaarma = "Machado";
                        break;
                    default:
                        Console.WriteLine("Arma desconhecida");
                        escolhaarma = "Arma desconhecida";
                        break;
                }

                Console.WriteLine($"Você escolheu a arma: {escolhaarma}");
                Console.WriteLine("");

                Console.WriteLine("Regras do jogo: ");
                Console.WriteLine("Você está preso em Sword Art Online até completar todos os níveis.");
                Console.WriteLine("Caso você morra no jogo automaticamente seu nervegear irá liberar"  + Environment.NewLine + "uma onda eletromagnetica em seu cérebro capaz de te matar" + Environment.NewLine + "Caso alguém tente remover o capacete a mesma onda eletromagnetica irá ser disparada em você." );
                Console.WriteLine("Tome muito cuidado! Pois só ha uma chance! Boa jogatina");
                Console.WriteLine("");

                JogoBase basesao = new JogoBase(nomejogador, escolhaarma);
        }
    }
}

