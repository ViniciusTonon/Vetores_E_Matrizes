// Exercício 09 (Vetores) - Curso C# Prof. Nelio Alves.

// Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa.
// Para isto, mandou digitar um conjunto de N mercadorias, cada uma contendo nome, preço de
// compra e preço de venda das mesmas. Fazer um programa que leia tais dados e determine e
// escreva quantas mercadorias proporcionaram:
// lucro < 10 %
// 10 % ≤ lucro ≤ 20 %
// lucro > 20 %
// Determine e escreva também o valor total de compra e de venda de todas as mercadorias,
// assim como o lucro total.

using System;
using System.Globalization;

namespace Vetores_09 {
    class Program {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            string[] Nomes = new string[N];
            double[] PrecoCompra = new double[N];
            double[] PrecoVenda = new double[N];

            for (int i = 0; i < N; i++) {

                string[] Valores = Console.ReadLine().Split(' ');

                Nomes[i] = Valores[0];
                PrecoCompra[i] = double.Parse(Valores[1], CultureInfo.InvariantCulture);
                PrecoVenda[i] = double.Parse(Valores[2], CultureInfo.InvariantCulture);
            }

            double[] Lucro = new double[N];
            int LucroMenorQue10 = 0;
            int LucroEntre10a20 = 0;
            int LucroMaiorQue20 = 0;

            for (int i = 0; i < N; i++) {
                Lucro[i] = (PrecoVenda[i] - PrecoCompra[i]) / PrecoCompra[i];
                if (Lucro[i] < 0.1) {
                    LucroMenorQue10++;
                }
                else if (Lucro[i] < 0.2) {
                    LucroEntre10a20++;
                }
                else {
                    LucroMaiorQue20++;
                }                                            
            }

            double TotalCompra = 0;
            double TotalVenda = 0;
            double TotalLucro = 0;

            for (int i = 0; i < N; i++)
            {
                TotalCompra = TotalCompra + PrecoCompra[i];
                TotalVenda = TotalVenda + PrecoVenda[i];
            }

            TotalLucro = TotalVenda - TotalCompra;

            Console.WriteLine("Lucro abaixo de 10 %: " + LucroMenorQue10);
            Console.WriteLine("Lucro entre 10 % e 20 %: " + LucroEntre10a20);
            Console.WriteLine("Lucro acima de 20 %: " + LucroMaiorQue20);
            Console.WriteLine("Valor total de compra: " + TotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de vendaa: " + TotalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro Total: " + TotalLucro.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
