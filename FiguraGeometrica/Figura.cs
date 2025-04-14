using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    internal class Figura
    {
        public virtual double CalcularArea()
        {
            return 0;
        }

        public virtual double CalcularPerimetro()
        {
            return 0;
        }

        public virtual void Desenhar()
        {
            Console.WriteLine("Desenhando uma figura");
        }
    }
}
