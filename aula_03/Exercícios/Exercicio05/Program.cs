namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoProduto, quantidade, valor, valorTotal = 0;

            Console.WriteLine("----- Cardápio -----");
            Console.WriteLine("1 - Cachorro quente | R$ 10,00");
            Console.WriteLine("2 - X Salada | R$ 15,00");
            Console.WriteLine("3 - X Bacon | R$ 18,00");
            Console.WriteLine("4 - Bauru | R$ 12,00");
            Console.WriteLine("5 - Refrigerante | R$ 8,00");
            Console.WriteLine("6 - Suco de Laranja | R$ 13,00");

            Console.Write("\nDigite o código do produto: ");
            codigoProduto = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite a quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigoProduto)
            {
                case 1:
                    Console.WriteLine("\nProduto: Cachorro Quente");
                    valor = 10;
                    valorTotal = valor * quantidade;
                    break;
                
                case 2:
                    Console.WriteLine("\nProduto: X-Salada");
                    valor = 15;
                    valorTotal = valor * quantidade;
                    break;
                
                case 3:
                    Console.WriteLine("\nProduto: X-Bacon");
                    valor = 18;
                    valorTotal = valor * quantidade;
                    break;
                
                case 4:
                    Console.WriteLine("\nProduto: Bauru");
                    valor = 12;
                    valorTotal = valor * quantidade;
                    break;
                
                case 5:
                    Console.WriteLine("\nProduto: Refrigerante");
                    valor = 8;
                    valorTotal = valor * quantidade;
                    break;
                
                case 6:
                    Console.WriteLine("\nProduto: Suco de Laranja");
                    valor = 13;
                    valorTotal = valor * quantidade;
                    break;

                default:
                    Console.WriteLine("\nO código digitado foi inválido!");
                    break;
            }

            Console.WriteLine($"\nO total do seu pedido foi de R${valorTotal:F2}");
        }
    }
}