// Exercício 03 (Vetores) - Curso C# Prof. Nelio Alves.

// Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde
// cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.


using System;

namespace Vetores_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                A[i] = int.Parse(valores[i]);
            }          

            valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                B[i] = int.Parse(valores[i]);
            }
                        
            for (int i = 0; i < N; i++) {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }
        }
    }
}
