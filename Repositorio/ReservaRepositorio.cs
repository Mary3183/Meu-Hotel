using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Hotel.Entidade;

namespace Meu_Hotel.Repositorio
{
    public class ReservaRepositorio : ICRUD<Reserva>
    {
        List<Reserva> _reservas = new List<Reserva>();


        public void Atualizar(Reserva reserva)
        {
            Reserva reservaLocalizada = BuscarPeloID(reserva.Id);
            if (reservaLocalizada is not null)
            {
                reservaLocalizada.DataEntrada = reserva.DataEntrada;
                reservaLocalizada.DataSaida = reserva.DataSaida;
                reservaLocalizada.Hospede = reserva.Hospede;
                reservaLocalizada.Quarto = reserva.Quarto;

            }
        }

        public Reserva BuscarPeloID(Guid id)
        {
            return _reservas.Find(reserva => reserva.Id == id);
        }

        public void Criar(Reserva entidade)
        {
            _reservas.Add(entidade);
        }

        public void Excluir(Guid id)
        {
        }
    }
}
