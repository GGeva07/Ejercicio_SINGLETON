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
        private Administrador(int code, string name, string email, string pass, string depto) : base(code, name, email, pass, depto)
        {
            Console.WriteLine($"Soy el administrador: {name}, codigo: {code}, del departamento {depto} ");
        }

        public static Administrador GetAdmin(int code, string name, string email, string pass, string depto)
        {
            if(admin == null)
            {
                admin = new(code, name,email, pass, depto);
            }
            return admin;
        }
    }
}
