using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exercicio03
    {
        public Exercicio03()
        {
            string[] nomeProduto = new string[7];
            double[] preco = new double[7];

            Console.WriteLine("Nome do primeiro produto: ");
            nomeProduto[0] = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNome do segundo produto: ");
            nomeProduto[1] = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNome do terceiro produto: ");
            nomeProduto[2] = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNome do quarto produto: ");
            nomeProduto[3] = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNome do quinto produto: ");
            nomeProduto[4] = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNome do sexto produto: ");
            nomeProduto[5] = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco[5] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNome do sétimo produto: ");
            nomeProduto[6] = Console.ReadLine();
            Console.WriteLine("Preço: ");
            preco[6] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("O primeiro produto é {0} com o preço de: {1}", nomeProduto[0], preco[0]);
            Console.WriteLine("\nO segundo produto é {0} com o preço de: {1}", nomeProduto[1], preco[1]);
            Console.WriteLine("\nO terceiro produto é {0} com o preço de: {1}", nomeProduto[2], preco[2]);
            Console.WriteLine("\nO quarto produto é {0} com o preço de: {1}", nomeProduto[3], preco[3]);
            Console.WriteLine("\nO quinto produto é {0} com o preço de: {1}", nomeProduto[4], preco[4]);
            Console.WriteLine("\nO sexto produto é {0} com o preço de: {1}", nomeProduto[5], preco[5]);
            Console.WriteLine("\nO sétimo produto é {0} com o preço de: {1}", nomeProduto[6], preco[6]);
        }
    }
}
