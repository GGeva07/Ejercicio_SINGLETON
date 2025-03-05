using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    {
        private int Codigo { get; set; }

        private string Nombre { get; set; }

        private string Email { get; set; }

        private string Contrasenia { get; set; }

        public Usuario(int codigo, string nombre, string email, string contrasena)
        {
            Codigo = codigo;
            Nombre = nombre;
            Email = email;
            Contrasenia = contrasena;
        }
    }
}
