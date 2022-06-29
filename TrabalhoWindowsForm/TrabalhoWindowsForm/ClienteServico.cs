using Newtonsoft.Json;

namespace TrabalhoWindowsForm
{
    internal class ClienteServico
    {
        private List<Cliente> clientes;

        public ClienteServico()
        {
            clientes = new List<Cliente>();

            LerArquivo();
        }

        public List<Cliente> ObterTodos()
        {
            return clientes;
        }

        public Cliente ObterPorNomeCliente(string nomeCliente)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if (cliente.Nome == nomeCliente)
                {
                    return cliente;
                }
            }
            return null;
        }

        private void LerArquivo()
        {
            if (File.Exists("concessionaria.json") == false)
                return;

            var concessionariaJson = File.ReadAllText("concessionaria.json");

            clientes = JsonConvert.DeserializeObject<List<Cliente>>(concessionariaJson);
        }
    }
}
