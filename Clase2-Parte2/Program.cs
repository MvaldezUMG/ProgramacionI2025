using Calculadora;

namespace Clase2_Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es mi segundo programa de C#");
            CalculadoraDeGanancias calculadora = new CalculadoraDeGanancias();
            double ganancia = calculadora.Calcular(100);
            Console.WriteLine("Est fue lo que gane {0}", ganancia);
        }
    }
}
