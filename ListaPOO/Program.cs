using ListaPOO.Entities;
using ListaPOO.Tools;
using System;
using System.Collections.Generic;

namespace ListaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Patrulheiro patrulheiro = new Patrulheiro(80);
            //Voador voador = new Voador();

            //patrulheiro.Nome = "Homer";
            //// patrulheiro.Vida = 1000;
            //patrulheiro.Perseguidor = false;
            ////patrulheiro.Velocidade = 80;

            //voador.Nome = "Marge";
            //// voador.Vida = 1500;
            //voador.Asas = 4;
            //voador.AlturaMax = 2000;

            //Console.WriteLine(patrulheiro.Patrulhar());
            //Console.WriteLine(voador.Subir());
            //Console.WriteLine(voador.Atacar());
            //Console.WriteLine(patrulheiro.Defender());
            //Console.WriteLine(patrulheiro.Atacar());
            //Console.WriteLine(voador.Defender());
            //Console.WriteLine(voador.Atacar());
            //Console.WriteLine(patrulheiro.Defender());
            //Console.WriteLine(patrulheiro.Atacar());
            //Console.WriteLine(voador.Defender());

            //float[] valores = null;
            float[] valores = { 5, 6, 8, 12, 7 };
            //float[] valores = { };
            Calculadora.Somar(valores);
            Calculadora.Subtrair(valores);
            Calculadora.Dividir(valores);
            Calculadora.Multiplicar(valores);

            //Jogador jogador1 = new Jogador(nome: "Bart");
            //Jogador jogador2 = new Jogador(nome: "Lisa", vida: 100);
            //Jogador jogador3 = new Jogador(nome: "Larry", vida: 85);
            ////jogador1.TrocarAcao();
            //Console.WriteLine(jogador1.Morrer());
            //Console.WriteLine($"\nVida do jogador: {jogador1.Vida}");

            ////jogador2.TrocarAcao();
            //Console.WriteLine(jogador2.Morrer());
            //Console.WriteLine($"\nVida do jogador: {jogador2.Vida}");

            //List<Jogador> listaJogadores = new List<Jogador>();
            //listaJogadores.Add(jogador1);
            //listaJogadores.Add(jogador2);
            //listaJogadores.Add(jogador3);
            //foreach (var jogador in listaJogadores)
            //{
            //    Console.WriteLine(jogador);
            //}
        }
    }
}
