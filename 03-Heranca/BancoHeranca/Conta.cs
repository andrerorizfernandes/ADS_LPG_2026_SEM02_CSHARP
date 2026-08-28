using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHeranca
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }
        
        public virtual void Saca(double valor) { 
            this.Saldo -= valor;
        }   

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    }
}
