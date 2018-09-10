using SDC.BancoDados;
using SDC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.Controller
{
    class ProdutoController
    {
        BancoContext bancoContext = new BancoContext();
        Produto produto = new Produto();


        public void GravarProduto(Produto produto)
        {
            bancoContext.Produtos.Add(produto);
            bancoContext.SaveChanges();
        }

        public List<Produto> ListarProdutos(string valorDigitado)
        {
            //Filtando utilisando expressão lambda.
            List<Produto> produtos = bancoContext.Produtos.Where(prod => prod.descricaoProduto == valorDigitado).ToList();

            return produtos;
        }
    }
}
