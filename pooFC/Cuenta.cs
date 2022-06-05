using System;

namespace pooFC
{
    public class Cuenta 
    {
        private Persona titular;

        private double cantidadDeDinero;

        public Persona Titular
        {
            get { return titular; }

            set { titular = value; }
        }

        public double CantidadDeDinero
        {
            get { return cantidadDeDinero; }

            set { cantidadDeDinero = value; }
        }

        public Cuenta() { }

        public Cuenta(Persona titular, double cantidadDeDinero)
        {
            Titular = titular;
            CantidadDeDinero = cantidadDeDinero;
        }

        /// <summary>
        /// Imprime en pantalla los datos de la cuenta.
        /// </summary>
        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre: " + Titular.Nombre + ", Dni: " + Titular.Dni + ", Cantidad De Dinero en cuenta: " + CantidadDeDinero);
            Console.WriteLine();
        }

        /// <summary>
        /// cargo dinero si es mayor a 0.
        /// </summary>
        /// <param name="cantidad"> monto a depositar.</param>
        public double Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                CantidadDeDinero = CantidadDeDinero + cantidad;
            }

            return CantidadDeDinero;
        }

        /// <summary>
        /// Resta dinero.
        /// </summary>
        /// <param name="cantidad">monto a retirar.</param>
        /// <returns></returns>
        public virtual double Retirar(double cantidad)
        {

            return CantidadDeDinero =  CantidadDeDinero -cantidad;

        }
    }
}
