using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScCards;

class Combate
{
    public Sc CardsPlayer1 = new Sc();
    public Sc CardsPlayer2 = new Sc();

    public enum CardID
    {
        Fcla = 1,
        Fgen,
        AD100barra100,
        Clones1,
        Clones2,
        FugaSdano,
        FugaCdano,
        Camu,
        Barreira,
        Kunais,
        TaiEspecial,
        Paralisia,
        N200barra200,
        N50barra50,
        Reflexo
    }

    public void FightSystem(int OrdemCard, int CardP1, int CardP2)
    {
        Card CardGame1 = new Card();
        Card CardGame2 = new Card();

        if (Enum.IsDefined(typeof(CardID), CardP1) && Enum.IsDefined(typeof(CardID), CardP2))
        {
            CardID cardId1 = (CardID)CardP1;
            CardID cardId2 = (CardID)CardP2;

            switch (cardId1)
                {
                    case CardID.Fcla:
                        CardGame1 = CardsPlayer1.Fcla;
                        break;
                    case CardID.Fgen:
                        CardGame1 = CardsPlayer1.Fgen;
                        break;
                    case CardID.AD100barra100:
                        CardGame1 = CardsPlayer1.AD100barra100;
                        break;
                    case CardID.Clones1:
                        CardGame1 = CardsPlayer1.Clones1;
                        break;
                    case CardID.Clones2:
                        CardGame1 = CardsPlayer1.Clones2;
                        break;
                    case CardID.FugaSdano:
                        CardGame1 = CardsPlayer1.FugaSdano;
                        break;
                    case CardID.FugaCdano:
                        CardGame1 = CardsPlayer1.FugaCdano;
                        break;
                    case CardID.Camu:
                        CardGame1 = CardsPlayer1.Camu;
                        break;
                    case CardID.Barreira:
                        CardGame1 = CardsPlayer1.Barreira;
                        break;
                    case CardID.Kunais:
                        CardGame1 = CardsPlayer1.Kunais;
                        break;
                    case CardID.TaiEspecial:
                        CardGame1 = CardsPlayer1.TaiEspecial;
                        break;
                    case CardID.Paralisia:
                        CardGame1 = CardsPlayer1.Paralisia;
                        break;
                    case CardID.N200barra200:
                        CardGame1 = CardsPlayer1.N200barra200;
                        break;
                    case CardID.N50barra50:
                        CardGame1 = CardsPlayer1.N50barra50;
                        break;
                    case CardID.Reflexo:
                        CardGame1 = CardsPlayer1.Reflexo;
                        break;
                    default:
                        Console.WriteLine("Tipo de carta inválido");
                        return;
                }

            switch (cardId2)
                {
                    case CardID.Fcla:
                        CardGame2 = CardsPlayer2.Fcla;
                        break;
                    case CardID.Fgen:
                        CardGame2 = CardsPlayer2.Fgen;
                        break;
                    case CardID.AD100barra100:
                        CardGame2 = CardsPlayer2.AD100barra100;
                        break;
                    case CardID.Clones1:
                        CardGame2 = CardsPlayer2.Clones1;
                        break;
                    case CardID.Clones2:
                        CardGame2 = CardsPlayer2.Clones2;
                        break;
                    case CardID.FugaSdano:
                        CardGame2 = CardsPlayer2.FugaSdano;
                        break;
                    case CardID.FugaCdano:
                        CardGame2 = CardsPlayer2.FugaCdano;
                        break;
                    case CardID.Camu:
                        CardGame2 = CardsPlayer2.Camu;
                        break;
                    case CardID.Barreira:
                        CardGame2 = CardsPlayer2.Barreira;
                        break;
                    case CardID.Kunais:
                        CardGame2 = CardsPlayer2.Kunais;
                        break;
                    case CardID.TaiEspecial:
                        CardGame2 = CardsPlayer2.TaiEspecial;
                        break;
                    case CardID.Paralisia:
                        CardGame2 = CardsPlayer2.Paralisia;
                        break;
                    case CardID.N200barra200:
                        CardGame2 = CardsPlayer2.N200barra200;
                        break;
                    case CardID.N50barra50:
                        CardGame2 = CardsPlayer2.N50barra50;
                        break;
                    case CardID.Reflexo:
                        CardGame2 = CardsPlayer2.Reflexo;
                        break;
                    default:
                        Console.WriteLine("Tipo de carta inválido");
                        return;
                }
        }
        else
        {
            Console.WriteLine("Número de carta inválida");
        }

        if(OrdemCard == 1)
        {

        }


    }
}

