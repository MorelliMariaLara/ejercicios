using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public override double CalcularArea()
        {
            return Largo * Ancho;

        }
    }
}
