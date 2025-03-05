namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodos y metodos static

            //Console.WriteLine("Hello, World!");
            ////Instanciar una clase.
            //Calculadora calculadora = new Calculadora();
            //Console.WriteLine("Ingrese el primer numero");
            //double numero1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el segundo numero");
            //double numero2 = double.Parse(Console.ReadLine());
            //double resultado = calculadora.Sumar(numero1, numero2);
            //Console.WriteLine("La suma es {0}", resultado);

            ////Invocacion directa a traves de metodo static
            //double resultadoEstatico = CalculadoraStatica.SumarEstatico(numero1, numero2);
            ////double resultado = Calculadora.Sumar(numero1, numero2);
            //double otroResultado = CalculadoraStatica.SumarEstatico(numero1, numero2);


            //Manejo de errores.
            ManejoDeErrores manejoDeErrores = new ManejoDeErrores();

            //manejoDeErrores.SumaSinManejo();
            //Usando try-catch
            manejoDeErrores.SumaConManejo();

            Console.WriteLine("Fin del programa");
        }
    }
}
