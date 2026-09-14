using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public void Ensinar()
        {
            Console.WriteLine($"Estou ensinando {Disciplina}");
        }
    }
}
