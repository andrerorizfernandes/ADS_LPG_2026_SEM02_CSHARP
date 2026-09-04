using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioHeranca
{
    public class Gerente : Funcionario
    {
        public override double PagarSalario(double salario)
        {
            return (salario * 1.2);
        }
    }
}
