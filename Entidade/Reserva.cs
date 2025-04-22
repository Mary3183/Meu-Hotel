namespace Meu_Hotel.Entidade
{
    public class Reserva
    {
        public Guid Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Hospede Hospede { get; set; }
        public Quarto Quarto { get; set; }
        public bool Ativo { get; set; }
    }
}
