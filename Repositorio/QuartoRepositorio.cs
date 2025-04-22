using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Meu_Hotel.Entidade;

namespace Meu_Hotel.Repositorio
{
    public class QuartoRepositorio : ICRUD<Quarto>
    {
        private List<Quarto> _quartos = new List<Quarto>();

        public Quarto BuscarPeloNumero(int numeroQuarto)
        {
            return _quartos.Find(quarto => quarto.Numero == numeroQuarto);
        }

        public void Atualizar(Quarto quarto)
        {
            Quarto quartoLocalizado = BuscarPeloID(quarto.Id);
            quartoLocalizado.Id = quarto.Id;
            quartoLocalizado.Camas = quarto.Camas;
            quartoLocalizado.Numero = quarto.Numero;
        }

        public Quarto BuscarPeloID(Guid id)
        {
            return _quartos.Find(quarto => quarto.Id == id);
        }

        public void Criar(Quarto quarto)
        {
            _quartos.Add(quarto);
        }

        public void Excluir(Guid id)
            
        {
        }
    }
}
