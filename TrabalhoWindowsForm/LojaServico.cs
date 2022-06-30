using Newtonsoft.Json;

namespace TrabalhoWindowsForm
{
    internal class LojaServico
    {
        private List<Loja> lojas;

        public LojaServico()
        {
            lojas = new List<Loja>();

            LerArquivo();
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
            var lojaJson = JsonConvert.SerializeObject(lojas);
            File.WriteAllText("loja.json", lojaJson);
        }

        private void LerArquivo()
        {
            if (File.Exists("loja.json") == false)
                return;

            var lojaJson = File.ReadAllText("loja.json");
            lojas = JsonConvert.DeserializeObject<List<Loja>>(lojaJson);
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < lojas.Count; i++)
            {
                var Loja = lojas[i];

                ultimoCodigo = Loja.Codigo;
            }
            return ultimoCodigo;
        }

        //public Cliente ObterPorCodigo(int codigo)
        //{
        //    for (var i = 0; i < lojas.Count; i++)
        //    {
        //        var loja = lojas[i];

        //        if (loja.Codigo == codigo)
        //            return loja;
        //    }
        //    return null;
        //}
    }
}
