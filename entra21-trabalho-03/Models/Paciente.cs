namespace entra21_trabalho_03.Models
{
    internal class Paciente
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string LocalNascimento { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}