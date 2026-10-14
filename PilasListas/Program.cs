using System.ComponentModel.DataAnnotations.Schema;

namespace PilasListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilas pila = new Pilas();  

            pila.Agregar(" A ");
            pila.Agregar(" B ");
            pila.Agregar(" C ");
            pila.Agregar(" D ");

            Console.WriteLine(pila.ObtenerDatos());

            pila.Agregar(" E ");
            Console.WriteLine(pila.ObtenerDatos());

            pila.Eliminar();
            Console.WriteLine(pila.ObtenerDatos());
        }
    }
}
