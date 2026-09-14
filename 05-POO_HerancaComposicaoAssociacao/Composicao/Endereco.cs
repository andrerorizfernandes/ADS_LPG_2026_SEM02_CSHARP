using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    //implementação concreta da interface IEndereco
    //baixo acoplamento, maior flexibilidade, sem dependência direta
    public class Endereco : IEndereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }

        public void MostrarEndereco()
        {
            Console.WriteLine($"{Rua}, {Cidade}");
        }
    }
}
