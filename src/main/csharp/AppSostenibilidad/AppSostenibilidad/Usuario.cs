using System;
using System.Collections.Generic;

namespace AppSostenibilidad
{
    class Usuario
    {
        // ATRIBUTOS
        protected string nombre;
        protected string correo;
        protected string contrasenya;
        protected List<Evento> eventos = new List<Evento>();

        // CONSTRUCTOR
        public Usuario(string nombre, string correo, string contrasenya)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.contrasenya = contrasenya;
        }

        // MÉTODOS
        public void ParticiparEvento(Evento e)
        {
            eventos.Add(e);
        }
    }
}
