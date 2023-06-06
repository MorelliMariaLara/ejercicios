using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Piano : InstrumentoMusical
    {
        public string InstrumentoPian { get; set; }
        public virtual string Tocar()
        {
            return "Sonido de piano";
        }
    }
}
