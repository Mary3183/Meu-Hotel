using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Hotel.Entidade;
using Meu_Hotel.Servico;

namespace Meu_Hotel
{
    public class Seed
    {
        HospedeServico hospedeServico = new HospedeServico();
        QuartoServico quartoServico = new QuartoServico();
        ReservaServico reservaServico = new ReservaServico();

        public void Executar()
        {
            SeedHospede();

            SeedQuarto();

            SeedReserva();
        }

        private void SeedHospede()
        {
            List<Hospede> hospedes = new List<Hospede>()
            {
                new Hospede()
                {
                    Cpf = "12323123",
                    DataNascimento = DateTime.Today,
                    Nome = "Pessoa",
                    Id = Guid.NewGuid(),
                    Endereco = new Endereco
                    {
                        Bairro = "Bairro",
                        Numero ="12",
                        Rua = "Teste",
                        Cidade = "teste",
                        Estado = "SP",
                        CEP = "89082333",
                        Id = Guid.NewGuid()
                    }
                },
                 new Hospede()
                {
                    Cpf = "123",
                    DataNascimento = DateTime.Today,
                    Nome = "MAria",
                    Id = Guid.NewGuid(),
                    Endereco = new Endereco
                    {
                        Bairro = "Bairro",
                        Numero ="12",
                        Rua = "Teste",
                        Cidade = "teste",
                        Estado = "Sc",
                        CEP = "89082333",
                        Id = Guid.NewGuid()
                    }
                },
                  new Hospede()
                {
                    Cpf = "6452323423",
                    DataNascimento = DateTime.Today,
                    Nome = "PEssoa2",
                    Id = Guid.NewGuid(),
                    Endereco = new Endereco
                    {
                        Bairro = "Bairro",
                        Numero ="12",
                        Rua = "Teste",
                        Cidade = "teste",
                        Estado = "SP",
                        CEP = "89082333",
                        Id = Guid.NewGuid()
                    }
                }
            };

            foreach (var item in hospedes)
            {
                hospedeServico.Criar(item);
            }
        }


        private void SeedQuarto()
        {
            List<Quarto> quartos = new List<Quarto>()
            {
                new Quarto
                {
                    Camas = 2,
                    Numero = 10,
                    Ocupado = false,
                    Id = Guid.NewGuid(),
                },
                       new Quarto
                {
                    Camas = 1,
                    Numero = 11,
                    Ocupado = false,
                    Id = Guid.NewGuid(),
                },
                              new Quarto
                {
                    Camas = 1,
                    Numero = 12,
                    Ocupado = false,
                    Id = Guid.NewGuid(),
                },
            };

            foreach (var item in quartos)
            {
                quartoServico.Criar(item);
            }

        }

        private void SeedReserva()
        {
            Reserva reserva = new Reserva();
            reserva.Id = Guid.NewGuid();
            reserva.Ativo = true;
            reserva.Quarto = quartoServico.BuscarPeloNumero(11);
            reserva.DataEntrada = DateTime.Now;
            reserva.Hospede = hospedeServico.BuscarPeloCpf("6452323423");

            reservaServico.Criar(reserva);
        }
    }
}
