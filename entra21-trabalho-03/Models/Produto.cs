﻿namespace entra21_trabalho_03.Models
{
    public class Produto1
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Preco { get; set; }
        public TipoProduto1 TipoProduto { get; set; }

    }
}
