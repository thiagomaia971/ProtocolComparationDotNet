using System.Collections.Generic;
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
                Descricao = "Primeira venda"
            }
        };
    }
}
