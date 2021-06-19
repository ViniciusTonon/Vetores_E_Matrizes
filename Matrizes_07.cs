// Exercício 07 (Matrizes) - Curso C# Prof. Nelio Alves.

// O sargento Silva organiza seu pelotão em M filas numeradas a partir de 1, sendo cada fila com a mesma quantidade de
// soldados.Por exemplo, a figura abaixo mostra a organização do pelotão em 3 filas com 8 soldados em cada uma.

// Fila 1: * * * * * * * *
// Fila 2: * * * * * * * *
// Fila 3: * * * * * * * *

// Um dos exercícios que o sargento Silva realiza com o pelotão é o exercício "girar fila", que consiste em dizer o número
// de uma fila, de modo que os soldados desta fila devem se mover para a direita, e o último soldado da direita vai para a
// posição mais à esquerda. Você deve fazer um programa para ler a formação do pelotão e executar o exercício "girar fila".

using System;

namespace Matrizes_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,] Mat = new int[M, N];

            for (int i = 0; i<M; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j<N; j++) {
                    Mat[i, j] = int.Parse(valores[j]);                  
                }
            }

            int Fila = int.Parse(Console.ReadLine());
            Fila = Fila - 1;
            int ultimoDaFila = Mat[Fila, N - 1];
           
            for (int j = N - 1; j > 0; j--) {
                Mat[Fila, j] = Mat[Fila, j - 1];
            }

            Mat[Fila, 0] = ultimoDaFila;
                        
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(Mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
