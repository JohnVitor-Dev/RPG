using System;
using System.Linq;
using System.Collections.Generic;

namespace ScCards;

class Card
{
    public string CardName;
    public int Dano;
    public int Ck;
    public bool UsedCard = false;
}

class Sc 
{
	public string Ativacao;
	
	public Card Fcla = new Card();
    public Card Fgen = new Card();
	public Card AD100barra100 = new Card();
	public Card Clones1 = new Card();
	public Card Clones2 = new Card();
	public Card FugaSdano = new Card();
	public Card FugaCdano = new Card();
	public Card Camu = new Card();
	public Card Barreira = new Card();
	public Card Kunais = new Card();
	public Card TaiEspecial = new Card();
	public Card Paralisia = new Card();
	public Card N200barra200 = new Card();
	public Card N50barra50 = new Card();
	public Card Reflexo = new Card();
	
	public void Cla(string ClaNome)
	{
        Fcla.CardName = "Falha Cl�";
        Fgen.CardName = "Falha Gen";
        AD100barra100.CardName = "100/100";
        Clones1.CardName = "Clones 1";
        Clones2.CardName = "Clones 2";
        FugaSdano.CardName = "Fuga";
        FugaCdano.CardName = "Fuga Com Dano";
        Camu.CardName = "Camuflagem";
        Barreira.CardName = "Barreira";
        Kunais.CardName = "Kunais";
        TaiEspecial.CardName = "Taijutsu Especial";
        Paralisia.CardName = "Paralisia";
        N200barra200.CardName = "200/200";
        N50barra50.CardName = "50/50";
        Reflexo.CardName = "Reflexo";


        if (ClaNome == "Hozuki")
		{	
			Ativacao = "Red";
			
			Fcla.Dano = 0;
			Fcla.Ck = 40;
			Fgen.Dano = 0;
			Fgen.Ck = 0;
			AD100barra100.Dano = 100;
			AD100barra100.Ck = 100;
			Clones1.Dano = 0;
			Clones1.Ck = 50;
			Clones2.Dano = 0;
			Clones2.Ck = 50;
			FugaSdano.Dano = 0;
			FugaSdano.Ck = 40;
			FugaCdano.Dano = 0;
			FugaCdano.Ck = 40;
			Camu.Dano = 0;
			Camu.Ck = 50;
			Barreira.Dano = 0;
			Barreira.Ck = 50;
			Kunais.Dano = 130;
			Kunais.Ck = 0;
			TaiEspecial.Dano = 130;
			TaiEspecial.Ck = 0;
			Paralisia.Dano = 30;
			Paralisia.Ck = 70;
			N200barra200.Dano = 200;
			N200barra200.Ck = 200;
			N50barra50.Dano = 50;
			N50barra50.Ck = 50;
			Reflexo.Dano = 0;
			Reflexo.Ck = 40;
			
		} /* else if(ClaNome == "Senju")
		{
			
			Ativacao = "Red";
			
			ID_Fclan = 1;
		    ID_Fgen = 2;
		    ID_AD100barra100 = 3;
			ID_Clones1 = 4;
			ID_Clones2 = 5;
		    ID_FugaSdano = 6;
			ID_FugaCdano = 7;
			ID_Camu = 8;
			ID_Barreira = 9;
			ID_Kunais = 10;
			ID_TaiEspecial = 11;
			ID_Paralisia = 12;
			ID_N200barra200 = 13;
			ID_N50barra50 = 14;
			ID_Reflexo = 15;
			
			Fcla.Dano = 0;
			Fcla.Ck = 40;
			Fgen.Dano = 0;
			Fgen.Ck = 0;
			AD100barra100.Dano = 100;
			AD100barra100.Ck = 100;
			Clones1.Dano = 0;
			Clones1.Ck = 50;
			Clones2.Dano = 0;
			Clones2.Ck = 50;
			FugaSdano.Dano = 0;
			FugaSdano.Ck = 40;
			FugaCdano.Dano = 0;
			FugaCdano.Ck = 40;
			Camu.Dano = 0;
			Camu.Ck = 50;
			Barreira.Dano = 0;
			Barreira.Ck = 50;
			Kunais.Dano = 200;
			Kunais.Ck = 0;
			TaiEspecial.Dano = 130;
			TaiEspecial.Ck = 0;
			Paralisia.Dano = 30;
			Paralisia.Ck = 70;
			N200barra200.Dano = 200;
			N200barra200.Ck = 200;
			N50barra50.Dano = 50;
			N50barra50.Ck = 50;
			Reflexo.Dano = 0;
			Reflexo.Ck = 40;
		 */
	}

	
	
	

}
