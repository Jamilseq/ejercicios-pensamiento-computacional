using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, resultado;
            Console.WriteLine("Ingrese el valor de x :");
            x = Convert.ToDouble(Console.ReadLine());
            resultado = (3 * Math.Pow(x, 2)) + (7 * x) - 15;
            Console.WriteLine("Resultado:{0}", resultado);
            Console.ReadLine();

        }
    }
}
