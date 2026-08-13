using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVeiculo
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

            veiculo.Placa = "ABC-1234";
            veiculo.Ano = 2020;
            veiculo.Cor = "Preto";
            veiculo.Modelo = "Sedan";
            veiculo.Potencia = 150.0;
            veiculo.SetChassi("9BWZZZ377VT004251");

            Console.WriteLine(
                veiculo.Placa + "\n" +
                veiculo.Ano + "\n" +
                veiculo.Cor + "\n" +
                veiculo.Modelo + "\n" +
                veiculo.Potencia + "\n" +
                veiculo.GetChassi());

            Console.ReadKey();
        }
    }
}
