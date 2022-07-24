namespace entra21_trabalho_03.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public int Cep { get; set; }
    }
}