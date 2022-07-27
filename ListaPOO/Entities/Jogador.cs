using ListaPOO.Enums;
using ListaPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO.Entities
{
    public class Jogador : IJogador
    {
        public Jogador(string nome)
        {
            Nome = nome;
        }

        public Jogador(string nome, float vida)
        {
            Nome = nome;
            Vida = vida;
        }

        public EAcoes Acoes { get; set; }
        public string Nome { get; set; }
        public float Vida { get; set; }

        public string Morrer()
        {
            Vida = 0;
            return "---- Game Over ----";
        }

        public void TrocarAcao()
        {
            bool sair = false;
            do
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.W:
                        Acoes = EAcoes.Pulando;
                        Console.WriteLine($"\nJogador está {Acoes}");
                        break;
                    case ConsoleKey.A:
                        Acoes = EAcoes.Correndo;
                        Console.WriteLine($"\nJogador está {Acoes}");
                        break;
                    case ConsoleKey.S:
                        Acoes = EAcoes.Defendendo;
                        Console.WriteLine($"\nJogador está {Acoes}");
                        break;
                    case ConsoleKey.D:
                        Acoes = EAcoes.Atacando;
                        Console.WriteLine($"\nJogador está {Acoes}");
                        break;
                    default:
                        Console.WriteLine("\nJogador ficou sem saber o que fazer");
                        sair = true;
                        break;
                }
            } while (!sair);
        }
    }
}
