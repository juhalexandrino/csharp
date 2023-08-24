namespace Exercicio6

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String? nome;
            int cargo;
            float reajuste, salario, novoSalario = 0;


            Console.Write("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Vendedor");
            Console.WriteLine("3 - Supervisor");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Estoquista");
            Console.WriteLine("6 - Técnico de TI");

            Console.Write("Digite seu cargo:");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu salário:");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Nome do colaborador: {nome}");

            switch (cargo)
            {
                case 1:
                    Console.WriteLine("Cargo: Gerente");
                    reajuste = 0.10f;
                    novoSalario = salario + (reajuste * salario);
                    break;

                case 2:
                    Console.WriteLine("Cargo: Vendedor");
                    reajuste = 0.07f;
                    novoSalario = salario + (reajuste * salario);
                    break;

                case 3:
                    Console.WriteLine("Cargo: Supervisor");
                    reajuste = 0.09f;
                    novoSalario = salario + (reajuste * salario);
                    break;

                case 4:
                    Console.WriteLine("Cargo: Motorista");
                    reajuste = 0.06f;
                    novoSalario = salario + (reajuste * salario);
                    break;

                case 5:
                    Console.WriteLine("Cargo: Estoquista");
                    reajuste = 0.05f;
                    novoSalario = salario + (reajuste * salario);
                    break;

                case 6:
                    Console.WriteLine("Cargo: Técnico de T.I");
                    reajuste = 0.08f;
                    novoSalario = salario + (reajuste * salario);
                    break;

                default:
                    Console.WriteLine("Código inválido.");
                    break;
            }

            Console.WriteLine($"Salário: R${novoSalario:F2}");
        }
    }
}