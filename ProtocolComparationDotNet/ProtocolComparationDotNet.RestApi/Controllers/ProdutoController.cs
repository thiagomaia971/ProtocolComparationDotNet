using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProtocolComparationDotNet.Domain.Entities;
using ProtocolComparationDotNet.Domain.Repositorios;

namespace ProtocolComparationDotNet.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository produtoRepository;

        public ProdutoController(ProdutoRepository produtoRepository) 
            => this.produtoRepository = produtoRepository;

        [HttpGet, Route("")]
        public IEnumerable<Produto> Produtos() 
            => produtoRepository.Get();
    }
}