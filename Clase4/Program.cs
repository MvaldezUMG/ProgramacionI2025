namespace Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decisiones();
        }

        public static void Decisiones() {

            Console.WriteLine("Por favor ingresa la temperatura:");
            string temperaturaEnTexto = Console.ReadLine();

            int temperatura = 0;
            bool conversionExitosa = int.TryParse(temperaturaEnTexto, out temperatura);

            if (!conversionExitosa)
            {
                Console.WriteLine("La temperatura no se pudo convertir");
                return;
            }

            if (temperatura < 20)
            {
                Console.WriteLine("Abrigate");
            }
            if (temperatura == 20)
            {
                Console.WriteLine("Vistete comodo");
            }
            if (temperatura > 20)
            {
                Console.WriteLine("Usa ropa bien liviana");
            }
            else
            {
                Console.WriteLine("Ya evaluamos antes");
            }
        }

        public static void IfAnidados() { 
            
        }
    }
}
