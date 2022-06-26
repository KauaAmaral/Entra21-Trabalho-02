using Newtonsoft.Json;

namespace TrabalhoWindowsForm
{
    internal class LojaServico
    {
        private List<Loja> lojas;

        public LojaServico()
        {
            lojas = new List<Loja>();

        }

        public List<Loja> ObterTodas()
        {
            return lojas;
        }

        public void Cadastrar(Loja loja)
        {
            lojas.Add(loja);

            SalvarArquivo();
        }

        private void SalvarArquivo()
        {
            var concessionariaJson = JsonConvert.SerializeObject(lojas);
            File.WriteAllText("concessionaria.json", concessionariaJson);
        }
    }
}
