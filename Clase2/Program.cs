using Calculadora;

namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Clase2_1.OtraClase otraClase = new Clase2_1.OtraClase();
            otraClase.Saludar();

            //Inferencia de tipos
            var mensaje = "Hola";
            //Definiendo tipos
            string otroMensaje = "Hola";
            var entero = 30;

            mensaje = "Otro mensaje";

            const double IVA = 0.12;
            //IVA = 0.13;

            //Imprimir en pantalla
            Console.WriteLine("Imprimiendo");

            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        }
    }
}
