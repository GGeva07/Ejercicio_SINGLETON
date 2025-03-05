using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public class Proveedor
    {
        private int Codigo { get; set; }
        private string Nombre { get; set; }

        public Proveedor(int code, string name)
        {
            Codigo = code;
            Nombre = name;
            Console.WriteLine($"Soy el provedor {name}, codigo: {code}");
        }
    }
}
