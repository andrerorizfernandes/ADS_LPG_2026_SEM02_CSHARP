using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Interface
{
    public class Documento : IAcesso, IComprimir
    {
        public string Comprimir()
        {
            return "Executando o método Comprimir da classe Documento para IComprimir";
        }

        public string Descomprimir()
        {
            return "Executando o método Descomprimir da clase Documento para IComprimir";            
        }

        public string Escrever()
        {
            return "Executando o método Escrever da classe Documento para IAcesso";
        }

        public string Ler()
        {
            return "Executando o método Ler da classe Documento para IAcesso";
        }
    }
}
