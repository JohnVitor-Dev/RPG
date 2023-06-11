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
        // Var Globais
        int GanhadorLuta = 0;
        bool BatalhaAndamento = true;

        // Jogadores
        Jogador player1 = new Jogador();
        Jogador player2 = new Jogador();
        string Player1Group;
        string Player2Group;

        // Combate
        Combate Fight = new Combate();
        

        void CriarJogadores()
        {
            // Configurar Player 1
            Console.Write("(Jogador 1) Qual o seu nick? ");
            player1.Nome = player1.PegarNome();
            Console.Write("(Jogador 1) Qual o seu clã? ");
            player1.WhatCla = player1.PegarCla();
            Player1Group = player1.WhatCla;
            Fight.CardsPlayer1.Cla(Player1Group);

            Console.WriteLine("");

            // Configurar Player 2
            Console.Write("(Jogador 2) Qual o seu nick? ");
            player2.Nome = player2.PegarNome();
            Console.Write("(Jogador 2) Qual o seu clã? ");
            player2.WhatCla = player2.PegarCla();
            Player2Group = player2.WhatCla;
            Fight.CardsPlayer2.Cla(Player2Group);

            Console.Clear();
        }
        
        int JoKenPo()
        {
            // Var JoKenPo
            int Ganhador_JKP = 0;
            string Player1_JKP = "";
            string Player2_JKP = "";
            
            // JoKenPo
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

        void Tabela()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"({player1.Nome})() {player1.Vida}/{player1.Chakra}");
            //Console.WriteLine(Usados1);
            Console.WriteLine("\nVs\n\n");
            Console.WriteLine($"({player2.Nome}) {player2.Vida}/{player2.Chakra}\n");
            //Console.WriteLine(Usados2);
            Console.WriteLine("--------------------------");
         }

        void VerificarNegativo()
        {
            // Previnir que a Vida e o Chakra fiquem negativos

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
            // Definir Ganhador

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
                        default:
                            Console.WriteLine("Erro 02");
                            break;
                    }
                }

                Tabela();

                if (OrdemDeJogada == 1)
                {
                    Console.WriteLine($"{player1.Nome} escolha uma carta: ");
                    Carta1 = Console.ReadLine();


                    Console.WriteLine($"{player2.Nome} escolha uma carta: ");
                    Carta2 = Console.ReadLine();

                    Fight.FightSystem(OrdemDeJogada, Carta1, Carta2);

                    OrdemDeJogada = 2;

                }
                else if (OrdemDeJogada == 2)
                {

                    Console.WriteLine($"{player2.Nome} escolha uma carta: ");
                    Carta2 = Console.ReadLine();

                    Console.WriteLine($"{player1.Nome} escolha uma carta: ");
                    Carta1 = Console.ReadLine();

                    Fight.FightSystem(OrdemDeJogada, Carta2, Carta1);

                    OrdemDeJogada = 1;

                }

                
                VerificarNegativo();
                GanhadorBatalha = VerificarGanhador();

                if(GanhadorBatalha == 0)
                {
                    BatalhaAndamento = true;

                } else if(GanhadorBatalha == 1)
                {
                    BatalhaAndamento = false;
                    Console.Clear();
                    break;

                } else if(GanhadorBatalha == 2)
                {
                    BatalhaAndamento = false;
                    Console.Clear();
                    break;

                }

                Console.Clear();

                
            }

            return GanhadorBatalha;
        }

        CriarJogadores();
        GanhadorLuta = Batalha();
        Tabela();
        
        switch(GanhadorLuta)
        {
            case 1:
                Console.WriteLine($"{player1.Nome} é o ganhador!!");
                break;
            case 2:
                Console.WriteLine($"{player2.Nome} é o ganhador!!");
                break;
            default:
                Console.WriteLine("Erro 01");
                break;
        }
        
    }
}

