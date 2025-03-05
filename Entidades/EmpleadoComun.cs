using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoComun : Empleado
    {
        public EmpleadoComun(int code, string name, string email, string pass, string depto) : base(code, name, email, pass, depto)
        {
            Console.WriteLine($"Soy el Empleado: {name}, codigo: {code}, del departamento {depto} ");
        }
    }
}
