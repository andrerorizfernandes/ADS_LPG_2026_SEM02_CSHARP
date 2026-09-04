using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioHeranca
{
    public class Diretor: Funcionario
    {
        public override double PagarSalario(double salario)
        {
            return (salario * 1.3);
        }

        public double PagarBonificacao(double valor)
        {
            return valor;
        }
    }
}
