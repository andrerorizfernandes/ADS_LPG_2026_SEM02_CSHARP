using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_HerPoliAbst
{
    public class CampainhaC : Campainha
    {
        public override void Musica()
        {
            Beep(100, 100);
            Beep(200, 200);
            Beep(300, 300);
            Beep(400, 400);
        }
    }
}
