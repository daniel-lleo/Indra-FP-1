using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSostenibilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>();

            Usuario user = new Usuario("Max", "correo@prueba.com", "1234");
            Organizador org = new Organizador("James", "correo@organizador.com", "strongpassword");
            Categoria categoria1 = new Categoria("Taller");
            Categoria categoria2 = new Categoria("Conferencia");
            Evento evento = new Evento("Paz", DateTime.Parse("05/05/2025 10:00:00"), 120, "Valencia", categoria2);

            Console.ReadKey();
        }
    }
}
