using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace AppSostenibilidad
{
    class Organizador : Usuario
    {
        // ATRIBUTOS
        private List<Evento> eventosCreados = new List<Evento>();

        // CONSTRUCTOR
        public Organizador(string nombre, string correo, string contrasenya) : base(nombre, correo, contrasenya) { }
    }
}
