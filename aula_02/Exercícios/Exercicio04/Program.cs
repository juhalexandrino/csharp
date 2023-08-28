namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, calculo;

            Console.Write("Digite o primeiro valor: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            calculo = (n1 * n2) - (n3 * n4);

            Console.WriteLine($"\nA diferença entre os valores é de {calculo:F2}.");
        }
    }
}