using System;

namespace Ejercicios
{
    class Ejer2
    {
        static void Main()
        {
            /*De acuerdo con la geometria de un triangulo se calcula aplicando la formula
              Area = Base * Altura / 2. Realice una rutina que determine el area de un triángulo dado*/
            float ba;
            float altura;
            float area;

            Console.WriteLine("Ingre la base del Triángulo:");
            ba = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingre la altura del Triángulo:");
            altura = float.Parse(Console.ReadLine());

            area = (ba * altura) / 2;

            Console.WriteLine("El área del triángulo es: {0}", area);

            Console.ReadLine();
        }
    }
}

// hola soy lady 