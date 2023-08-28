namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;

            Console.Write("Digite o salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = salario + abono;

            Console.WriteLine($"\nO novo salário é R${novoSalario:F2}");
        }
    }
}