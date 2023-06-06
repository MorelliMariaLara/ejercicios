using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);

        }
    }
}
