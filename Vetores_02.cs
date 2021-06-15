// Exercício 02 (Vetores) - Curso C# Prof. Nelio Alves.

// Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
// Todos os números pares e a quantidade de números pares

using System;

namespace Vetores_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int [] vet = new int[N];

            string[] valores = Console.ReadLine().Split(' ');

            int cont = 0;

            for (int i = 0; i < N; i++) {
                vet[i] = int.Parse(valores[i]);

                if (vet[i] % 2 == 0) {
                    Console.Write(vet[i] + " ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);
        }
    }
}
