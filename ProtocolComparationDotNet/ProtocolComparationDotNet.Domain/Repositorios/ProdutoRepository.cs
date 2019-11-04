using System;
using System.Collections.Generic;
using System.Linq;
using ProtocolComparationDotNet.Domain.Entities;

namespace ProtocolComparationDotNet.Domain.Repositorios
{
    public class ProdutoRepository : Repository<Produto>
    {
        protected override IEnumerable<Produto> List => new List<Produto>()
        {
            new Produto
            {
                Id = 1,
                Nome = "Cadeira",
                Vendas = new List<VendaProduto>
                {
                    new VendaProduto
                    {
                        Id = 1,
                        VendaId = 1,
                        ProdutoId = 1,
                        Quantidade = 1,
                        Valor = 1
                    }
                }
            },
            new Produto
            {
                Id = 2,
                Nome = "Mesa",
                 Vendas = new List<VendaProduto>
                {
                    new VendaProduto
                    {
                        Id = 2,
                        VendaId = 1,
                        ProdutoId = 2,
                        Quantidade = 1,
                        Valor = 1
                    }
                }
            }
        };
    }
}
