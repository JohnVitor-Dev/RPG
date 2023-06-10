using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace RPG.Codigos;

public static class RPG
{
    public static void Main()
    {
        int GanhadorLuta = 0;
        bool BatalhaAndamento = true;

        Jogador player1 = new Jogador();
        Jogador player2 = new Jogador();
        Sc CardsPlayer1 = new Sc();
        Sc CardsPlayer2 = new Sc();

        void CriarJogadores()
        {
            // Configurar Player 1
            Console.Write("(Jogador 1) Qual o seu nick? ");
            player1.Nome = player1.PegarNome();
            Console.Write("(Jogador 1) Qual o seu clã? ");
            player1.WhatCla = player1.PegarCla();
            CardsPlayer1.Cla(player1.WhatCla);

            Console.WriteLine("");

            // Configurar Player 2
            Console.Write("(Jogador 2) Qual o seu nick? ");
            player2.Nome = player2.PegarNome();
            Console.Write("(Jogador 2) Qual o seu clã? ");
            player2.WhatCla = player2.PegarCla();
            CardsPlayer2.Cla(player2.WhatCla);
        }
        
        int JoKenPo()
        {
            int Ganhador_JKP = 0;
            string Player1_JKP = "";
            string Player2_JKP = "";
            
            while(Ganhador_JKP == 0)
            {
                Console.Clear();
                Console.WriteLine("JO KEN PO!!!\n");
                Console.WriteLine($"{player1.Nome} escolha uma opção: ");
                Console.WriteLine(" 1 - Pedra \n 2 - Papel \n 3 - Tesoura \n");
                Player1_JKP = Console.ReadLine();
                int Player1I_JKP = int.Parse(Player1_JKP);
                Console.Clear();
                Console.WriteLine($"{player2.Nome} escolha uma opção: ");
                Console.WriteLine(" 1 - Pedra \n 2 - Papel \n 3 - Tesoura \n");
                Player2_JKP = Console.ReadLine();
                int Player2I_JKP = int.Parse(Player2_JKP);
                Console.Clear();

                if (Player1I_JKP == Player2I_JKP)
                {
                    Console.WriteLine("Empate!");
                }
                else if ((Player1I_JKP == 1 && Player2I_JKP == 3) ||
                         (Player1I_JKP == 2 && Player2I_JKP == 1) ||
                         (Player1I_JKP == 3 && Player2I_JKP == 2))
                {
                    Console.WriteLine($"{player1.Nome} ganhou!");
                    Ganhador_JKP = 1;
                    
                }
                else
                {
                    Console.WriteLine($"{player2.Nome} ganhou!");
                    Ganhador_JKP = 2;
                    ;
                }
            }
            
            return Ganhador_JKP;
        }

        void VerificarNegativo()
        {
            if (player1.Vida <= 0)
            {
                player1.Vida = 0;
            }
            
            if (player2.Vida <= 0)
            {
                player2.Vida = 0;
            }

            if (player1.Chakra <= 0)
            {
                player1.Chakra = 0;
            }
            
            if (player2.Chakra <= 0)
            {
                player2.Chakra = 0;
            }

        }

        int VerificarGanhador()
        {
            int ValorDeRetorno = 0;

            if (player1.Vida == 0 && player2.Vida > 0)
            {
                ValorDeRetorno = 2;
            }

            if (player2.Vida == 0 && player1.Vida > 0)
            {
                ValorDeRetorno = 1;
            }

            if (player1.Vida == 0 && player2.Vida == 0)
            {
                if (player1.Chakra > player2.Chakra)
                {
                    ValorDeRetorno = 1;
                }

                if (player1.Chakra < player2.Chakra)
                {
                    ValorDeRetorno = 2;
                }
            }

            return ValorDeRetorno;
        }


        int Batalha()
        {
            int GanhadorBatalha = 0;
            bool MensagemExibida1 = false;
            int OrdemDeJogada = 0;

            while (BatalhaAndamento == true)
            {
                string Carta1 = "";
                string Carta2 = "";

                if (!MensagemExibida1)
                {
                    switch (JoKenPo())
                    {
                        case 1:
                            Console.WriteLine($"\nQuem começa é: {player2.Nome}\n");
                            OrdemDeJogada = 2;
                            MensagemExibida1 = true;
                            break;
                        case 2:
                            Console.WriteLine($"\nQuem começa é: {player1.Nome}\n");
                            OrdemDeJogada = 1;
                            MensagemExibida1 = true;
                            break;
                    }
                }

                Console.WriteLine("--------------------------");
                Console.WriteLine($"({player1.Nome}) {player1.Vida}/{player1.Chakra}");
                //Console.WriteLine(Usados1);
                Console.WriteLine("\nVs\n\n");
                Console.WriteLine($"({player2.Nome}) {player2.Vida}/{player2.Chakra}\n");
                //Console.WriteLine(Usados2);
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
                    //player2.Vida = player2.Vida - CardsPlayer1.Kis.Danunao;
                    //Console.WriteLine($"Vida player1 = {player1.Vida}, Player 2 = {player2.Vida}");

                }

                VerificarNegativo();
                GanhadorBatalha = VerificarGanhador();

                if(GanhadorBatalha == 0)
                {
                    BatalhaAndamento = true;

                } else if(GanhadorBatalha == 1)
                {
                    BatalhaAndamento = false;
                    break;

                } else if(GanhadorBatalha == 2)
                {
                    BatalhaAndamento = false;
                    break;

                }

                Console.Clear();

                
            }

            return GanhadorBatalha;
        }

        CriarJogadores();
        Console.Clear();
        GanhadorLuta = Batalha();
        Console.Clear();

        Console.WriteLine("--------------------------");
        Console.WriteLine($"({player1.Nome}) {player1.Vida}/{player1.Chakra}");
        //Console.WriteLine(Usados1);
        Console.WriteLine("\nVs\n\n");
        Console.WriteLine($"({player2.Nome}) {player2.Vida}/{player2.Chakra}\n");
        //Console.WriteLine(Usados2);
        Console.WriteLine("--------------------------");

        if(GanhadorLuta == 1)
        {
            Console.WriteLine($"{player1.Nome} é o ganhador!!");
        } else if (GanhadorLuta == 2)
        {
            Console.WriteLine($"{player2.Nome} é o ganhador!!");
        } else
        {
            Console.WriteLine("Erro 19");
        }





    }
}

