using SwordArtOnline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordArtOnline
{
    public class GGO
    {
        public GGO()
        {
            Console.WriteLine("");
            Console.WriteLine("»»————-————-————-—　||　-————-————-————-««");
            Console.WriteLine("");
            Console.WriteLine("┌──────────────── ---- ────────────────┐\r\n Bem-vindo ao mundo de Gun Gale Online! \r\n└──────────────── ---- ────────────────┘");
            Console.WriteLine("");
            Console.WriteLine("»»————-————-————-—　||　-————-————-————-««");
            Console.WriteLine("");
            Console.WriteLine("Informe seu nome: ");
            Console.WriteLine("");
            string nomejogador = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Muito Prazer, {nomejogador}!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Você irá começar no nível 1, e terá que progredir adquirindo experiência ao derrotar inimigos.");
            Console.WriteLine("");
            Console.WriteLine("Boa sorte!");
            Console.WriteLine("");

            int armas;
            string escolhaarma = "";

            while (true) // Loop principal
            {
                Console.WriteLine("Escolha seu armamento:");
                Console.WriteLine("1. Armas Ópticas");
                Console.WriteLine("2. Armas Físicas");
                Console.WriteLine("3. Armas Brancas");
                Console.WriteLine("4. Descrição para cada tipo de armamento");
                Console.WriteLine("0. Sair do jogo"); // Adicionando a opção de sair
                armas = int.Parse(Console.ReadLine());

                switch (armas)
                {
                    case 1:
                        escolhaarma = "Metralhadora";
                        break;
                    case 2:
                        escolhaarma = "Espingarda";
                        break;
                    case 3:
                        escolhaarma = "Rifle";
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Armas Ópticas:");
                        Console.WriteLine("Disfere disparos de munição leve. Esse tipo de armamento é usados principalmente para caçar squads\r\nou uma grande quantidade de players. Suas vantagens incluem serem mais leves, terem maior\r\nalcance efetivo e precisão. No entanto, equipamentos defensivos podem ser usados para dispersar\r\nos danos das armas ópticas, tornando-as ineficazes contra os jogadores, bem como tamanho de carregador\r\nmenor do que as armas de munição física. Todas as armas ópticas recebem nomes e formatos fantásticos.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Armas Físicas:");
                        Console.WriteLine("Destinada a batalhas player x player, pois são capazes de ignorar a maioria dos meios defensivos.\r\nAs balas dessas armas podem passar por campos de defesa e causar maiores danos por acerto\r\nem comparação com armas ópticas. No entanto, as desvantagens incluem ter que carregar carregadores\r\nde balas extra pesados e o fato de que a trajetória da bala ativa é afetada pelo vento e pela umidade.\r\nAs armas nesta categoria são todas originadas de armas que existem no mundo real.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Armas Brancas:");
                        Console.WriteLine("Com os melhores atributos de perfuração e dano a curto alcance, essas lâminas afiadas e instrumentos\r\ncortantes oferecem uma vantagem letal em combates corpo a corpo. Sua principal característica\r\né a leveza, tornando os portadores excepcionalmente ágeis no campo de batalha. Entretanto,\r\nas armas brancas têm suas desvantagens, como a ausência de capacidade de infligir danos a longa distância,\r\ntornando-as ineficazes nesse tipo de confronto.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Até logo! Obrigado por jogar.");
                        Environment.Exit(0); // Sai do jogo
                        break;
                    default:
                        Console.WriteLine("Arma desconhecida");
                        escolhaarma = "Arma desconhecida";
                        break;
                }

                if (armas != 4) // Volta ao menu se a escolha não for 4
                {
                    Console.WriteLine($"Você escolheu a arma: {escolhaarma}");
                    Console.WriteLine("");
                    Console.WriteLine("Regras do jogo: ");
                    Console.WriteLine("Diferente de Sword Art Online você não está preso.");
                    Console.WriteLine("Caso você morra no jogo você será revivido.");
                    Console.WriteLine("Boa jogatina e aproveite a experiência");
                    Console.WriteLine("");

                    JogoBase baseggo = new JogoBase(nomejogador, escolhaarma);
                }
            }
        }
    }
}