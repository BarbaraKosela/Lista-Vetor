using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exercicio01
    {
        public Exercicio01()
        {
            int[] numero = new int[16];

            Console.Write("Número 1: ");
            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            numero[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 3: ");
            numero[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 4: ");
            numero[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 5: ");
            numero[4] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 6: ");
            numero[5] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 7: ");
            numero[6] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 8: ");
            numero[7] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 9: ");
            numero[8] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 10: ");
            numero[9] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 11: ");
            numero[10] = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Número 12: ");
            numero[11] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 13: ");
            numero[12] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 14: ");
            numero[13] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 15: ");
            numero[14] = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Número 16: ");
            numero[15] = Convert.ToInt32(Console.ReadLine());

            double soma = numero[0] + numero[1] + numero[2] + numero[3] + numero[4] + numero[5] + numero[6] + numero[7] +
                numero[8] + numero[9] + numero[10] + numero[11] + numero[12] + numero[13] + numero[14] + numero[15];
            
            Console.WriteLine("A soma destes números é de: " + soma);
        }
    }
}
