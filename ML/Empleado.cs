using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Sueldo_Diario { get; set; }
        public decimal Sueldo_Total { get; set; }
        public int Dias_Trabajados { get; set; }
        public List<object> Empleados { get; set; }
    }
}
