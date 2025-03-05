using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {
        private static Administrador? admin;
        private Administrador(string code, string name, int pass, string depto) : base(code, name, pass, depto)
        {
            Console.WriteLine($"Soy el administrador: {name}, codigo: {code}, del departamento {depto} ");
        }

        public static Administrador GetAdmin(string code, string name, int pass, string depto)
        {
            if(admin == null)
            {
                admin = new(code, name, pass, depto);
            }
            return admin;
        }
    }
}
