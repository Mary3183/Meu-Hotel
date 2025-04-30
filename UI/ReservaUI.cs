using Meu_Hotel.Entidade;
using Meu_Hotel.Servico;

namespace Meu_Hotel.UI
{
    public class ReservaUI
    {
        public static void Executar()
        {
            QuartoServico quartoServico = new QuartoServico();
            ReservaServico reservaServico = new ReservaServico();
            HospedeServico hospedeServico = new HospedeServico();
            Console.WriteLine("1 para procurar quartos disponiveis \n" +
                "2 para cadastrar reserva \n" +
                "3 para sair"
                );
            int opcao = Convert.ToInt32(Console.ReadLine());
            bool executar = true;
            do
            {
                switch (opcao)
                {
                    case 1:
                        {
                            List<Quarto> quartos = quartoServico.BuscarTodos();
                            foreach (Quarto quarto in quartos)
                            {
                                Console.WriteLine("Numero: " + quarto.Numero);
                                Console.WriteLine("Camas: " + quarto.Camas);
                                Console.WriteLine("Tipo: " + quarto.Tipo);
                                Console.WriteLine("Id: " + quarto.Id);
                                Console.WriteLine("Disponivel: " + (quarto.Ocupado ? "Não" : "Sim"));
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Informe o id do quarto");
                            Guid idQuarto = Guid.Parse(Console.ReadLine());
                            Quarto quartoLocalizado = quartoServico.BuscarPeloID(idQuarto);
                            Console.WriteLine("Informe um cpf para localizar o hospede");
                            string cpf = Console.ReadLine();
                            Hospede hospedeLocalizado = hospedeServico.BuscarPeloCpf(cpf);

                            Reserva reserva = new Reserva
                            {
                                Ativo = true,
                                DataEntrada = DateTime.Now,
                                DataSaida = DateTime.Now.AddDays(1),
                                Hospede = hospedeLocalizado,
                                Quarto = quartoLocalizado,
                            };
                            reservaServico.Criar(reserva);
                         
                            quartoLocalizado.Ocupado = true;
                            quartoServico.Atualizar(quartoLocalizado);
                            break;
                        }
                    case 3:
                        {
                            executar = false;
                            break;
                        }
                    default:
                        break;
                }

            } while (executar);
        }
    }
}
