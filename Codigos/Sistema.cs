using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RPG.Codigos;

public static class RPG
{
    public static void Main()
    {

        bool BatalhaAndamento = true;
        //john
        Jogador player1 = new Jogador();
        Console.Write("(Jogador 1) Qual o seu nick? ");
        player1.Nome = player1.PegarNome();
        Console.Write("(Jogador 1) Qual o seu clã? ");
        player1.WhatCla = player1.PegarCla();
        Sc CardsPlayer1 = new Sc();
        CardsPlayer1.Cla(player1.WhatCla);

        Jogador player2 = new Jogador();
        Console.Write("(Jogador 2) Qual o seu nick? ");
        player2.Nome = player2.PegarNome();
        Console.Write("(Jogador 2) Qual o seu clã? ");
        player2.WhatCla = player2.PegarCla();
        Sc CardsPlayer2 = new Sc();
        CardsPlayer2.Cla(player2.WhatCla);

        Console.Clear();

        Console.WriteLine("Escolha um numero: ");
        string Random = Console.ReadLine();
        Console.Clear();
        int QuemComeca = 0;
        bool FraseComeca = true;
        bool ComecaBug = true;


        if (Random == "1")
        {
            QuemComeca = 1;

        }
        else if (Random == "2")
        {
            QuemComeca = 2;

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Erro");
            BatalhaAndamento = false;
        }


        // Variabeis Batalha

        string Usados1 = "";
        string Usados2 = "";

        int OrdemDeJogada = 0;

        while (BatalhaAndamento == true)
        {
            Console.Clear();

            string Carta1 = "";
            string Carta2 = "";
            string n = "";

            if (player1.Vida <= 0)
            {
                player1.Vida = 0;
            }
            else if (player2.Vida <= 0)
            {
                player2.Vida = 0;
            }

            if (player1.Vida == 0 || player2.Vida == 0)
            {
                Console.Clear();
                break;
            }

            if (QuemComeca == 1 && ComecaBug == true)
            {
                OrdemDeJogada = 1;
                n = player1.Nome;
                Console.WriteLine($"\nQuem começa é: {n}\n");
                ComecaBug = false;
            }
            else if (QuemComeca == 2 && ComecaBug == true)
            {
                OrdemDeJogada = 2;
                n = player2.Nome;
                Console.WriteLine($"\nQuem começa é: {n}\n");
                ComecaBug = false;
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine($"({player1.Nome}) {player1.Vida}/{player1.Chakra}");
            Console.WriteLine(Usados1);
            Console.WriteLine("\nVs\n\n");
            Console.WriteLine($"({player2.Nome}) {player2.Vida}/{player2.Chakra}\n");
            Console.WriteLine(Usados2);
            Console.WriteLine("--------------------------");

            if (OrdemDeJogada == 1)
            {
                Console.WriteLine($"{player1.Nome} escolha uma carta: ");
                Carta1 = Console.ReadLine();


                Console.WriteLine($"{player2.Nome} escolha uma carta: ");
                Carta2 = Console.ReadLine();

                OrdemDeJogada = 2;

            }
            else if (OrdemDeJogada == 2)
            {

                Console.WriteLine($"{player2.Nome} escolha uma carta: ");
                Carta2 = Console.ReadLine();

                Console.WriteLine($"{player1.Nome} escolha uma carta: ");
                Carta1 = Console.ReadLine();

                OrdemDeJogada = 1;

            }

            if (Carta1 == CardsPlayer1.ID_Kunais.ToString())
            {
                player1.Vida = player1.Vida - CardsPlayer2.Kunais.Dano;
                player2.Vida = player2.Vida - CardsPlayer1.Kunais.Dano;
                Console.WriteLine($"Vida player1 = {player1.Vida}, Player 2 = {player2.Vida}");

            }
        }

        Console.WriteLine("--------------------------");
        Console.WriteLine($"({player1.Nome}) {player1.Vida}/{player1.Chakra}");
        Console.WriteLine(Usados1);
        Console.WriteLine("\nVs\n\n");
        Console.WriteLine($"({player2.Nome}) {player2.Vida}/{player2.Chakra}\n");
        Console.WriteLine(Usados2);
        Console.WriteLine("--------------------------");




    }
}

