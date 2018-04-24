using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int[] idade = new int[9];
            int maiorIdade = 0;

            Console.WriteLine("Idade 1: ");
            idade[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade 2: ");
            idade[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade 3: ");
            idade[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade 4: ");
            idade[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade 5: ");
            idade[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade 6: ");
            idade[5] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade 7: ");
            idade[6] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade 8: ");
            idade[7] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Idade 9: ");
            idade[8] = Convert.ToInt32(Console.ReadLine());

            if ((idade[0] > idade[1])&&(idade[0] > idade[2])&&(idade[0] > idade[3])&&(idade[0] > idade[4])&&(idade[0] > idade[5])&&(idade[0] > 
                idade[6])&&(idade[0] > idade[7])&&(idade[0] > idade[8]))
            {
                Console.WriteLine("Maior idade: " + idade[0]);
            }

            if ((idade[1] > idade[0]) && (idade[1] > idade[2]) && (idade[1] > idade[3]) && (idade[1] > idade[4]) && (idade[1] > idade[5]) && (idade[1] >
                idade[6]) && (idade[1] > idade[7]) && (idade[1] > idade[8]))
            {
                Console.WriteLine("Maior idade: " + idade[1]);
            }

            if ((idade[2] > idade[1]) && (idade[2] > idade[0]) && (idade[2] > idade[3]) && (idade[2] > idade[4]) && (idade[2] > idade[5]) && (idade[2] >
                idade[6]) && (idade[2] > idade[7]) && (idade[2] > idade[8]))
            {
                Console.WriteLine("Maior idade: " + idade[2]);
            }

            if ((idade[3] > idade[1]) && (idade[3] > idade[2]) && (idade[3] > idade[0]) && (idade[3] > idade[4]) && (idade[3] > idade[5]) && (idade[3] >
                idade[6]) && (idade[3] > idade[7]) && (idade[3] > idade[8]))
            {
                Console.WriteLine("Maior idade: " + idade[3]);
            }

            if ((idade[4] > idade[1]) && (idade[4] > idade[2]) && (idade[4] > idade[3]) && (idade[4] > idade[0]) && (idade[4] > idade[5]) && (idade[4] >
                idade[6]) && (idade[4] > idade[7]) && (idade[4] > idade[8]))
            {
                Console.WriteLine("Maior idade: " + idade[4]);
            }

            if ((idade[5] > idade[1]) && (idade[5] > idade[2]) && (idade[5] > idade[3]) && (idade[5] > idade[4]) && (idade[5] > idade[0]) && (idade[5] >
                idade[6]) && (idade[5] > idade[7]) && (idade[5] > idade[8]))
            {
                Console.WriteLine("Maior idade: " + idade[5]);
            }

            if ((idade[6] > idade[1]) && (idade[6] > idade[2]) && (idade[6] > idade[3]) && (idade[6] > idade[4]) && (idade[6] > idade[5]) && (idade[6] >
                idade[0]) && (idade[6] > idade[7]) && (idade[6] > idade[8]))
            {
                Console.WriteLine("Maior idade: " + idade[6]);
            }

            if ((idade[7] > idade[1]) && (idade[7] > idade[2]) && (idade[7] > idade[3]) && (idade[7] > idade[4]) && (idade[7] > idade[5]) && (idade[7] >
                idade[6]) && (idade[7] > idade[0]) && (idade[7] > idade[8]))
            {
                Console.WriteLine("Maior idade: " + idade[7]);
            }

            if ((idade[8] > idade[1]) && (idade[8] > idade[2]) && (idade[8] > idade[3]) && (idade[8] > idade[4]) && (idade[8] > idade[5]) && (idade[8] >
                idade[6]) && (idade[8] > idade[7]))
            {
                Console.WriteLine("Maior idade: " + idade[8]);
            }
            

            

            
            
                
               
            



            
        }
    }
}
