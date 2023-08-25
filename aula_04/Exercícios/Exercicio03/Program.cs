namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, menor21 = 0, maior50 = 0;

            while (idade >= 0)
            {
                Console.Write("Digite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade <= 20 && idade > 0)
                    menor21++;

                if (idade > 50)
                    maior50++;
            }

            Console.WriteLine($"Total de pessoas menores de 21 anos: {menor21}");
            Console.WriteLine($"Total de pessoas maiores de 50 anos: {maior50}");
        }
    }
}