using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int codigo { get; set; }

        private string nombre { get; set; }
        public Cliente(int code, string name)
        {
            codigo = code;
            nombre = name;
            Console.WriteLine($"Soy el cliente {name}, codigo: {code}");
        }
    }
}
