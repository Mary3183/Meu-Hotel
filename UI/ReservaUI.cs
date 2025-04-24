using Meu_Hotel.Entidade;

namespace Meu_Hotel.UI
{
    public class ReservaUI
    {
        public static void Executar()
        {
            List<Quarto> quartos = new List<Quarto>()
            {
                new Quarto { Numero = 101, Tipo = "Solteiro", Ocupado = false },
                new Quarto { Numero = 102, Tipo = "Casal", Ocupado = true },
                new Quarto { Numero = 103, Tipo = "Suite", Ocupado = false }
            };

            int numeroProcurado = 102;
            Quarto quartoEncontrado = quartos.FirstOrDefault(q => q.Numero == numeroProcurado);
            if (quartoEncontrado != null)
            {
                Console.WriteLine($"Quarto {quartoEncontrado.Numero} encontrado! Tipo: {quartoEncontrado.Tipo}, Ocupado: {quartoEncontrado.Ocupado}");
            }
            else
            {
                Console.WriteLine("Quarto não encontrado.");
            }
        }
    }
}
