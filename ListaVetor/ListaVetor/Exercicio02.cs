using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exercicio02
    {
        public Exercicio02()
        {
            string[] nomes = new string[10];

            Console.WriteLine("Nome 1: ");
            nomes[0] = Console.ReadLine();

            Console.WriteLine("Nome 2: ");
            nomes[1] = Console.ReadLine();

            Console.WriteLine("Nome 3: ");
            nomes[2] = Console.ReadLine();

            Console.WriteLine("Nome 4: ");
            nomes[3] = Console.ReadLine();

            Console.WriteLine("Nome 5: ");
            nomes[4] = Console.ReadLine();

            Console.WriteLine("Nome 6: ");
            nomes[5] = Console.ReadLine();

            Console.WriteLine("Nome 7: ");
            nomes[6] = Console.ReadLine();

            Console.WriteLine("Nome 8: ");
            nomes[7] = Console.ReadLine();

            Console.WriteLine("Nome 9: ");
            nomes[8] = Console.ReadLine();

            Console.WriteLine("Nome 10: ");
            nomes[9] = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Nome 1: {0} ", nomes[0]);
            Console.WriteLine("Nome 2: {0} ", nomes[1]);
            Console.WriteLine("Nome 3: {0} ", nomes[2]);
            Console.WriteLine("Nome 4: {0} ", nomes[3]);
            Console.WriteLine("Nome 5: {0} ", nomes[4]);
            Console.WriteLine("Nome 6: {0} ", nomes[5]);
            Console.WriteLine("Nome 7: {0} ", nomes[6]);
            Console.WriteLine("Nome 8: {0} ", nomes[7]);
            Console.WriteLine("Nome 9: {0} ", nomes[8]);
            Console.WriteLine("Nome 10: {0} ", nomes[9]);

        }
    }
}
