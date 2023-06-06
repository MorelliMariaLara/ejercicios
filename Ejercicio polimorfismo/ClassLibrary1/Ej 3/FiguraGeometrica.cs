using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class FiguraGeometrica
    {
        public string Nombre { get; set; } 

        public abstract double CalcularArea();
    }
}
