using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno xpto = new Aluno();
            xpto.CadastrarAluno();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            ContaPoupanca c2 = new ContaPoupanca();
            TotalizadorContas t = new TotalizadorContas();

            t.Soma(c1);
            t.Soma(c2);
        }
    }
}
