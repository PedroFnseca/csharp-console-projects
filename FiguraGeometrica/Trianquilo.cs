using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    internal class Trianquilo : Figura
    {
        double Lado1;
        double Lado2;
        double Lado3;

        public Trianquilo(double Lado1, double Lado2, double Lado3)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
            this.Lado3 = Lado3;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public override double CalcularArea()
        {
            switch (TipoTriangulo())
            {
                case "Equilátero":
                    return Math.Pow(Lado1, 2) * Math.Sqrt(3) / 4;
                case "Isósceles":
                    double baseTriangulo = Lado1 == Lado2 ? Lado3 : (Lado1 == Lado3 ? Lado2 : Lado1);
                    double altura = Math.Sqrt(Math.Pow(Lado1, 2) - Math.Pow(baseTriangulo / 2, 2));
                    return (baseTriangulo * altura) / 2;
                case "Escaleno":
                    double semiPerimetro = CalcularPerimetro() / 2;
                    return Math.Sqrt(semiPerimetro * (semiPerimetro - Lado1) * (semiPerimetro - Lado2) * (semiPerimetro - Lado3));
                default:
                    return 0;
            }
        }

        private string TipoTriangulo()
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return "Equilátero";
            }
            else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado1 == Lado3)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }

        public override void Desenhar()
        {
            for (int i = 0; i < Lado1; i++)
            {
                for (int j = 0; j < Lado1; j++)
                {
                    if (i + j >= Lado1 - 1)
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
