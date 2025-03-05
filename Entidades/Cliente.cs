using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Usuario
    {
        public Cliente(int codigo, string nombre, string email, string contrasena) : base (codigo, nombre, email, contrasena)
        {
            Console.WriteLine($"Soy el cliente {nombre}, email {email}");
        }
    }
}
