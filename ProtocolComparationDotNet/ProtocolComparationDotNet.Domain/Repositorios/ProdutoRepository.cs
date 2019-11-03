using System.Collections.Generic;
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
                Nome = "Cadeira"
            },
            new Produto
            {
                Id = 2,
                Nome = "Mesa"
            }
        };
    }
}
