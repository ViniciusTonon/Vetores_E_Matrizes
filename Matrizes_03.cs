// Exercício 03 (Matrizes) - Curso C# Prof. Nelio Alves.

// Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior
// elemento de cada linha. Suponha não haver empates.

using System;

namespace Matrizes_03 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int[,] Mat = new int[N, N];

            for (int i = 0; i<N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j<N; j++) {
                    Mat[i, j] = int.Parse(valores[j]);
                }
            }

            int maior = 0;

            for (int i = 0; i < N; i++) {                
                for (int j = 0; j < N; j++) {
                    if (Mat[i,j] > maior) {
                        maior = Mat[i, j];
                    }                    
                }
                Console.WriteLine(maior);
                maior = 0;
            }
        }
    }
}
