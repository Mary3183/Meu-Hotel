
using Meu_Hotel.Entidade;
using Meu_Hotel.Repositorio;

namespace Meu_Hotel.Servico
{
    public class QuartoServico : ICRUD<Quarto>
    {
        private QuartoRepositorio _quartoRepositorio = new QuartoRepositorio();

        public void Atualizar(Quarto quarto)
        {
            if (quarto != null) 
            {
                _quartoRepositorio.Atualizar(quarto);
            }
            else
            {
                throw new Exception("O quarto enviado está nulo");
            }
        }

        public Quarto BuscarPeloNumero(int numeroQuarto)
        {
            return _quartoRepositorio.BuscarPeloNumero(numeroQuarto);
        }

        public Quarto BuscarPeloID(Guid id)
        {
           return _quartoRepositorio.BuscarPeloID(id);
        }

        public void Criar(Quarto quarto)
        {
           _quartoRepositorio.Criar(quarto);
        }

        public void Excluir(Guid id)
        {
          // throw new NotImplementedException();
        }

      //  public class quarto 
//        List<Quarto> quartos = new List<Quarto>
//{
//    new Quarto { Numero = 101, Tipo = "Solteiro", Ocupado = false },
//    new Quarto { Numero = 102, Tipo = "Casal", Ocupado = true },
//    new Quarto { Numero = 103, Tipo = "Suite", Ocupado = false }

//    int numeroProcurado = 102;

//Quarto quartoEncontrado = quartos.FirstOrDefault(q => q.Numero == numeroProcurado);

//if (quartoEncontrado != null)
//{
//    Console.WriteLine($"Quarto {quartoEncontrado.Numero} encontrado! Tipo: {quartoEncontrado.Tipo}, Ocupado: {quartoEncontrado.Ocupado}");
//}
//else
//{
//    Console.WriteLine("Quarto não encontrado.");
}

};

    


