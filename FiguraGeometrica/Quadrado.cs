using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    internal class Quadrado : Figura
    {
        double Lado;

        public Quadrado(double Lado)
        {
            this.Lado = Lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 4;
        }

        public override void Desenhar()
        {
            for (int i = 0; i < Lado; i++)
            {
                for (int j = 0; j < Lado; j++)
                {
                    if (i == 0 || i == Lado - 1 || j == 0 || j == Lado - 1)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
