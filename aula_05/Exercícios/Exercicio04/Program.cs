namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matrizAlunos = new float[10, 4];
            float[] vetorSoma = new float[10];
            float soma = 0;
            
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++){
                    Console.Write($"Digite as notas do {linha + 1}° aluno: ");
                    matrizAlunos[linha, coluna] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int linha = 0; linha < 10; linha++){
                for (int coluna = 0; coluna < 4; coluna++){
                    soma += matrizAlunos[linha, coluna];
                }

                vetorSoma[linha] = soma;
                soma = 0;
            }

            Console.WriteLine();

            for (int linha = 0; linha < 10; linha++){
                Console.Write($"{vetorSoma[linha] / 4:F2} | ");
            }
        }
    }
}