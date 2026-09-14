using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A relação por composição possui baixo acoplamento e é do tipo tem um");

            //instanciando implementação concreta da interface
            IEndereco endereco = new Endereco();
            //aplicação de baixo acoplamento via injeção de dependência
            Pessoa p = new Pessoa(endereco);
            p.Nome = "Indivíduo 001";
            p.DefinirEndereco("Rua do teste", "Testes");
            p.MostrarDados();
        }
    }
}
