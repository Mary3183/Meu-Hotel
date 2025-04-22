using Meu_Hotel.Entidade;
using Meu_Hotel.Servico;

namespace Meu_Hotel.UI
{
    public static class HospedeUI
    {
        public static void Executar()
        {
            HospedeServico _hospedeServico = new HospedeServico();
            bool continuar = true;
            do
            {
                Console.WriteLine("Voce está agora no menu de hospede");
                Console.WriteLine("Informe a opção");
                Console.WriteLine("1 para criar um hospede");
                Console.WriteLine("2 para buscar hospede por cpf");
                Console.WriteLine("3 para atualizar hospede");
                Console.WriteLine("4 para limpar a tela");
                Console.WriteLine("5 para sair do menu");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            Hospede hospede = new Hospede();

                            hospede = PerguntarDadosHospede(hospede);

                            _hospedeServico.Criar(hospede);
                            Console.WriteLine("Hospede cadastrado com sucesso!");
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Informe o cpf do hospede");
                            string cpf = Console.ReadLine();
                            Hospede hospede = _hospedeServico.BuscarPeloCpf(cpf);

                            if (hospede is null)
                            {
                                Console.WriteLine($"Hospede com o cpf {cpf} não localizado");
                                break;
                            }

                            Console.WriteLine($"Hospede {hospede.Nome} está registrado!");
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Informe o cpf do hospede");
                            string cpf = Console.ReadLine();
                            Hospede hospede = _hospedeServico.BuscarPeloCpf(cpf);

                            if (hospede is null)
                            {
                                Console.WriteLine($"Hospede com o cpf {cpf} não localizado");
                                break;
                            }
                            hospede = PerguntarDadosHospede(hospede);

                            _hospedeServico.Atualizar(hospede);
                            Console.WriteLine("Hospede atualizado com sucesso!");
                        }
                        break;
                    case "4":
                        {
                            Console.Clear();
                        }
                        break;
                    case "5":
                        {
                            continuar = false;
                        }
                        break;
                    default:
                        break;
                }

            } while (continuar);
        }

        private static Hospede PerguntarDadosHospede(Hospede hospede)
        {
            Console.WriteLine("Informe o nome");
            hospede.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf");
            hospede.Cpf = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento");
            hospede.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe os dados de endereçoo\n");


            Console.WriteLine("Informe a rua");
            hospede.Endereco.Rua = Console.ReadLine();
            Console.WriteLine("Informe o bairro");
            hospede.Endereco.Bairro = Console.ReadLine();
            Console.WriteLine("Informe o numero da casa");
            hospede.Endereco.Numero = Console.ReadLine();
            Console.WriteLine("Informe o CEP");
            hospede.Endereco.CEP = Console.ReadLine();
            Console.WriteLine("Informe o cidade");
            hospede.Endereco.Cidade = Console.ReadLine();
            Console.WriteLine("Informe o estado");
            hospede.Endereco.Estado = Console.ReadLine();
            return hospede;
        }
    }
}
