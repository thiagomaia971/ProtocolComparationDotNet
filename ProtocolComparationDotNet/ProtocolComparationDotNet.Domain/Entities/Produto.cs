using System;
using System.Collections.Generic;
using System.Text;

namespace ProtocolComparationDotNet.Domain.Entities
{

    public class Produto : Entidade
    {
        public string Nome { get; set; }

        public virtual ICollection<VendaProduto> Vendas { get; set; }
    }
}
