using System;
using System.Collections.Generic;

namespace AppSostenibilidad
{
    class Organizador : Usuario
    {
        // ATRIBUTOS
        private List<Evento> eventosCreados;

        // CONSTRUCTOR
        public Organizador(string nombre, string correo) : base(nombre, correo) {  }

        // MÉTODOS
        public Evento CrearEvento()
        {
            Evento e;
            string nombre, ubicacion;
            Categoria categoria = new Categoria();
            DateTime fecha;

            Console.Write("Introduzca el nombre del evento: ");
            nombre = Console.ReadLine();
            Console.Write("Introduzca la fecha del evento: ");
            fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("Introduzca la ubicación del evento: ");
            ubicacion = Console.ReadLine();
            Console.Write("Introduzca la categoría del evento: ");
            categoria = categoria.SeleccionarCategoria();

            e = new Evento(nombre, fecha, ubicacion, categoria);
            return e;
        }
    }
}
