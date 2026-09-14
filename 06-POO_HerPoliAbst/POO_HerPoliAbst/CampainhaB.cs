using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_HerPoliAbst
{
    public class CampainhaB : Campainha
    {
        public override void Musica()
        {
            Beep(100, 200);
            Beep(700, 300);
            Beep(400, 400);
            Beep(1100, 500);
        }
    }
}
