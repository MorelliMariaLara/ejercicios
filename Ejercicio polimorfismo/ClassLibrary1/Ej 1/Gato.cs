using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Gato : Animal 
    {
        public string  NombreGato { get; set; }
        public override string Sonido()
        {
            return "miau";
        }
    }
}
