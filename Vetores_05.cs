// Exercício 05 (Vetores) - Curso C# Prof. Nelio Alves.

// Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a
// média aritmética somente dos números pares lidos.


using System;
using System.Globalization;

namespace Vetores_05 { 
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];
            int cont = 0;
            int soma = 0;
            
            string[] valores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = int.Parse(valores[i]);

                if (vet[i] % 2 == 0) {
                    cont++;
                    soma = soma + vet[i];
                }
            }
            double media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
