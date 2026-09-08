using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPolimorfismo
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }

        public Aluno(string nome)
        {
            this.Nome = nome;
        }

        public Aluno(int idade, string cpf)
        {
            this.Cpf = cpf;
        }

        public Aluno(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Aluno() { 
        
        }

        public void CadastrarAluno()
        {

        }

        public void CadastrarAluno(bool Ativo)
        {

        }

        public void CadastrarAluno(bool Ativo, string nome)
        {

        }
    }
}
