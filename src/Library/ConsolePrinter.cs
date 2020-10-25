
using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }
    }
}