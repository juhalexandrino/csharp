namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int numerosVetor;
            float soma = 0, media = 0;

            for (numerosVetor = 0; numerosVetor < vetor.Length; numerosVetor++)
            {
                Console.Write($"Digite {numerosVetor}º números inteiros: ");
                vetor[numerosVetor] = Convert.ToInt32(Console.ReadLine());
            }

            soma += vetor[numerosVetor];

            Console.Write("\nElementos nos índices ímpares: ");
            for (numerosVetor = 0; numerosVetor < vetor.Length; numerosVetor++)
            {
                if (vetor[numerosVetor] % 2 == 1)
                {
                    Console.Write($"{vetor[numerosVetor]}");
                }

                Console.Write("\nElementos nos índices pares: ");
                for (numerosVetor = 0; numerosVetor < vetor.Length; numerosVetor++)
                {
                    if (vetor[numerosVetor] % 2 == 0)
                    {
                        Console.Write($"{vetor[numerosVetor]}");
                    }
                }

                media = soma / vetor.Length;

            }
        }
    }
}