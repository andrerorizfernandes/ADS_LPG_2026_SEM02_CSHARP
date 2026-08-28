using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoHeranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            switch (cboTipoConta.SelectedIndex)
            {
                case 0: // Conta Corrente
                    Conta contaCorrente = new Conta();
                    contaCorrente.Saca(double.Parse(txtValor.Text));
                    MessageBox.Show("Saque realizado com sucesso! Novo saldo: " + contaCorrente.Saldo);
                    break;
                case 1: // Conta Poupança
                    ContaPoupanca contaPoupanca = new ContaPoupanca();
                    contaPoupanca.Saca(double.Parse(txtValor.Text));
                    MessageBox.Show("Saque realizado com sucesso! Novo saldo: " + contaPoupanca.Saldo);
                    break;
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            switch (cboTipoConta.SelectedIndex)
            {
                case 0: // Conta Corrente
                    Conta contaCorrente = new Conta();
                    contaCorrente.Deposita(double.Parse(txtValor.Text));
                    MessageBox.Show("Depósito realizado com sucesso! Novo saldo: " + contaCorrente.Saldo);
                    break;
                case 1: // Conta Poupança
                    ContaPoupanca contaPoupanca = new ContaPoupanca();
                    contaPoupanca.Deposita(double.Parse(txtValor.Text));
                    MessageBox.Show("Depósito realizado com sucesso! Novo saldo: " + contaPoupanca.Saldo);
                    break;
            }
        }
    }
}
