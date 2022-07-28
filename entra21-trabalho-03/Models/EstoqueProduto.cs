namespace entra21_trabalho_03.Models
{
    public class EstoqueProduto
    {
        public int Id { get; set; }
        public string Nome  { get; set; }
        public int QuantidadeProduto { get; set; }
        public DateTime ValidadeProduto { get; set; }
        public DateTime EntradaProdutoEstoque { get; set; }
        public Distribuidora Farmacia { get; set; }
        
        public TipoProduto1 TipoProduto { get; set; }
    }
}
