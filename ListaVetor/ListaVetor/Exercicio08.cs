using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Exercicio08
    {
        public Exercicio08()
        {


            string[] aluno = new string[1];
            double[] notasPortugues = new double[4];
            double[] notasMatematica = new double[4];
            double[] notasIngles = new double[4];
            double[] notasBiologia = new double[4];
            double[] notasQuimica = new double[4];
            double[] notasFisica = new double[4];
            double[] notasSociologia = new double[4];
            double[] notasFilosofia = new double[4];
            double[] notasGeografia = new double[4];
            double[] notasHistoria = new double[4];
            double[] notasEdFisica = new double[4];


            Console.WriteLine("Nome do aluno: ");
            aluno[0] = Console.ReadLine();

            Console.WriteLine("\nMatéria de português: ");
            
            Console.WriteLine("\nNota 01: ");
            notasPortugues[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasPortugues[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasPortugues[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasPortugues[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de matemática: ");

            Console.WriteLine("\nNota 01: ");
            notasMatematica[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasMatematica[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasMatematica[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasMatematica[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de Inglês: ");

            Console.WriteLine("\nNota 01: ");
            notasIngles[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasIngles[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasIngles[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasIngles[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de biologia: ");

            Console.WriteLine("\nNota 01: ");
            notasBiologia[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasBiologia[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasBiologia[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasBiologia[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de química: ");

            Console.WriteLine("\nNota 01: ");
            notasQuimica[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasQuimica[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasQuimica[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasQuimica[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de física: ");

            Console.WriteLine("\nNota 01: ");
            notasFisica[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasFisica[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasFisica[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasFisica[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de sociologia: ");

            Console.WriteLine("\nNota 01: ");
            notasSociologia[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasSociologia[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasSociologia[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasSociologia[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de filosofia: ");

            Console.WriteLine("\nNota 01: ");
            notasFilosofia[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasFilosofia[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasFilosofia[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasFilosofia[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de geografia: ");

            Console.WriteLine("\nNota 01: ");
            notasGeografia[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasGeografia[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasGeografia[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasGeografia[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de história: ");

            Console.WriteLine("\nNota 01: ");
            notasHistoria[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasHistoria[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasHistoria[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasHistoria[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\nMatéria de Educação Física: ");

            Console.WriteLine("\nNota 01: ");
            notasEdFisica[0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 02: ");
            notasEdFisica[1] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 03: ");
            notasEdFisica[2] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 04: ");
            notasEdFisica[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            double mediaPT = (notasPortugues[0] + notasPortugues[1] + notasPortugues[2] + notasPortugues[3])/4;
            
            double mediaMAT = (notasMatematica[0] + notasMatematica[1] + notasMatematica[2] + notasMatematica[3])/4;
            
            double mediaIng = (notasIngles[0] + notasIngles[1] + notasIngles[2] + notasIngles[3])/4;
            
            double mediaBio = (notasBiologia[0] + notasBiologia[1] + notasBiologia[2] + notasBiologia [3])/4;
            
            double mediaQui = (notasQuimica[0] + notasQuimica[1] + notasQuimica[2] + notasQuimica[3])/4;
            
            double mediaFis = (notasFisica[0] + notasFisica[1] + notasFisica[2] + notasFisica[3])/4;
            
            double mediaSoc = (notasSociologia[0] + notasSociologia[1] + notasSociologia[2] + notasSociologia[3])/4;
            
            double mediaFil = (notasFilosofia[0] + notasFilosofia[1] + notasFilosofia[2] + notasFilosofia[3])/4;
            
            double mediaGeo = (notasGeografia[0] + notasGeografia[1] + notasGeografia[2] + notasGeografia[3])/4;
            
            double mediaHis = (notasHistoria[0] + notasHistoria[1] + notasHistoria[2] + notasHistoria[3])/4;

            double mediaEfi = (notasEdFisica[0] + notasEdFisica[1] + notasEdFisica[2] + notasEdFisica[3])/4;
        }
    }
}
