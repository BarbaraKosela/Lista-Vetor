using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exercicio05
    {
        public Exercicio05()
        {
            double[] peso = new double[5];

            Console.WriteLine("Peso 01: ");
            peso[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPeso 02: ");
            peso[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPeso 03: ");
            peso[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPeso 04: ");
            peso[3] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPeso 05: ");
            peso[4] = Convert.ToDouble(Console.ReadLine());

            double soma = peso[0] + peso[1] + peso[2] + peso[3] + peso[4];
            double media = (soma) / 5;

            Console.WriteLine("A soma dos pesos foi de: " + soma);
            Console.WriteLine("A média dos pesos foi de: " + media);




        }
    }
}
