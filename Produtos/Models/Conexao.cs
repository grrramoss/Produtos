using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Produtos.Models
{
    public class Conexao : DbContext
    {
        public Conexao() : base("Produtos")
        {

        }

        public DbSet<Produto> Produto { get; set; }

    }
}