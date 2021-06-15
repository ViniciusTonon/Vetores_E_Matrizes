// Exercício 04 (Vetores) - Curso C# Prof. Nelio Alves.

// Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética
//  de todos elementos.Depois mostrar todos os elementos do vetor que estejam abaixo da média.

using System;
using System.Globalization;

namespace Vetores_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            double soma = 0.0;
            
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(valores[i],CultureInfo.InvariantCulture);
                soma = soma + vet[i];
            }

            double media = soma / N;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
