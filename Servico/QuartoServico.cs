
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

        public List<Quarto> BuscarTodos()
        {
            return _quartoRepositorio.BuscarTodos();
        }

        public void Excluir(Guid id)
        {
        }
    }
}




