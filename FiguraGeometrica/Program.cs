using FiguraGeometrica;

Circulo circulo = new Circulo(5);
circulo.Desenhar();
Console.WriteLine($"Área do círculo: {circulo.CalcularArea()}");
Console.WriteLine($"Perímetro do círculo: {circulo.CalcularPerimetro()}\n\n");

Quadrado quadrado = new Quadrado(5);
quadrado.Desenhar();
Console.WriteLine($"Área do quadrado: {quadrado.CalcularArea()}");
Console.WriteLine($"Perímetro do quadrado: {quadrado.CalcularPerimetro()}\n\n");

Trianquilo triangulo = new Trianquilo(5, 5, 5);
triangulo.Desenhar();
Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}");
Console.WriteLine($"Perímetro do triângulo: {triangulo.CalcularPerimetro()}\n\n");

