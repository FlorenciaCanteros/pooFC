using System;

namespace pooFC
{
    public class Persona
    {
        private string nombre;

        private int edad;

        private int dni;

        public Persona() { }

        public Persona(string nombre, int dni, int edad)
        {
            Nombre = nombre;
            Dni = dni;
            Edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public int Dni
        {
            get { return dni; }

            set { dni = value; }
        }

        public int Edad
        {
            get { return edad; }

            set { edad = value; }
        }

        /// <summary>
        /// Muestra en consola los datos de una persona.
        /// </summary>
        public void Mostar()
        {
            Console.WriteLine("Nombre: " + Nombre + ", Dni: " + Dni + ", Edad: " + Edad);
            Console.WriteLine();
        }

        /// <summary>
        /// Devuelve si es mayor de edad.
        /// </summary>
        /// <param name="persona"> Es un objeto de tipo persona</param>
        /// <returns></returns>
        public bool EsMayorDeEdad(Persona persona)
        {
            if (persona.Edad >= 18)
            {
                return true;
            }

            return false;
        }

    }
}
