using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioHeranca
{
    public class Supervisor: Funcionario
    {
        public string Escolaridade { get; set; }
        public string Departamento { get; set; }

        public override double PagarSalario(double salario)
        {
            return (salario * 1.05);
        }
    }
}
