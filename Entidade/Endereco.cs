﻿namespace Meu_Hotel.Entidade
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
    }
}
