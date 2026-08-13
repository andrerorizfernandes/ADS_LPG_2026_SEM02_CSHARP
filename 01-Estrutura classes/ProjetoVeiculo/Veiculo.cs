using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVeiculo
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Potencia { get; set; }

        private string chassi;

        public string GetChassi()
        {
            return this.chassi;
        }

        public void SetChassi(string value)
        {
            this.chassi = value;
        }

        public double AlugarCarro(double ValorAluguel, string TipoPessoa)
        {
            switch (TipoPessoa)
            {
                case "F":
                    return ValorAluguel - (ValorAluguel * 0.05);
                case "J":
                    return ValorAluguel - (ValorAluguel * 0.15);
                default:
                    throw new ArgumentException("Tipo de pessoa inválido.");
            }
        }
    }
}
