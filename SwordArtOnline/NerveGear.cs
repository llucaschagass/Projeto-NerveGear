using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordArtOnline
{
    public class NerveGear
    {
        public NerveGear()
        {
            Console.WriteLine("");
            Console.WriteLine("Iniciando o NerveGear...");
            Console.WriteLine("");
            Console.WriteLine("Deseja iniciar qual jogo?");
            Console.WriteLine("Sword Art Online (SAO): 1");
            Console.WriteLine("Alfheim Online (ALO): 2");
            Console.WriteLine("Gun Gale Online (GGO): 3");
            
            int escolhajogo = int.Parse(Console.ReadLine());

            if(escolhajogo == 1){
                Console.WriteLine("");
                Console.WriteLine("Iniciando SAO...");
                Console.WriteLine("");
                Console.WriteLine("Link Start!");
                SAO jogosao = new SAO();
            }

            else if(escolhajogo == 2){
                Console.WriteLine("");
                Console.WriteLine("Iniciando ALO...");
                Console.WriteLine("");
                Console.WriteLine("Link Start!");
                ALO jogoalo = new ALO();
            }

            else if(escolhajogo == 3){
                Console.WriteLine("");
                Console.WriteLine("Iniciando GGO...");
                Console.WriteLine("");
                Console.WriteLine("Link Start!");
                GGO jogoggo = new GGO();
            }

            else{
                Console.WriteLine("");
                Console.WriteLine("Opção inválida");
            }
        }
    }
}

