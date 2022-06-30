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


        public void Cadastrar(Loja loja)
        {
            lojas.Add(loja);

            SalvarArquivo();
        }

        public void Editar(Loja lojaEditar)
        {
            for (int i = 0; i < lojas.Count; i++)
            {
                var loja = lojas[i];

                if (loja.Codigo == lojaEditar.Codigo)
                {
                    loja.Cnpj = lojaEditar.Cnpj;
                    loja.RazaoSocial = lojaEditar.RazaoSocial;
                    loja.NomeFantasia = lojaEditar.NomeFantasia;
                    loja.Ativa = lojaEditar.Ativa;
                    loja.Vendas = lojaEditar.Vendas;
                    loja.Alugueis = lojaEditar.Alugueis;
                    loja.Consertos = lojaEditar.Consertos;

                    SalvarArquivo();
                }
            }
        }

        public void Apagar(Loja lojaApagar)
        {
            for (int i = 0; i < lojas.Count; i++)
            {
                var loja = lojas[i];

                if (loja.Codigo == lojaApagar.Codigo)
                {
                    lojas.Remove(loja);

                    SalvarArquivo();
                }
            }
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

        public List<Loja> ObterTodas()
        {
            return lojas;
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

        public Loja ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < lojas.Count; i++)
            {
                var loja = lojas[i];

                if (loja.Codigo == codigo)
                    return loja;
            }
            return null;
        }
    }
}
