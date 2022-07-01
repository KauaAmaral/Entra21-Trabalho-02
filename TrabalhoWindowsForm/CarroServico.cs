using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoWindowsForm
{
    internal class CarroServico
    {
        private List<Carro> carros;

        public CarroServico ()
        {
            carros = new List<Carro>();

            LerArquivo();
        }

        public List<Carro> ObterTodos()
        {
            return carros;
        }
        public Carro ObterPorNomePaciente(string modelo)
        {
            for (int i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];

                if (carro.Modelo == modelo)
                    return carro;
            }

            return null;
        }

        private void LerArquivo()
        {
            if (File.Exists("carros.json") == false)
                return;

            var carrosJson = File.ReadAllText("carros.json");

            carros = JsonConvert.DeserializeObject<List<Carro>>(carrosJson);
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];

                ultimoCodigo = carro.Codigo;
            }

            return ultimoCodigo;
        }

        public void Cadastrar(Carro carro)
        {
            carros.Add(carro);

            SalvarArquivo();

        }

        public void Editar(Carro carroParaEditar)
        {
            var carro = ObterPorCodigo(carroParaEditar.Codigo);

            carro.Modelo = carroParaEditar.Modelo;
            carro.Marca = carroParaEditar.Marca;
            carro.Categoria = carroParaEditar.Categoria;
            carro.Placa = carroParaEditar.Placa;
            carro.Classe = carroParaEditar.Classe;


            SalvarArquivo();
        }

        public Carro ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];

                if (carro.Codigo == codigo)
                    return carro;
            }
            return null;
        }

        public void Apagar(int codigo)
        {
            for (int i = 0; i < carros.Count; i++)
            {
                var carro = carros[i];

                if (carro.Codigo == codigo)
                {
                    carros.Remove(carro);

                    SalvarArquivo();

                    return;
                }
            }
        }

        private void SalvarArquivo()
        {
            var carrosJson = JsonConvert.SerializeObject(carros);
            File.WriteAllText("carros.json", carrosJson);
        }
    }
}
