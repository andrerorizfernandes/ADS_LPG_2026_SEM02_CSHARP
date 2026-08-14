using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAnimal
{
    public class Program
    {
        static void Main(string[] args)
        {
            var quantidadePatas = 4;
            Animal animal = new Animal(quantidadePatas);

            Console.WriteLine("Informe a raça do animal:");
            animal.Raca = Console.ReadLine();

            Console.WriteLine("Informe o nome do animal:");
            animal.Nome = Console.ReadLine();

            Console.WriteLine("Informe a cor do animal:");
            animal.Cor = Console.ReadLine();

            Console.WriteLine("Informe o gênero do animal:");
            animal.Genero = Console.ReadLine();

            Console.WriteLine("Informe a cor dos olhos do animal:");
            animal.CorOlhos = Console.ReadLine();

            Console.WriteLine(
                animal.Raca + "\n" + 
                animal.Nome + "\n" + 
                animal.Cor + "\n" + 
                animal.Genero + "\n" + 
                animal.NumeroPatas + "\n" + 
                animal.CorOlhos);

            var resultado = animal.Correr(false);
            Console.WriteLine(resultado);
        }
    }
}
