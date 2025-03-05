using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmpleadoComun : Empleado
    {
        public EmpleadoComun(string code, string name, int pass, string depto) : base(code, name, pass, depto)
        {
            Console.WriteLine($"Soy el empleado: {name}, codigo: {code}, del departamento {depto} ");
        }
    }
}
