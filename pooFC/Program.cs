using System;

namespace pooFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Florencia", 38010262, 30);
            Persona persona2 = new Persona("Nicole", 40010232, 18);

            Cuenta cuentaNormal = new Cuenta(persona1, 40200);
            CuentaJoven cuentaJoven = new CuentaJoven(persona2, 20100, 10);

            Colores color = new Colores();

            color.ColorGenerico("cyan");
            Console.WriteLine("Datos de cuenta :  ");
            color.ColorGenerico("");
            Console.WriteLine(" ");

            cuentaNormal.Mostrar();
            Console.Write("Ingrese un monto a depositar:");
            int montoIngresado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Se deposito: " + montoIngresado);
           
            color.ColorGenerico("verde");
            Console.WriteLine("Su nuevo monto es: " + cuentaNormal.Ingresar(montoIngresado));
            color.ColorGenerico("");

            Console.WriteLine(" ");
            Console.Write("Ingrese un monto a retirar:");
            int montoRetirado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Se Retiro: " + montoRetirado);

            double montoActual = cuentaNormal.Retirar(montoRetirado);

            if (montoActual >= 0)
            {       
                color.ColorGenerico("verde");
                Console.WriteLine("Su nuevo monto es: " + montoActual);
                color.ColorGenerico("");
            }
            else
            {
                color.ColorGenerico("rojo");
                Console.WriteLine("Su nuevo monto es: " + montoActual);
                color.ColorGenerico("");
            }

            color.ColorGenerico("cyan");
            Console.WriteLine("------------------------------------------ ");
            Console.WriteLine("Datos de cuenta joven:  ");
            color.ColorGenerico("");

            Console.WriteLine(" ");
            cuentaJoven.Mostrar();
            Console.WriteLine(" ");

            Console.Write("Ingrese un monto a retirar:");
            int montoARetirar = Convert.ToInt32(Console.ReadLine());
            double montoActualizado = cuentaJoven.Retirar(montoARetirar);
            Console.WriteLine("Se Retiro: " + montoARetirar);

            color.ColorGenerico("verde");
            Console.WriteLine("Su nuevo monto es: " + montoActualizado );
            color.ColorGenerico("");

            Console.WriteLine(" ");
            Console.Write("Ingrese un monto a depositar:");
            int ingresarMonto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Se deposito: " + ingresarMonto);
      
            color.ColorGenerico("verde");
            Console.WriteLine("Su nuevo monto es: " + cuentaJoven.Ingresar(ingresarMonto));
            color.ColorGenerico("");
           
        }
    }
}
