using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    public class Pessoa
    {
        public string Nome { get; set; }
        //composição utilizando interface para reduzir acoplamento
        //baixo acoplamento do tipo "tem um" (Pessoa tem um Endereço)
        private IEndereco _endereco;

        //endereço é injetado via construtor por injeção de dependência
        public Pessoa(IEndereco endereco)
        {
            _endereco = endereco;
        }

        public void DefinirEndereco(string rua, string cidade)
        {
            _endereco.Rua = rua;
            _endereco.Cidade = cidade;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            _endereco.MostrarEndereco();
        }
    }
}
