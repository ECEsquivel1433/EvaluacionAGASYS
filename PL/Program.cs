using BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int registros = 0;
            ML.Empleado empleado= new ML.Empleado();

            Console.WriteLine("Escriba el numero de empleados a registrar:");
            registros = int.Parse(Console.ReadLine());

            empleado.Empleados = new List<object>();
            for (int i = 1;i<= registros; i++ )
            {
                ML.Empleado empleadolist = new ML.Empleado();
                Console.WriteLine("Escriba el nombre del Empleado:" +i);
                empleadolist.Nombre = Console.ReadLine();
                Console.WriteLine("Apellido:");
                empleadolist.Apellido = Console.ReadLine();
                Console.WriteLine("Sueldo diario:");
                empleadolist.Sueldo_Diario = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Dias trabajados: ");
                empleadolist.Dias_Trabajados = int.Parse(Console.ReadLine());

                BL.Empleado.Calcula_Sueldo(empleadolist);

                empleado.Empleados.Add(empleadolist);
            }
            foreach (ML.Empleado empleadomostrar in empleado.Empleados)
            {
                Console.WriteLine(empleadomostrar.Nombre + " " + empleadomostrar.Apellido);
                Console.WriteLine("Sueldo Total : "+empleadomostrar.Sueldo_Total);
                Console.ReadKey();
            }
        }
    }
}
