namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, calcularMedia;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            calcularMedia = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"\n {calcularMedia} é a média das notas");
        }
    }
}