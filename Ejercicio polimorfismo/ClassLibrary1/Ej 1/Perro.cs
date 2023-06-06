using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Perro : Animal 
    {
        public string NombrePerro { get; set; }
        public override string Sonido()
        {
            return "guau";
        }
    }
}
