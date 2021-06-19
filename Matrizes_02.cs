// Exercício 02 (Matrizes) - Curso C# Prof. Nelio Alves.

// Ler um número N e depois uma matriz quadrada NxN com números inteiros.
// Depois, mostrar na tela a soma dos elementos de cada linha da matriz.

using System;

namespace Matrizes_02 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int[,] Mat = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    Mat[i, j] = int.Parse(valores[j]);
                }
            }

            int soma = 0;

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    soma = soma + Mat[i, j];
                }
                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}
