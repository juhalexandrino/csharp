using Farmacia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Repository
{
    public interface IProdutoRepository 
    {
        // métodos CRUD
        public void CriarProduto(Produto produto);
        public void AtualizarProduto(Produto produto);
        public void ConsultarProdutoPorId(int id);
        public void DeletarProduto(int id);
        public void ListarTodosOsProdutos();
    }
}
