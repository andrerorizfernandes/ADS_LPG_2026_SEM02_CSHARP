using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    public class TotalizadorContas
    {
        public double ValorTotal { get; set; }

        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }
    }
}
