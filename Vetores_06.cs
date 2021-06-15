// Exercício 06 (Vetores) - Curso C# Prof. Nelio Alves.

// Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois,
// mostrar na tela o nome da pessoa mais velha.

using System;

namespace Vetores_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            int IdadeMaior = idades[0];
            int PosicaoMaiorIdade = 0;

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);

                if (idades[i] > IdadeMaior) {
                    IdadeMaior = idades[i];
                    PosicaoMaiorIdade = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[PosicaoMaiorIdade]);               
        }
    }
}
