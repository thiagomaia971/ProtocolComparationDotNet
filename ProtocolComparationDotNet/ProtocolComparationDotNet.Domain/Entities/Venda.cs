using System;
using System.Collections.Generic;
using System.Text;

namespace ProtocolComparationDotNet.Domain.Entities
{
    public class Venda : Entidade
    {
        public string Descricao { get; set; }
        public virtual IEnumerable<VendaProduto> Produtos { get; set; }
    }
}
