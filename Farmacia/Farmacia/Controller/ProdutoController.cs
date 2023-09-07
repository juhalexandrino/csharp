using Farmacia.Model;
using Farmacia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia.Controller
{
    public class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> listaProdutos = new();
        int id = 0;

        public void CriarProduto(Produto produto)
        {
            listaProdutos.Add(produto);
            Console.WriteLine($"\nO produto {produto.GetNome()} foi adicionado com sucesso!"); 
        }
        public void AtualizarProduto(Produto produto)
        {
            var buscaProduto = BuscarProdutoLista(produto.GetId());

            if (buscaProduto is not null) { 
            
                var index = listaProdutos.IndexOf(buscaProduto);

                listaProdutos[index] = produto;

                Console.WriteLine($"O produto nº {produto.GetId()} foi atualizado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto de ID {id} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ConsultarProdutoPorId(int id)
        {
            var consultaProduto = BuscarProdutoLista(id);

            if (consultaProduto is not null)
                consultaProduto.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O produto de ID {id} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ListarTodosOsProdutos()
        {
            foreach (var produto in listaProdutos)
            {
                produto.Visualizar();
            }
        }

        public void DeletarProduto(int id)
        {
            var produto = BuscarProdutoLista(id);
            if (produto is not null)
            {
                if (listaProdutos.Remove(produto) == true)
                {
                    Console.WriteLine($"O produto de ID {id} foi apagado com sucesso!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O produto de ID {id} não foi encontrado!");
                    Console.ResetColor();
                }
            }
        }

        public int GerarId()
        {
            return ++id;
        }

        public Produto? BuscarProdutoLista(int id)
        {
            foreach (var produto in listaProdutos)
            {
                if(produto.GetId() == id)
                    return produto;
            }

            return null;
        }
    }
}
