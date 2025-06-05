using System;
using System.Collections.Generic;

namespace AppSostenibilidad
{
    class Evento
    {
        // ATRIBUTOS
        private string nombre;
        private DateTime fecha;
        private double duracion;
        private string ubicacion;
        private List<Usuario> participantes = new List<Usuario>();
        private Categoria categoria;

        // CONSTRUCTOR
        public Evento(string nombre, DateTime fecha, double duracion, string ubicacion, Categoria categoria)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.duracion = duracion;
            this.ubicacion = ubicacion;
            this.categoria = categoria;
        }

        // MÉTODOS
        // Añade un usuario a la lista de participantes del evento, se debe llamar cuando un usuario participe en el evento
        public void AddParticipante(Usuario u)
        {
            participantes.Add(u);
        }
    }
}