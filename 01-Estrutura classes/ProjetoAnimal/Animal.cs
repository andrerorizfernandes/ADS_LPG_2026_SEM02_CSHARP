using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAnimal
{
    public class Animal
    {
        public string Raca { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Genero { get; set; }
        public int NumeroPatas { get; set; }
        public string CorOlhos { get; set; }

        public Animal()
        {
            NumeroPatas = 0;
        }

        public Animal(int numeroPatas)
        {
            NumeroPatas = numeroPatas;
        }

        public string EmitirSom()
        {
            return "O animal emite um som.";
        }

        public string Correr(bool emMovimento = true)
        {
            if (emMovimento)
                return "O animal está correndo.";
            else
                return "O animal não está correndo.";
        }

        public string Reproduzir()
        {
            return "O animal está se reproduzindo.";
        }
    }
}
