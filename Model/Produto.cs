using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.Model
{
    class Produto
    {
        public int id { get; set; }
        public string descricaoProduto { get; set; }
        public double precoVendaproduto { get; set; }
        public int estoqueAtualProduto { get; set; }
        public int ncmProduto { get; set; }
        public virtual Ibpt ibpt { get; set; }
    }
}
