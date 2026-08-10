using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do aluguel:");
            double valorAluguel = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de pessoa (F para física, J para jurídica):");
            string tipoPessoa = Console.ReadLine();

            Veiculo veiculo = new Veiculo();
            double valorFinal = veiculo.AlugarCarro(valorAluguel, tipoPessoa);
            Console.WriteLine($"O valor final do aluguel é: {valorFinal:C}");

            Console.ReadKey();
        }
    }
}
