using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Animal
    {
            
        //estas son propiedades
        public string Nombre { get; set; }

        //esto es un método
        public virtual string Sonido()

        { 
            return Nombre;
        }

    }
}

