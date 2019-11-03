namespace ProtocolComparationDotNet.Domain.Entities
{
    public class VendaProduto : Entidade
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

        public virtual Venda Venda { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
