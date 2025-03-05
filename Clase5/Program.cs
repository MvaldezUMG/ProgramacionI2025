namespace Clase5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DecisionSwitch();
            //OperadorTernario();
            //WhileLoop();
            //ForLoop();
            //DoWhileLoop();
            //EjemploBreak();
            EjemploContinue();
            
        }

        static void DecisionSwitch()
        {
            Console.WriteLine("Ingrese su elección (piedra, papel o tijera");
            string piedraPapelOTijera = Console.ReadLine();

            switch (piedraPapelOTijera)
            {
                case "piedra":
                    Mensaje("Ha elegido piedra");
                    break;
                case "papel":
                    Console.WriteLine("Ha elegido papel");
                    break;
                case "tijera":
                    Console.WriteLine("Ha elegido tijera");
                    break;
                default:
                    Console.WriteLine("No conocemos tu eleccion");
                    break;
            }
        }
        static void Mensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        /// <summary>
        /// Este metodo pide una temperatura por consola,
        /// si es menor a 15 grados escribe frio
        /// si es mayor o igual a 15 grados escribe calido
        /// </summary>
        static void OperadorTernario() {
            string descripcionTemperatura = "";
            Console.WriteLine("Ingrese la temperatura");
            int temperatura = int.Parse(Console.ReadLine());
            // Usando if else
            if (temperatura < 15)
            {
                descripcionTemperatura = "frio";
            }
            else if (temperatura >= 15) {
                descripcionTemperatura = "calido";
            }
            Console.WriteLine(descripcionTemperatura);
            //Usando operador ternario
            descripcionTemperatura = temperatura < 15 ? "frio" : "calido";
            Console.WriteLine(descripcionTemperatura);

        }

        static void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) {
                    Console.WriteLine("El numero es par");
                }
                else
                {
                    Console.WriteLine("El numero es impar");
                }
                Console.WriteLine(i);

            }
        }

        static void WhileLoop()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void DoWhileLoop()
        {
            int num;
            do
            {
                Console.WriteLine("Ingrese un numero positivo");
                num = int.Parse(Console.ReadLine());
            } while (num <= 0);
            Console.WriteLine("El numero ingresado es " + num);
        }

        static void EjemploBreak()
        {
            for (int i=0; i <10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("El bucle ha sido detenido");
        }
        static void EjemploContinue()
        {
            for (int i = 1; i <=10; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
