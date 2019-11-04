using GraphQL.Types;
using ProtocolComparationDotNet.Domain.Entities;

namespace ProtocolComparationDotNet.GraphQL.Models
{
    public class VendaType : ObjectGraphType<Venda>
    {
        public VendaType()
        {
            Name = "Venda";
            Field(x => x.Descricao).Description("Descrição");
        }
    }
}
