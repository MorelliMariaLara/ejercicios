using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Guitarra : InstrumentoMusical
    {
        public string instrumentoguit { get; set; }
        public virtual string Tocar()
        {
           return "Sonido de guitarra";
        }
    }
}
