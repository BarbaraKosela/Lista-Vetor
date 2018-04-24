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
        }
    }
}
