using System;

namespace pooFC
{
    public class CuentaJoven : Cuenta
    {
        public CuentaJoven() { }

        public CuentaJoven(Persona titular, double cantidadDeDinero, int bonificacion) : base(titular, cantidadDeDinero)
        {
            Bonificacion = bonificacion;
        }

        private int bonificacion;

        public int Bonificacion
        {
            get { return bonificacion; }

            set { bonificacion = value; }
        }

        /// <summary>
        /// Válida que sea mayor a 18 y menor a 25 años.
        /// </summary>
        /// <param name="persona">Es un objeto de Cuenta</param>
        /// <returns></returns>
        public bool EsTitularValido(Cuenta persona)
        {
            if (persona.Titular.Edad >= 18 && persona.Titular.Edad < 25)
            {
                return true;
            }

            return false;

        }

        /// <summary>
        /// Resta dinero si es un titular valido.
        /// </summary>
        /// <param name="persona"> Es un objeto de cuenta</param>
        /// <param name="cantidad">Monto a retirar</param>
        /// <returns></returns>
        public double Retirar(Cuenta persona, double cantidad)
        {
            if (EsTitularValido(persona))
            {
                CantidadDeDinero = CantidadDeDinero - cantidad;
            }

            return CantidadDeDinero;

        }

        /// <summary>
        /// imprime en pantalla mensaje "cuenta joven" y la Bonificación.
        /// </summary>
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Cuenta joven con Bonificación: " + Bonificacion + "%");
        }

    }
}
