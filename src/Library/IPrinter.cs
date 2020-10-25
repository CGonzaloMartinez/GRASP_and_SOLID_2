

namespace Full_GRASP_And_SOLID.Library
{
    /*
        Se define la interfaz IPrinter para que cualquier clase que implemente esta interfaz
        pueda ser intercambiada con ConsolePrinter y permitir imprimir el texto sin afectar
        el codigo de ConsolePrinter(LSP).
        Tambien esta interfaz permite agregar nuevas maneras de imprimir sin modificar el 
        codigo ya existente, asi cumpliendo con el principio OCP.
    */
    public interface IPrinter
    {
        void Print(string textToPrint);
    }
}