using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Hotel.Entidade;
using Meu_Hotel.UI;

namespace Meu_Hotel.Repositorio
{
    public class HospedeRepositorio : ICRUD<Hospede>
    {
        List<Hospede> _hospedes = new List<Hospede>();


        public void Criar(Hospede hospede)
        {
            _hospedes.Add(hospede);
        }

        public Hospede BuscarPeloCpf(string cpf)
        {
            return _hospedes.Find(hospede => hospede.Cpf == cpf);
        }

        public Hospede BuscarPeloNome(string nome)
        {
            return _hospedes.Find(hospede => hospede.Nome == nome);
        }

        public void Atualizar(Hospede hospede)
        {
            Hospede hospedeLocalizado = BuscarPeloID(hospede.Id);
            hospedeLocalizado.Id = hospede.Id;
            hospedeLocalizado.Endereco = hospede.Endereco;
            hospedeLocalizado.Cpf = hospede.Cpf;
            hospedeLocalizado.Nome = hospede.Nome;
            hospedeLocalizado.DataNascimento = hospede.DataNascimento;

        }

        public void Excluir(Guid id)
        {
        }

        public Hospede BuscarPeloID(Guid id)
        {
            return _hospedes.Find(hospede => hospede.Id == id);
        }
    }
}
