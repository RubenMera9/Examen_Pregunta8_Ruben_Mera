using System;

namespace Paises
{
    // Definición de la interfaz IPais
    interface IPais
    {
        // Método para obtener los colores de la bandera
        string ColorBandera();

        // Método para obtener el tamaño del país
        string Tamaño();

        // Método para obtener el idioma oficial del país
        string IdiomaOficial();
    }

    // Clase Ecuador que implementa la interfaz IPais
    class Ecuador : IPais
    {
        // Implementación del método para obtener los colores de la bandera de Ecuador
        public string ColorBandera()
        {
            return "Amarillo, Azul y Rojo";
        }

        // Implementación del método para obtener el tamaño de Ecuador
        public string Tamaño()
        {
            return "283,561 km²";
        }

        // Implementación del método para obtener el idioma oficial de Ecuador
        public string IdiomaOficial()
        {
            return "Español";
        }
    }

    // Clase Brasil que implementa la interfaz IPais
    class Brasil : IPais
    {
        // Implementación del método para obtener los colores de la bandera de Brasil
        public string ColorBandera()
        {
            return "Verde, Amarillo, Azul y Blanco";
        }

        // Implementación del método para obtener el tamaño de Brasil
        public string Tamaño()
        {
            return "8,515,767 km²";
        }

        // Implementación del método para obtener el idioma oficial de Brasil
        public string IdiomaOficial()
        {
            return "Portugués";
        }
    }

    // Clase Andorra que implementa la interfaz IPais
    class Andorra : IPais
    {
        // Implementación del método para obtener los colores de la bandera de Andorra
        public string ColorBandera()
        {
            return "Azul, Amarillo y Rojo";
        }

        // Implementación del método para obtener el tamaño de Andorra
        public string Tamaño()
        {
            return "468 km²";
        }

        // Implementación del método para obtener el idioma oficial de Andorra
        public string IdiomaOficial()
        {
            return "Catalán";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creación de una instancia de la clase Ecuador
            Ecuador ecuador = new Ecuador();

            // Creación de una instancia de la clase Brasil
            Brasil brasil = new Brasil();

            // Creación de una instancia de la clase Andorra
            Andorra andorra = new Andorra();

            // Mostrar el color de la bandera de Ecuador
            Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());

            // Mostrar el tamaño de Andorra
            Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());

            // Mostrar el idioma oficial de Brasil
            Console.WriteLine("Idioma oficial de Brasil: " + brasil.IdiomaOficial());
        }
    }
}
