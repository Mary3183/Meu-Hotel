using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Hotel.Entidade;
using Meu_Hotel.Servico;

namespace Meu_Hotel.UI
{
    public static class QuartoUI
    {
        public static void Executar()
        {
            QuartoServico _quartoServico = new QuartoServico();
            bool continuar = true;
            do
            {
                Console.WriteLine("Voce está agora no menu de quartos");
                Console.WriteLine("Informe a opção");
                Console.WriteLine("1 para cadastrar");
                Console.WriteLine("2 para buscar pelo numero do quarto");
                Console.WriteLine("3 para atualizar");
                Console.WriteLine("4 para limpar a tela");
                Console.WriteLine("5 para sair do menu");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            Quarto quarto = new Quarto();
                            Console.WriteLine("Informe o seu numero");
                            quarto.Numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe as camas");
                            quarto.Camas = int.Parse(Console.ReadLine());

                            _quartoServico.Criar(quarto);
                            Console.WriteLine("quarto registrado com sucesso");

                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Informe o numero do quarto para procurar");
                            int numero = int.Parse(Console.ReadLine());
                            Quarto quartoEncontrado = _quartoServico.BuscarPeloNumero(numero);
                            Console.WriteLine("Quarto encontrado com o numero " + quartoEncontrado.Numero);
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Informe o numero do quarto");
                            int numeroQuarto = int.Parse(Console.ReadLine());
                            Quarto quarto = _quartoServico.BuscarPeloNumero(numeroQuarto);

                            if (quarto is not null)
                            {
                                Console.WriteLine("Digite um numero para o quarto");
                                quarto.Numero = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o numero de camas para o quarto");
                                quarto.Camas = int.Parse(Console.ReadLine());

                                _quartoServico.Atualizar(quarto);
                                Console.WriteLine("quarto atualizado com sucesso");
                                break;
                            }

                            Console.WriteLine($"Quarto com o numero {numeroQuarto} não localizado");
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

    }
}
