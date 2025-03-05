using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empleado : Usuario
    {
        private string Departamento { get; set; }

        public Empleado(int code, string name, string email, string pass, string depto) : base (code, name, email, pass)
        {
            Departamento = depto;
        }
    }
}
