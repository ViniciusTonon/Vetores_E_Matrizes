// Exercício 04 (Matrizes) - Curso C# Prof. Nelio Alves.

// Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma
// dos elementos acima da diagonal principal.

using System;

namespace Matrizes_04 {
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
                for (int j = i + 1; j < N; j++) {
                    soma = soma + Mat[i, j];
                }
            }
            Console.WriteLine(soma);
        }
    }
}