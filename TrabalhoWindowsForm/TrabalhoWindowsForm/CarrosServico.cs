using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoWindowsForm
{
    public class CarrosServico
    {
        private List<Carro> carros;

        public CarrosServico ()
        {
            carros = new List<Carro>();
        }
        private void SalvarArquivo()
        {
            var carroJson = JsonConvert.SerializeObject(carros);
            File.WriteAllText("carro.json", carroJson);
        }
    }
}
