public class Personagem
{
	public int Vida { get; set; } 

	public string Name { get; private set; }
	public int Ataque { get; private set; }
	public int Defesa { get; private set; }

	public Personagem(string name, int ataque, int defesa) 
	{
		Ataque = ataque;
		Defesa = defesa;
		Name = name;
		Vida = 100;
	}

	public void AtacarPersonagem(Personagem alvo)
	{
		int dano = Ataque - Defesa;

		if (dano == 0 || alvo.Vida == 0) return;

		if (alvo.Vida - dano < 0) alvo.Vida = 0;
		else alvo.Vida -= dano;
	}
}
