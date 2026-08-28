using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Aluno
    {
        public int Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string Telefone { get; set; }

        public Aluno(int codigo, string cpf, string nome, string curso, string telefone)
        {
            Codigo = codigo;
            Cpf = cpf;
            Nome = nome;
            Curso = curso;
            Telefone = telefone;
        }
    }
}
