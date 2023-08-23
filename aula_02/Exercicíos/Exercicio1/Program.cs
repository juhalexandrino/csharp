namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novosalario;

            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            novosalario = salario + abono;

            Console.WriteLine("O novo salário é R$" + novosalario);
        }
    }
}