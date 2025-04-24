namespace Meu_Hotel.Entidade
{
    public class Quarto
    {
        public Guid Id { get; set; }
        public int Camas { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public bool Ocupado { get; set; }
    }
}


