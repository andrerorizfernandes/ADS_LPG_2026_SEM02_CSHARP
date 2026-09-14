using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_HerPoliAbst
{    
    public abstract class Campainha
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(UInt32 frequencia, UInt32 duracao);

        //método abstrato - não posso instanciar objetos dele
        public abstract void Musica();
        //método concreto (aciona o abstrato)
        public void TocarCampainha()
        {
            Musica();
        }
    }
}
