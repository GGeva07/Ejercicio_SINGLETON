using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empleado
    {
        private string Codigo { get; set; }
        private string Nombre { get; set; }
        private int Constrasena { get; set; }
        private string Departamento { get; set; }

        public Empleado(string code, string name, int pass, string depto)
        {
            Codigo = code;
            Nombre = name;
            Constrasena = pass;
            Departamento = depto;
        }
    }
}
