using System;

namespace AppSostenibilidad
{
    class Categoria
    {
        // ATRIBUTOS
        private string nombre;

        // CONSTRUCTOR
        public Categoria(string nombre)
        {
            this.nombre = nombre;
        }

        public Categoria() { }

        // MÉTODOS
        public Categoria SeleccionarCategoria()
        {
            string tipo = null;
            Console.WriteLine("Categorías disponibles:");
            Console.WriteLine("1. Conferencia");
            Console.WriteLine("2. Taller");
            Console.Write("Seleccione el tipo de categoría:");
            tipo = Console.ReadLine();

            while (tipo != "1" && tipo != "2")
            {
                Console.Write("Categoría incorrecta, seleccione una categoría existente:");
                tipo = Console.ReadLine();
            }

            switch (tipo)
            {
                case "1":
                    tipo = "Conferencia";
                    break;
                case "2":
                    tipo = "Taller";
                    break;
                default:
                    tipo = "Otro";
                    Console.WriteLine("Categoría incorrecta.");
                    break;
            }

            Categoria categoria = new Categoria(tipo);
            return categoria;
        }
    }
}
