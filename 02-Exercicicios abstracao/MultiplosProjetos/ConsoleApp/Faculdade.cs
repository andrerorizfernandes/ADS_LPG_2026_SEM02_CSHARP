using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Faculdade
    {
        private string cnpj;
        private string razaoSocial;
        private string cidade;

        public string GetCnpj()
        {
            return cnpj;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string GetRazaoSocial()
        {
            return razaoSocial;
        }

        public void SetRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }

        public string GetCidade()
        {
            return cidade;
        }

        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }
    }
}
