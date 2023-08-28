namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNoturno, horasExtras, desconto, salarioLiquido;

            Console.Write("Digite o salário bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o adicional noturno: ");
            adicionalNoturno = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite as horas extras: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o desconto: ");
            desconto = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - desconto;

            Console.WriteLine($"\nO salário liquído é de R${salarioLiquido:F2}");
        }
    }
}