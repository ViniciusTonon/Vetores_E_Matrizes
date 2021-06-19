// Exercício 01 (Matrizes) - Curso C# Prof. Nelio Alves.

// Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo.
// Em seguida, mostrar na tela somente os números negativos da matriz.


using System;

namespace Matrizes_01 {

    class Program {
        static void Main(string[] args) {

            int M, N;
            string[] valores1 = Console.ReadLine().Split(' ');

            M = int.Parse(valores1[0]);
            N = int.Parse(valores1[1]);

            int[,] Mat = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] valores2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    Mat[i, j] = int.Parse(valores2[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (Mat[i, j] < 0) {
                        Console.WriteLine(Mat[i, j]);
                    }
                }
            }
        }
    }
}
