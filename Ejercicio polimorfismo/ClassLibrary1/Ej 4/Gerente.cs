using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Gerente : Empleado
    {
        public string NombreGerente { get; set; }
        public double horas { get; set; }
        public double preciohora { get; set; }
        public virtual double CalcularSalario()
        {
            return horas * preciohora;
        }

    }
}
