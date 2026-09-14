using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IAcesso ace = new Documento();
            MessageBox.Show(ace.Ler());
            MessageBox.Show(ace.Escrever());

            IComprimir com = new Documento();
            MessageBox.Show(com.Comprimir());
            MessageBox.Show(com.Descomprimir());
        }
    }
}
