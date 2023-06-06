using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Ej_6
{
    public class Productodigital : Producto 
    {
        public  decimal tamaño  { get; set; }

        public Productodigital(decimal tamaño, string nombre,
            decimal precio): base (nombre, precio) 
        {
            tamaño = tamaño;
        }

        public override decimal CalcularImpuesto()
        {
            return Precio  * 0.5m;

        }
        public override decimal CalcularTotal()
        {
            return  Precio + CalcularImpuesto();
        }
    }
}
