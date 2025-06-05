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
        protected List<Evento> eventos = new List<Evento>(); // Eventos a los que asiste un usuario

        // CONSTRUCTOR
        public Usuario(string nombre, string correo, string contrasenya)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.contrasenya = contrasenya;
        }

        // MÉTODOS
        // Método para añadir un evento a la lista de eventos del usuario, se debe llamar cuando el usuario se inscriba a un evento
        public void ParticiparEvento(Evento e)
        {
            eventos.Add(e);
        }
    }
}
