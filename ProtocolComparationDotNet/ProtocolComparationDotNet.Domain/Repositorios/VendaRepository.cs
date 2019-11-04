using System;
using System.Collections.Generic;
using System.Linq;
using ProtocolComparationDotNet.Domain.Entities;

namespace ProtocolComparationDotNet.Domain.Repositorios
{
    public class VendaRepository : Repository<Venda>
    {
        protected override IEnumerable<Venda> List => new List<Venda>
        {
            new Venda
            {
                Id = 1,
                Descricao = "Primeira venda",
                Produtos = new List<VendaProduto> {
                    new VendaProduto
                    {
                        VendaId = 1,
                        ProdutoId = 1,
                        Quantidade = 1,
                        Valor = 1,
                        Produto = new Produto
                        {
                            Id = 1,
                            Nome = "Cadeira"
                        }
                    }
                }
            }
        };

        public IEnumerable<Produto> Produtos(int vendaId)
            => List
                .SelectMany(x => x.Produtos)
                .Where(y => y.VendaId == vendaId)
                .Select(x => x.Produto);
    }
}
