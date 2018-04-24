using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exercicio04
    {
        public Exercicio04()
        {

            string[] diciplina = new string[1];
            double[] nota = new double[4];


            Console.WriteLine("Nome da disciplina: ");
            diciplina[0] = Console.ReadLine();

            Console.WriteLine("\nNome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nNota 01: ");
            nota[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            nota[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            nota[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            nota[3] = Convert.ToDouble(Console.ReadLine());


            double soma = nota[0] + nota[1] + nota[2] + nota[3];
            double media = (soma) / 4;

            Console.WriteLine("\nA média do aluno {0} é de: {1}", nome, media);

        }
    }
}
