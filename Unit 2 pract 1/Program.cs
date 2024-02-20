using System;

namespace Fisica
{
    // Clase que representa un objeto con masa y posición
    class Objeto
    {
        // Propiedades
        public double Masa { get; set; } // La masa en kilogramos
        public double X { get; set; } // La posición en el eje X en metros
        public double Y { get; set; } // La posición en el eje Y en metros

        // Constructor
        public Objeto(double masa, double x, double y)
        {
            Masa = masa;
            X = x;
            Y = y;
        }

        // Método que calcula la distancia entre este objeto y otro
        public double Distancia(Objeto otro)
        {
            // Usamos el teorema de Pitágoras
            return Math.Sqrt(Math.Pow(X - otro.X, 2) + Math.Pow(Y - otro.Y, 2));
        }
    }

    // Clase que representa la física del sistema
    class Fisica
    {
        // Constante gravitacional
        public const double G = 6.674e-11;

        // Método que calcula la fuerza gravitacional entre dos objetos
        public static double FuerzaGravitacional(Objeto o1, Objeto o2)
        {
            // Usamos la fórmula de la fuerza gravitacional
            return G * o1.Masa * o2.Masa / Math.Pow(o1.Distancia(o2), 2);
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos dos objetos con sus masas y posiciones
            Objeto o1 = new Objeto(10, 0, 0); // 10 kg en el origen
            Objeto o2 = new Objeto(20, 3, 4); // 20 kg en el punto (3, 4)

            // Calculamos la fuerza gravitacional entre ellos
            double fuerza = Fisica.FuerzaGravitacional(o1, o2);

            // Mostramos el resultado por consola
            Console.WriteLine("La fuerza gravitacional entre los objetos es {0} N", fuerza);
        }
    }
}

