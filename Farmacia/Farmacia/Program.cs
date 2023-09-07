using Farmacia.Controller;
using Farmacia.Model;
using System;

namespace Farmacia
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int id, entrada, tipo;
            string nome, generico, fragancia;
            decimal preco;

            ProdutoController produto = new();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n========= FarMárcia =========");
                Console.WriteLine("1 - Criar produto");
                Console.WriteLine("2 - Listar todos os produtos");
                Console.WriteLine("3 - Atualizar produto");
                Console.WriteLine("4 - Consultar produto");
                Console.WriteLine("5 - Apagar produto");
                Console.WriteLine("6 - Sair");
                Console.WriteLine("=============================");
                Console.ResetColor();

                Console.Write("Escolha a opção desejada: ");
                entrada = Convert.ToInt32(Console.ReadLine());

                switch (entrada)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Criar produto");
                        Console.ResetColor();

                        Console.Write("\nDigite o nome do produto: ");
                        nome = Console.ReadLine();

                        Console.Write("Digite o preço do produto: ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        do
                        {
                            Console.Write("Digite o tipo do produto (1 - Medicamento | 2 - Cosmético): ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                        switch (tipo)
                        {
                            case 1:
                                Console.Write("Digite o nome do genérico: ");
                                generico = Console.ReadLine();

                                produto.CriarProduto(new Medicamento(produto.GerarId(), tipo, nome, preco, generico));
                                break;

                            case 2:
                                Console.Write("Digite o nome da fragância: ");
                                fragancia = Console.ReadLine();

                                produto.CriarProduto(new Cosmetico(produto.GerarId(), tipo, nome, preco, fragancia));
                                break;
                        }
                        KeyPress();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Listar todos os produtos");
                        Console.ResetColor();

                        produto.ListarTodosOsProdutos();
                        KeyPress();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Atualizar produto");
                        Console.ResetColor();

                        Console.Write("\nDigite o ID do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var produtos = produto.BuscarProdutoLista(id);

                        if (produtos is not null)
                        {
                            Console.Write("Digite o nome do produto: ");
                            nome = Console.ReadLine();

                            Console.Write("Digite o preço do produto: ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            tipo = produtos.GetTipo();

                            switch (tipo)
                            {
                                case 1:
                                    Console.Write("Digite o nome do genérico: ");
                                    generico = Console.ReadLine();

                                    produto.AtualizarProduto(new Medicamento(id, tipo, nome, preco, generico));
                                    break;

                                case 2:
                                    Console.Write("Digite o nome da fragância: ");
                                    fragancia = Console.ReadLine();

                                    produto.AtualizarProduto(new Cosmetico(id, tipo, nome, preco, fragancia));
                                    break;
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"O ID {id} do produto não foi encontrado!");
                            Console.ResetColor();
                        }
                        KeyPress();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Consultar produto");
                        Console.ResetColor();

                        Console.Write("Digite o ID do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto.ConsultarProdutoPorId(id);
                        
                        KeyPress();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Apagar produto");
                        Console.ResetColor();

                        Console.Write("Digite o ID do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto.DeletarProduto(id);
                        KeyPress();
                        break;

                    case 6:
                        Console.WriteLine("Obrigado por usar nosso sistema!");
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida!");
                        Console.ResetColor();
                        KeyPress();
                        break;
                }

            }

            static void KeyPress()
            {
                do
                {
                    Console.WriteLine("\nPressione enter para continuar...");
                    consoleKeyInfo = Console.ReadKey();
                } while (consoleKeyInfo.Key != ConsoleKey.Enter);
            }
        }

    }
} 