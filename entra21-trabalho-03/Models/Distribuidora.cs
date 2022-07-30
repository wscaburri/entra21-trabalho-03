namespace entra21_trabalho_03.Models
{
    public class Distribuidora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }

        public int Numero { get; set; }
    }
}
