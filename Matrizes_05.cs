// Exercício 05 (Matrizes) - Curso C# Prof. Nelio Alves.

// Fazer um programa para ler duas matrizes de números inteiros A e B,
// contendo de M linhas e N colunas cada. Depois, gerar uma terceira
// matriz C onde cada elemento desta é a soma dos elementos correspondentes
// das matrizes originais. Imprimir na tela a matriz gerada.

using System;

namespace Matrizes_05 {
    class Program {
        static void Main(string[] args)
        {            
            string[] val = Console.ReadLine().Split(' ');
            int M = int.Parse(val[0]);
            int N = int.Parse(val[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(valores[j]);
                }
            }

            for (int i = 0; i < M; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    B[i, j] = int.Parse(valores[j]);
                }
            }

            int[,] C = new int[M, N];

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                   Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
