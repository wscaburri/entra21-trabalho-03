namespace entra21_trabalho_03.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Distribuidora Distribuidora { get; set; }
        public EstoqueProduto EstoqueProduto { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorPedido { get; set; }
    }
}