using System;
using System.Linq;
using System.Collections.Generic;

class Jogador 
{	
	public string Nome;
	public int Vida = 200;
	public int Chakra = 400;
	public int WhatPlayer = 0;
	public string WhatCla;
	
	
	public string PegarNome()
	{
		string Nick = Console.ReadLine();
		return Nick;
	}
	
	public string PegarCla()
	{
		string Cla = Console.ReadLine();
		return Cla;
	}
}
