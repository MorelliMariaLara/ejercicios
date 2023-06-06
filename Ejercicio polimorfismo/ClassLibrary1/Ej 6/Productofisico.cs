using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Ej_6
{
    public class Productofisico : Producto
    {
        public decimal peso { get; set; }

        public Productofisico(decimal peso, string nombre,
            decimal precio) : base(nombre, precio)
        {
            peso = peso;
        }
        public override decimal CalcularImpuesto()
        {
            return Precio * 0.1m;

        }
        public override decimal CalcularTotal()
        {
            return Precio + CalcularImpuesto();
        }
    }

}
