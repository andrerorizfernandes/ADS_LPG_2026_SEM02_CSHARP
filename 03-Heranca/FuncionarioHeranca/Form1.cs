using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionarioHeranca
{
    public partial class frmFuncionario : Form
    {
        private void CalcularSalario()
        {
            var salarioCalculado = 0.00;
            switch (cboTipoFuncionario.SelectedIndex)
            {
                case 0: 
                    Funcionario fun = new Funcionario();
                    salarioCalculado = fun.PagarSalario(Convert.ToDouble(txtSalario.Text));
                    MessageBox.Show("O salário do funcionário é " + salarioCalculado.ToString());
                    break;
                case 1:
                    Gerente ger = new Gerente();
                    salarioCalculado = ger.PagarSalario(Convert.ToDouble(txtSalario.Text));
                    MessageBox.Show("O salário do gerente é " + salarioCalculado.ToString());
                    break;
                case 2:
                    Supervisor sup = new Supervisor();
                    sup.Escolaridade = "Superior";
                    sup.Departamento = "Tecnologia";
                    salarioCalculado = sup.PagarSalario(Convert.ToDouble(txtSalario.Text));
                    MessageBox.Show("O salário do supervisor é " + salarioCalculado.ToString() +
                        "\nEscolaridade: " + sup.Escolaridade +
                        "\nDepartamento: " + sup.Departamento);
                    break;
                case 3:
                    Diretor dir = new Diretor();
                    salarioCalculado = dir.PagarSalario(Convert.ToDouble(txtSalario.Text));
                    var bonificacao = dir.PagarBonificacao(2000);
                    MessageBox.Show("O salário do diretor é " + salarioCalculado.ToString() +
                        "\nA bonificação é: " + bonificacao.ToString());
                    break;
            }
        }

        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularSalario();
        }
    }
}
