namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, calcularMedia;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            calcularMedia = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"\n{calcularMedia} é a média das notas.");
        }
    }
}