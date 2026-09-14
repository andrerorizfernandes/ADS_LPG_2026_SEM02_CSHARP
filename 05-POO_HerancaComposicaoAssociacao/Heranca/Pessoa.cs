using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }
    }
}
