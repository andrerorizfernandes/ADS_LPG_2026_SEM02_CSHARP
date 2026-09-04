using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioHeranca
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public double Salario { get; private set; }

        public virtual double PagarSalario(double salario)
        {
            return salario;
        }
    }
}
