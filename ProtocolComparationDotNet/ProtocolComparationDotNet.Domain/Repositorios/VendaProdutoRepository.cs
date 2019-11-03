using System.Collections.Generic;
using ProtocolComparationDotNet.Domain.Entities;

namespace ProtocolComparationDotNet.Domain.Repositorios
{
    public class VendaProdutoRepository : Repository<VendaProduto>
    {
        protected override IEnumerable<VendaProduto> List => new List<VendaProduto>
        {
            new VendaProduto
            {
                Id = 1,
                ProdutoId = 1,
                VendaId = 1,
                Quantidade = 1,
                Valor = 1
            },
            new VendaProduto
            {
                Id = 2,
                ProdutoId = 2,
                VendaId = 1,
                Quantidade = 1,
                Valor = 1
            }
        };
    }
}
