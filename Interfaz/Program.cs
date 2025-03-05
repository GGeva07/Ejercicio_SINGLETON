using Entidades;
namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoComun empleado1 = new EmpleadoComun("123E20003", "Eva Gonzalez",123456 , "Software");
            Console.WriteLine("");
            Cliente cliente = new(1234, "Maria");
            Console.WriteLine("");
            Proveedor provedor = new(456, "Marlen");
            Console.WriteLine("");

            Administrador admin = Administrador.GetAdmin("153D2005", "Daniel Castro", 456789, "Software");
            Administrador admin1 = Administrador.GetAdmin("D2005", "Daniel", 459, "Sof");
        }
    }
}
