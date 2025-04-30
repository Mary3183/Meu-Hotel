using Meu_Hotel.Entidade;
using Meu_Hotel.UI;


namespace Meu_Hotel
{
    public static class Program
    {
        public static void Main(string[] args)

        {

            bool continuar = true;

            do
            {
                Console.Clear();
                Console.WriteLine("\t \t --== Bem-vindo ao sistema de reservas do hotel ==-- \n");
                Console.WriteLine("* Voce está agora no menu principal \n");
                Console.WriteLine("Informe o menu que deseja acessar");
                Console.WriteLine("1 para Hospedes");
                Console.WriteLine("2 para quarto");
                Console.WriteLine("3 para reserva");
                Console.WriteLine("4 para encerrar");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        {
                            Console.Clear();
                            HospedeUI.Executar();
                        }
                        break;
                    case "2":
                        {
                            QuartoUI.Executar();
                        }
                        break;
                    case "3":
                        {
                            ReservaUI.Executar();
                        }
                        break;
                    case "4":
                        {
                            continuar = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (continuar);



            // Program > Servico > Repositorio 



            //Console.WriteLine("1. Exibir quartos disponíveis");
            //Console.WriteLine("2. Reservar quarto");
            //Console.WriteLine("3. Ver reservas");
            //Console.WriteLine("4. Sair");
            //Console.Write("Escolha uma opção: ");
            //string escolha = Console.ReadLine();

        }
    }
}