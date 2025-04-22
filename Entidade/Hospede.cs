namespace Meu_Hotel.Entidade
{
    public class Hospede
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
    }
}
