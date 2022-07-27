using ListaPOO.Entities;
using System;

namespace ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patrulheiro patrulheiro = new Patrulheiro();
            Voador voador = new Voador();

            patrulheiro.Nome = "Homer";
            // patrulheiro.Vida = 1000;
            patrulheiro.Perseguidor = false;
            patrulheiro.Velocidade = 80;

            voador.Nome = "Marge";
            // voador.Vida = 1500;
            voador.Asas = 4;
            voador.AlturaMax = 2000;

            Console.WriteLine(patrulheiro.Patrulhar());
            Console.WriteLine(voador.Subir());
            Console.WriteLine(voador.Atacar());
            Console.WriteLine(patrulheiro.Defender());
            Console.WriteLine(patrulheiro.Atacar());
            Console.WriteLine(voador.Defender());            
            Console.WriteLine(voador.Atacar());
            Console.WriteLine(patrulheiro.Defender());
            Console.WriteLine(patrulheiro.Atacar());
            Console.WriteLine(voador.Defender());
        }
    }
}
