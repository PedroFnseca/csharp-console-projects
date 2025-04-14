using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    internal class Circulo : Figura
    {
        private double Raio;
        
        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(this.Raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Raio;
        }

        public override void Desenhar()
        {
            for (int i = 0; i <= 2 * Raio; i++)
            {
                for (int j = 0; j <= 2 * Raio; j++)
                {
                    double distancia = Math.Sqrt(Math.Pow(i - Raio, 2) + Math.Pow(j - Raio, 2));
                    if (distancia < Raio)
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
