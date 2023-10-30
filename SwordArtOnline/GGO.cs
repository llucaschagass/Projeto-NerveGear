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

            while (true)
            {
                Console.WriteLine("Escolha o tipo do seu armamento:");
                Console.WriteLine("1. Armas Ópticas");
                Console.WriteLine("2. Armas Físicas");
                Console.WriteLine("3. Armas de Punho");
                Console.WriteLine("4. Descrição para cada tipo de armamento");
                Console.WriteLine("0. Sair do jogo");
                Console.WriteLine("");
                armas = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (armas)
                {
                    case 1:
                        Console.WriteLine("Escolha sua arma:");
                        Console.WriteLine("1. Procyon SL (Pistol)");
                        Console.WriteLine("2. Nemesis (Sniper Rifle)");
                        Console.WriteLine("3. Wingman (Assault Rifle)");
                        Console.WriteLine("0. Sair do jogo");
                        Console.WriteLine("");
                        int tipoArmaOptica = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        switch (tipoArmaOptica)
                        {
                            case 1:
                                escolhaarma = "Procyon SL";
                                break;
                            case 2:
                                escolhaarma = "Nemesis";
                                break;
                            case 3:
                                escolhaarma = "Wingman";
                                break;
                            case 0:
                                Console.WriteLine("");
                                Console.WriteLine("Até logo! Obrigado por jogar.");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Arma inválida.");
                                break;
                        }

                        if (tipoArmaOptica >= 1 && tipoArmaOptica <= 3)
                        {
                            Console.WriteLine("Arma selecionada com sucesso.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Escolha sua arma:");
                        Console.WriteLine("1. AK-47 (Assault Rifle)");
                        Console.WriteLine("2. M4A1 (Assault Rifle)");
                        Console.WriteLine("3. Barrett M82 (Sniper Rifle)");
                        Console.WriteLine("4. FN Five-seven (Pistol)");
                        Console.WriteLine("5. UMP (Submachine Gun)");
                        Console.WriteLine("6. Benelli M4 (Shotgun)");
                        Console.WriteLine("0. Sair do jogo");
                        Console.WriteLine("");
                        int tipoArmaFisica = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        switch (tipoArmaFisica)
                        {
                            case 1:
                                escolhaarma = "AK-47";
                                break;
                            case 2:
                                escolhaarma = "M4A1";
                                break;
                            case 3:
                                escolhaarma = "Barrett M82";
                                break;
                            case 4:
                                escolhaarma = "FN Five-seven";
                                break;
                            case 5:
                                escolhaarma = "UMP";
                                break;
                            case 6:
                                escolhaarma = "Benelli M4";
                                break;
                            case 0:
                                Console.WriteLine("Até logo! Obrigado por jogar.");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Arma inválida.");
                                break;
                        }

                        if (tipoArmaFisica >= 1 && tipoArmaFisica <= 6)
                        {
                            Console.WriteLine("Arma selecionada com sucesso.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Escolha sua arma:");
                        Console.WriteLine("1. Procyon SL (Pistol)");
                        Console.WriteLine("2. Nemesis (Sniper Rifle)");
                        Console.WriteLine("3. Wingman (Assault Rifle)");
                        Console.WriteLine("0. Sair do jogo");
                        Console.WriteLine("");
                        int tipoArmaPunho = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        switch (tipoArmaPunho)
                        {
                            case 1:
                                escolhaarma = "Kagemitsu G4 (Sabre de Luz)";
                                break;
                            case 2:
                                escolhaarma = "Baioneta (Faca)";
                                break;
                            case 3:
                                escolhaarma = "Katana (Espada)";
                                break;
                            case 0:
                                Console.WriteLine("");
                                Console.WriteLine("Até logo! Obrigado por jogar.");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Arma inválida.");
                                break;
                        }

                        if (tipoArmaPunho >= 1 && tipoArmaPunho <= 3)
                        {
                            Console.WriteLine("Arma selecionada com sucesso.");
                        }
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
                        Console.WriteLine("Armas de Punho:");
                        Console.WriteLine("Com os melhores atributos de perfuração e dano a curto alcance, essas lâminas afiadas e instrumentos\r\ncortantes oferecem uma vantagem letal em combates corpo a corpo. Sua principal característica\r\né a leveza, tornando os portadores excepcionalmente ágeis no campo de batalha. Entretanto,\r\nas armas brancas têm suas desvantagens, como a ausência de capacidade de infligir danos a longa distância,\r\ntornando-as ineficazes nesse tipo de confronto.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Até logo! Obrigado por jogar.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Arma desconhecida");
                        escolhaarma = "Arma desconhecida";
                        break;
                }

                if (armas != 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Muito bem! Você escolheu a arma {escolhaarma}, e agora deverá derrotar seus inimigos e provar ser o melhor\r\nentre os diversos players no mundo de Gun Gale Online.");
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