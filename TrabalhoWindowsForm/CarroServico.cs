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
        }
        public List<Carro> ObterTodos()
        {
            return carros;
        }

        public void CadastrarCarro(Carro carro)
        {
            carros.Add(carro);

            SalvarArquivo();
        }
        private void SalvarArquivo()
        {
            var carroJson = JsonConvert.SerializeObject(carros);
            File.WriteAllText("carro.json", carroJson);
        }
    }
}
