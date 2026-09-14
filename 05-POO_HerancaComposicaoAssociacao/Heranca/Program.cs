using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A relação por herança possui forte acoplamento e é do tipo é um");

            Professor prof = new Professor();
            prof.Nome = "Andre";
            prof.Disciplina = "LPG";

            prof.Apresentar();
            prof.Ensinar();
        }
    }
}
