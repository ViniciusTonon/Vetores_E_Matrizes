// Exercício 06 (Matrizes) - Curso C# Prof. Nelio Alves.

// Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida,
// fazer as seguintes ações:

// a) calcular e imprimir a soma de todos os elementos positivos da matriz.
// b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir
// todos os elementos desta linha.
// c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir
// todos os elementos desta coluna.
// d) imprimir os elementos da diagonal principal da matriz.
// e) alterar a matriz elevando ao quadrado todos os números negativos da mesma.
// Em seguida imprimir a matriz alterada.

using System;
using System.Globalization;

namespace Matrizes_06 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double[,] Mat = new double[N, N];

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    Mat[i, j] = double.Parse(valores[j],CultureInfo.InvariantCulture);
                }
            }

            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (Mat[i, j] > 0.0) {
                        soma = soma + Mat[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            int linha = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++) {
                Console.Write(Mat[linha, j].ToString("F2", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            int coluna = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(Mat[i, coluna].ToString("F2",CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (i == j) {
                        Console.Write(Mat[i, j].ToString("F2", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (Mat[i, j] < 0.0) {
                        Mat[i, j] = Math.Pow(Mat[i,j], 2.0);
                    }
                }
            }
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(Mat[i, j].ToString("F2",CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
