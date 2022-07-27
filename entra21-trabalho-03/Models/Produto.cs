namespace entra21_trabalho_03.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal Preco { get; set; }
        public TipoProduto1 TipoProduto { get; set; }

    }
}
