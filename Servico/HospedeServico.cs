using Meu_Hotel.Entidade;
using Meu_Hotel.Repositorio;

namespace Meu_Hotel.Servico
{
    public class HospedeServico
    {
        HospedeRepositorio _hospedeRepositorio = new HospedeRepositorio();

        public void Criar(Hospede hospede)
        {
            _hospedeRepositorio.Criar(hospede);
        }

        public void Atualizar(Hospede hospede)
        {
            _hospedeRepositorio.Atualizar(hospede);
        }

        public Hospede BuscarPeloCpf(string cpf)
        {
            return _hospedeRepositorio.BuscarPeloCpf(cpf);
        }

        public Hospede BuscarPeloNome(string nome)
        {
            return _hospedeRepositorio.BuscarPeloNome(nome);
        }
    }
}
