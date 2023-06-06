using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empleado

    {
        public string Adm { get; set; }
        public virtual double CalcularSalario()
        {
            return 19.00; 
        }

    }
}
