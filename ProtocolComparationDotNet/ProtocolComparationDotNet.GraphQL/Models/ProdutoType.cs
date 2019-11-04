using System.Collections.Generic;
using GraphQL.Types;
using ProtocolComparationDotNet.Domain.Entities;

namespace ProtocolComparationDotNet.GraphQL.Queries
{
    public class ProdutoType : ObjectGraphType<Produto>
    {
        public ProdutoType()
        {
            Name = "Produto";
            Field(x => x.Nome).Description("Nome");
        }
    }
}