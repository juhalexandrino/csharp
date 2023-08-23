namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNoturno, horasExtras, desconto, salarioLiquido;

            Console.WriteLine("Digite o sálario bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o adicional noturno: ");
            adicionalNoturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite as horas extras: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o desconto: ");
            desconto = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - desconto;

            Console.WriteLine($"\n O salário liquído é de R${salarioLiquido}");
        }
    }
}