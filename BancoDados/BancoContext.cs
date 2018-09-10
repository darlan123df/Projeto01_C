using SDC.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC.BancoDados
{
    class BancoContext : DbContext
    {
        public BancoContext() : base("Conexao")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
