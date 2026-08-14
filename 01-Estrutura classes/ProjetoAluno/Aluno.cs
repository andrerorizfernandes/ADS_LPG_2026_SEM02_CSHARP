using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno
{
    public class Aluno
    {
        private int matricula;
        private string nome;
        private string sexo;
        private string telefone;
        private string endereco;
        private string nomePai;
        private string nomeMae;
        private string escolaridade;

        public int GetMatricula()
        {
            return matricula;
        }

        public void SetMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetSexo()
        {
            return sexo;
        }

        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string GetNomePai()
        {
            return nomePai;
        }

        public void SetNomePai(string nomePai)
        {
            this.nomePai = nomePai;
        }

        public string GetNomeMae()
        {
            return nomeMae;
        }

        public void SetNomeMae(string nomeMae)
        {
            this.nomeMae = nomeMae;
        }

        public string Getescolaridade()
        {
            return escolaridade;
        }

        public void SetEscolaridade(string escolaridade)
        {
            this.escolaridade = escolaridade;
        }

        public string Matricular(int matricula)
        {
            this.matricula = matricula;
            return "Aluno " + matricula + " matriculado com sucesso!";
        }

        public string Transferir(int matricula)
        {
            this.matricula = matricula;
            return "Aluno " + matricula + " transferido com sucesso!";
        }

        public string Evadir(int matricula)
        {
                this.matricula = matricula;
                return "Aluno " + matricula + " evadido com sucesso!";
        }
    }
}
