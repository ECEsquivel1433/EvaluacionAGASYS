using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empleado
    {
        
        public static ML.Empleado Calcula_Sueldo(ML.Empleado empleadolist)
        {
            empleadolist.Sueldo_Total = empleadolist.Dias_Trabajados * empleadolist.Sueldo_Diario;
            
            return empleadolist;
        }
    }
}
