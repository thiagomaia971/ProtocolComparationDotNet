using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProtocolComparationDotNet.Domain.Entities;
using ProtocolComparationDotNet.Domain.Repositorios;

namespace ProtocolComparationDotNet.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly VendaRepository vendaRepository;

        public VendaController(VendaRepository vendaRepository) 
            => this.vendaRepository = vendaRepository;

        public IEnumerable<Venda> Vendas() 
            => vendaRepository.Get();
    }
}