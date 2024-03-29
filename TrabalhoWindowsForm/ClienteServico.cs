﻿using Newtonsoft.Json;

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
            if (File.Exists("cliente.json") == false)
                return;

            var concessionariaJson = File.ReadAllText("cliente.json");

            clientes = JsonConvert.DeserializeObject<List<Cliente>>(concessionariaJson);
        }

        public void Cadastrar(Cliente cliente)
        {
            clientes.Add(cliente);

            SalvarArquivo();
        }

        public void Editar(Cliente clienteEditar)
        {
            var cliente = ObterPorCodigo(clienteEditar.Codigo);

            cliente.Nome = clienteEditar.Nome;
            cliente.EMail = clienteEditar.EMail;
            cliente.DataNascimento = clienteEditar.DataNascimento;

            SalvarArquivo();
        }

        public void Apagar(int codigo)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if (cliente.Codigo == codigo)
                {
                    clientes.Remove(cliente);

                    SalvarArquivo();

                    return;
                }
            }
        }

        public Cliente ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if (cliente.Codigo == codigo)
                    return cliente;
            }
            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                ultimoCodigo = cliente.Codigo;
            }
            return ultimoCodigo;
        }

        private void SalvarArquivo()
        {
            var concessionariaJson = JsonConvert.SerializeObject(clientes);
            File.WriteAllText("cliente.json", concessionariaJson);
        }
    }
}
