namespace Meu_Hotel
{
    public static class Banco
    {
        public static string BuscarCaminho(string nome)
        {
            string caminhoPastaBanco = Path.Combine(Environment.CurrentDirectory, "bancos");

            if (!Directory.Exists(caminhoPastaBanco))
                Directory.CreateDirectory(caminhoPastaBanco);

            string caminhoArquivoBanco = Path.Combine(caminhoPastaBanco, $"{nome}.json");

            if (!File.Exists(caminhoPastaBanco))
            {
                File.Create(caminhoArquivoBanco).Dispose();
                File.WriteAllText(caminhoArquivoBanco,  "[]");
            }

            return caminhoArquivoBanco;
        }
    }
}
