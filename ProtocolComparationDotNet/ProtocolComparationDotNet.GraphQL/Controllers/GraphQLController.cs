
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using ProtocolComparationDotNet.Domain.Repositorios;
using ProtocolComparationDotNet.GraphQL.Queries;

namespace ProtocolComparationDotNet.GraphQL.Controllers
{
    [Route("graphql")]
    [ApiController]
    public class GraphQLController : Controller
    {
        private readonly VendaRepository _vendaRepository;
        private readonly ProdutoRepository produtoRepository;

        public GraphQLController(VendaRepository vendaRepository, ProdutoRepository produtoRepository)
        {
            _vendaRepository = vendaRepository;
            this.produtoRepository = produtoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new Schema()
            {
                Query = new VendaQuery(_vendaRepository, produtoRepository)
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
                return BadRequest();

            return Ok(result);
        }
    }
}
