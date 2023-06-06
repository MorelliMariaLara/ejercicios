using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bateria : InstrumentoMusical
    {
        public string instrumentobat { get; set; }
        public virtual string Tocar()
        {
            return "Sonido de bateria";
        }
    }
}
