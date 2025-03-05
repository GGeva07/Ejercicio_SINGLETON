using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Proveedor : Usuario
    {
        public Proveedor(int codigo, string nombre, string email, string contrasena) : base(codigo, nombre, email, contrasena)
        {
            Console.WriteLine($"Soy el Proveedor: {nombre}, email {email}");
        }
    }
}
