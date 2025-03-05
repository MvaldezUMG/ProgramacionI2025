using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    internal class ManejoDeErrores
    {
        public void SumaSinManejo() {
            Console.WriteLine("Ingrese el primer numero");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("La suma es {0}", numero1 + numero2);           
        }

        public void SumaConManejo()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                double numero2 = double.Parse(Console.ReadLine());
                Console.WriteLine("La suma es {0}", numero1 + numero2);
            }
            catch (Exception ex) { 
            Console.WriteLine("Ocurrio un error al ejecutar el programa " + ex.Message);
            }
        }
    }
}
