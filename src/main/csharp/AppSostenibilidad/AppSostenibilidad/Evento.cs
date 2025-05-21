using System;
using System.Collections.Generic;

namespace AppSostenibilidad
{
    class Evento
    {
        // ATRIBUTOS
        private string nombre;
        private DateTime fecha;
        private string ubicacion;
        private List<Usuario> participantes;
        private Categoria categoria;

        // CONSTRUCTOR
        public Evento(string nombre, DateTime fecha, string ubicacion, Categoria categoria)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.ubicacion = ubicacion;
            this.categoria = categoria;
        }

        // MÉTODOS
        public void AddParticipante(Usuario u)
        {
            participantes.Add(u);
        }

        public void CancelarEvento()
        {
            nombre = null;
            ubicacion = null;
            categoria = null;
        }
    }
}
