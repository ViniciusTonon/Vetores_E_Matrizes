// Exercício 08 (Vetores) - Curso C# Prof. Nelio Alves.

// Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas.
// Fazer um programa que calcule e escreva:
// > a maior e a menor altura do grupo
// > a média de altura das mulheres
// > o número de homens

using System;
using System.Globalization;

namespace Vetores_08 {
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
                       
            double[] Altura = new double[N];
            char[] Sexo = new char[N];

            for (int i = 0; i < N; i++)
            {
                string[] Valores = Console.ReadLine().Split(' ');

                Altura[i] = double.Parse(Valores[0], CultureInfo.InvariantCulture);
                Sexo[i] = char.Parse(Valores[1]);
            }

            double Menor = Altura[0];
            double Maior = Altura[0];
            double SomaAlturaMulheres = 0.0;
            int TotalDeMulheres = 0;
            int TotalDeHomens = 0;

            for (int i = 0; i < N; i++)
            {
                if (Altura[i] < Menor)
                {
                    Menor = Altura[i];
                }
                if (Altura[i] > Maior)
                {
                    Maior = Altura[i];
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (Sexo[i] == 'F')
                {
                    TotalDeMulheres++;
                    SomaAlturaMulheres = SomaAlturaMulheres + Altura[i];
                }
                if (Sexo[i] == 'M')
                {
                    TotalDeHomens++;
                }
            }

            double MediaAlturaMulheres = SomaAlturaMulheres / TotalDeMulheres;

            Console.WriteLine("Menor altura = " + Menor.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + Maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media da altura das mulheres = " + MediaAlturaMulheres.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + TotalDeHomens);
        }
    }
}
