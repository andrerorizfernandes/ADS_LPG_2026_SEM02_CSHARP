using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    //utilizando interface para definir o contrato do endereço
    //classes vão depender da abstração (interface) e não da implementação concreta (classe Endereco)
    //isso promove um baixo acoplamento e maior flexibilidade no código
    public interface IEndereco
    {
        string Rua { get; set; }
        string Cidade { get; set; }
        void MostrarEndereco();
    }
}
