using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProtocolComparationDotNet.GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public string Test()
        {
            return "asdasd";
        }
    }
}