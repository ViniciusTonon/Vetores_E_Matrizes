// Exercício 07 (Vetores) - Curso C# Prof. Nelio Alves.

// Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres.
// Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
// considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.

using System;
using System.Globalization;

namespace Vetores_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] Nomes = new string[N];
            double[] Nota01 = new double[N];
            double[] Nota02 = new double[N];
            double[] Media = new double[N];
                                
            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                Nomes[i] = valores[0];
                Nota01[i] = double.Parse(valores[1]);
                Nota02[i] = double.Parse(valores[2]);

                Media[i] = (Nota01[i] + Nota02[i]) / 2.0;
            }

            Console.WriteLine("Alunos aprovados:");

            for (int i = 0; i < N; i++) {
               if (Media[i] >= 6.0) {
                    Console.WriteLine(Nomes[i]);
                }
            }
        }
    }
}
