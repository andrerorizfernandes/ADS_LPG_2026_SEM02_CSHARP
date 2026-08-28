using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmAluno : Form
    {
        private void Salvar()
        {
            Aluno aluno = new Aluno(
                int.Parse(txtCodigo.Text), 
                txtCpf.Text, 
                txtNome.Text, 
                txtCurso.Text, 
                txtTelefone.Text);
            
            MessageBox.Show("Aluno salvo com sucesso!" + 
                    "\n\nCódigo: " + aluno.Codigo + 
                    "\nCPF: " + aluno.Cpf + 
                    "\nNome: " + aluno.Nome + 
                    "\nCurso: " + aluno.Curso + 
                    "\nTelefone: " + aluno.Telefone);
        }   

        private void Limpar()
        {
            txtCodigo.Clear();
            txtCpf.Clear();
            txtNome.Clear();
            txtCurso.Clear();
            txtTelefone.Clear();
        }

        public frmAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            Limpar();
            txtCodigo.Focus();
        }
    }
}
