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
            int maiorIdade = int.MinValue;
            int maiorIdadeN = 0;

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

            if (idade[0] > maiorIdade)
            {
                maiorIdade = idade[0];
                idade[0] = maiorIdadeN;
            }

            if (idade[1] > maiorIdade)
            {
                maiorIdade = idade[1];
                idade[1] = maiorIdadeN;
            }
            if (idade[2] > maiorIdade)
            {
                maiorIdade = idade[2];
                idade[2] = maiorIdadeN;
            }
            if (idade[3] > maiorIdade)
            {
                maiorIdade = idade[3];
                idade[3] = maiorIdadeN;
            }
            if (idade[4] > maiorIdade)
            {
                maiorIdade = idade[4];
                idade[4] = maiorIdadeN;
            }
            if (idade[5] > maiorIdade)
            {
                maiorIdade = idade[5];
                idade[5] = maiorIdadeN;
            }
            if (idade[6] > maiorIdade)
            {
                maiorIdade = idade[6];
                idade[6] = maiorIdadeN;
            }
            if (idade[7] > maiorIdade)
            {
                maiorIdade = idade[7];
                idade[7] = maiorIdadeN;
            }
            if (idade[8] > maiorIdade)
            {
                maiorIdade = idade[8];
                idade[8] = maiorIdadeN;
            }

            Console.WriteLine("Maior idade é: " + maiorIdade);

            

            
            
                
               
            



            
        }
    }
}
