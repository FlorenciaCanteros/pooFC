using System;

namespace pooFC
{
    public class Colores
    {
        /// <summary>
        /// Asigna color a las letras.
        /// </summary>
        /// <param name="color">cambia el color de las letras</param>
        public void ColorGenerico(string color)
        {
            switch (color)
            {
                case "rojo":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                default: Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
          
        }
    }
}
