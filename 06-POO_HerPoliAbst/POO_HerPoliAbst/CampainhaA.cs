using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_HerPoliAbst
{
    public class CampainhaA : Campainha
    {
        public override void Musica()
        {
            Beep(400, 100);
            Beep(900, 300);
            Beep(200, 100);
            Beep(1000, 300);
        }
    }
}
