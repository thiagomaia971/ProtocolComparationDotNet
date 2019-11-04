using System.Collections.Generic;
using System.Linq;
using GraphQL.Types;
using ProtocolComparationDotNet.Domain.Entities;
using ProtocolComparationDotNet.Domain.Repositorios;
using ProtocolComparationDotNet.GraphQL.Queries;

namespace ProtocolComparationDotNet.GraphQL.Models
{
    public class VendaType : ObjectGraphType<Venda>
    {
        public VendaType()
        {
            Name = "Venda";
            Field(x => x.Descricao).Description("Descrição");
            //Field("produtos", x => x.Produtos.Select(y => y.Produto)).Description("Produtos");
            Field<ListGraphType<ProdutoType>>(
                "produtos",
                resolve: context => new List<Produto>
                {
                    new Produto
                        {
                            Id = 1,
                            Nome = "Cadeira"
                        }
                }
            );
        }
    }
}
