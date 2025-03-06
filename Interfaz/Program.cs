using Entidades;
namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoComun empleado1 = new(1230003, "Eva Gonzalez", "evaGO07@HOTMAIL.COM", "E7112003" , "Software");
            Console.WriteLine("");
            Cliente cliente = new(50220, "Maria Abreu", "mariita@gmail.com", "5203ss");
            Console.WriteLine("");
            Proveedor provedor = new(51646, "Marlen Abreu", "marleen@gmail.com", "awa456");
            Console.WriteLine("");
            Administrador admin1 = Administrador.GetAdmin(5682005, "Daniel Castro", "Francisco@gmail.com", "26042005", "Software");
            Administrador admin = Administrador.GetAdmin(1230003, "Eva Gonzalez", "evaGO07@HOTMAIL.COM", "E7112003", "Software");
        }
    }
}
