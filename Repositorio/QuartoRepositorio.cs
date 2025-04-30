using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Meu_Hotel.Entidade;

namespace Meu_Hotel.Repositorio
{
    public class QuartoRepositorio : ICRUD<Quarto>
    {
        private List<Quarto> _quartos = new List<Quarto>();
        string caminhoBanco;
        public QuartoRepositorio()
        {
            caminhoBanco = Banco.BuscarCaminho("quarto");
            Carregar();
        }

        private void Carregar()
        {
            string conteudo = File.ReadAllText(caminhoBanco);
            _quartos = JsonSerializer.Deserialize<List<Quarto>>(conteudo) ?? new();
        }

        private void EscreverArquivo()
        {
            string conteudo = JsonSerializer.Serialize(_quartos);
            File.WriteAllText(caminhoBanco, conteudo);
        }
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
            EscreverArquivo();
        }

        public Quarto BuscarPeloID(Guid id)
        {
            return _quartos.Find(quarto => quarto.Id == id);
        }

        public void Criar(Quarto quarto)
        {
            _quartos.Add(quarto);
            EscreverArquivo();
        }

        public List<Quarto> BuscarTodos()
        {
            return _quartos;
        }

        public void Excluir(Guid id)
            
        {
        }
    }
}
