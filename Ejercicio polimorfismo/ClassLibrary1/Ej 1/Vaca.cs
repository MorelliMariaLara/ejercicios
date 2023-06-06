using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vaca : Animal 
    {
        public string NombreVaca { get; set; }
        public override string Sonido()
        {
            return "muu";
        }
    }
}
