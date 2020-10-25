
using System;

namespace Full_GRASP_And_SOLID.Library
{
    /*
        La clase ConsolePrinter cumple con el principio SRP, pues su única responsabilidad
        es la de imprimir por pantalla el texto que se le provea.
    */
    public class ConsolePrinter : IPrinter
    {
        public void Print(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }
    }
}