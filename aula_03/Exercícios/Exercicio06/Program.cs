namespace Exercicio6

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String? nome;
            int cargo;
            float reajuste, salario, novoSalario = 0;

            Console.WriteLine("Confira o novo salário de acordo com o cargo:\n");
            
            Console.WriteLine("1 - Gerente       | 10% de reajuste");
            Console.WriteLine("2 - Vendedor      | 7% de reajuste");
            Console.WriteLine("3 - Supervisor    | 9% de reajuste");
            Console.WriteLine("4 - Motorista     | 6% de reajuste");
            Console.WriteLine("5 - Estoquista    | 5% de reajuste");
            Console.WriteLine("6 - Técnico de TI | 8% de reajuste");

            Console.Write("\nDigite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\nDigite seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"\nNome do(a) colaborador(a): {nome}");

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

            Console.WriteLine($"Novo salário: R${novoSalario:F2}");
        }
    }
}