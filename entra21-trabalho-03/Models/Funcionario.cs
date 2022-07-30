namespace entra21_trabalho_03.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public DateTime DataAdmissao { get; set; }
        public double Salario { get; set; }

        public Profissao Profissao { get; set; }
    }
}