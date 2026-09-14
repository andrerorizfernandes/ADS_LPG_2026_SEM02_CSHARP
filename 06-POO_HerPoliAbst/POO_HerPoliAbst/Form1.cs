using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_HerPoliAbst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedIndex)
            {
                case 0: 
                    Campainha cA = new CampainhaA();
                    //polimorfismo
                    cA.TocarCampainha();
                    break;
                case 1:
                    Campainha cB = new CampainhaB();
                    //polimorfismo
                    cB.TocarCampainha();
                    break;
                case 2:
                    Campainha cC = new CampainhaC();
                    //polimorfismo
                    cC.TocarCampainha();
                    break;
            }
        }
    }
}
