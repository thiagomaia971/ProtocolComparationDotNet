using GraphQL.Types;
using ProtocolComparationDotNet.Domain.Repositorios;
using ProtocolComparationDotNet.GraphQL.Models;

namespace ProtocolComparationDotNet.GraphQL.Queries
{
    public class VendaQuery : ObjectGraphType
    {
        public VendaQuery(VendaRepository vendaRepository)
        {

            Field<ListGraphType<VendaType>>(
                "vendas",
                resolve: context =>
                {
                    var produtos = vendaRepository.Get();
                    return produtos;
                });

        }
    }
}
