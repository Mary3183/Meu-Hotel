using Meu_Hotel.Entidade;
using Meu_Hotel.Repositorio;

namespace Meu_Hotel.Servico
{
    public class ReservaServico : ICRUD<Reserva>
    {
        ReservaRepositorio reservaRepositorio = new ReservaRepositorio();
        public void Atualizar(Reserva entidade)
        {
            reservaRepositorio.Atualizar(entidade);
        }

        public Reserva BuscarPeloID(Guid id)
        {
            return reservaRepositorio.BuscarPeloID(id);
        }

        public void Criar(Reserva entidade)
        {
            entidade.Id = Guid.NewGuid();
            reservaRepositorio.Criar(entidade);
        }

        public void Excluir(Guid id)
        {
            reservaRepositorio.Excluir(id);
        }
    }
}
