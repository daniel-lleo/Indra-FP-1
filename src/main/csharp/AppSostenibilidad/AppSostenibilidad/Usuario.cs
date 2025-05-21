using System;
using System.Collections.Generic;

namespace AppSostenibilidad
{
    class Usuario
    {
        // ATRIBUTOS
        protected string nombre;
        protected string correo;
        protected List<Evento> eventos;

        // CONSTRUCTOR
        public Usuario(string nombre, string correo)
        {
            this.nombre = nombre;
            this.correo = correo;
        }

        // MÉTODOS
        public void ParticiparEvento(Evento e)
        {
            eventos.Add(e);
        }
    }
}
