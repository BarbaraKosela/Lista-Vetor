using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exercicio07
    {
        public Exercicio07()
        {
            double[] altura = new double[4];

            double menorAltura = double.MaxValue;
            double menorAlturaN = 0;



            Console.WriteLine("Altura animal 01: ");
            altura[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura do animal 02: ");
            altura[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura do animal 03: ");
            altura[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura do animal 04: ");
            altura[3] = Convert.ToDouble(Console.ReadLine());

            if (altura[0] < menorAltura)
            {
                menorAltura = altura[0];
                menorAlturaN = altura[0];

            }

            if (altura[1] < menorAltura)
            {
                menorAltura = altura[1];
                menorAlturaN = altura[1];

            }


            if (altura[2] < menorAltura)
            {
                menorAltura = altura[2];
                menorAlturaN = altura[2];
                

            }

            if (altura[3] < menorAltura)
            {
                menorAltura = altura[3];
                menorAlturaN = altura[3];
            }


            Console.WriteLine("A menor altura é: " + menorAlturaN);

        }
    }
}
