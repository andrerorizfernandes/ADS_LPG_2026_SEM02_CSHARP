using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    public class Professor
    {
        public string Nome { get; set; }

        // Associação: Professor usa uma Turma
        public void Ensinar(Turma turma)
        {
            Console.WriteLine($"{Nome} está ensinando a turma {turma.Nome}");
        }
    }
}
