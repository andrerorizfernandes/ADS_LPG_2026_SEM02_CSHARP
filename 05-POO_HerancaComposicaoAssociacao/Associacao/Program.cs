using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A relação por associação possui baixo acoplamento e é do tipo usa um");
            Professor prof = new Professor(); 
            prof.Nome = "Ana";

            //turma existe independentemente do professor
            Turma turma = new Turma();
            turma.Nome = "3º Ano";

            prof.Ensinar(turma);
        }
    }
}
