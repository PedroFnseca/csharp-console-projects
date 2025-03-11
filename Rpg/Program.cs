Personagem pedro = new Personagem("Pedro", 100, 20);
Personagem barreto = new Personagem("Barreto", 20, 10);

Console.WriteLine(barreto.Vida);
pedro.AtacarPersonagem(barreto);
Console.WriteLine(barreto.Vida);
