using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Faculdade fac = new Faculdade();
            Console.WriteLine("Digite o CNPJ da faculdade:");
            fac.SetCnpj(Console.ReadLine());
            Console.WriteLine("Digite a razão social da faculdade:");
            fac.SetRazaoSocial(Console.ReadLine());
            Console.WriteLine("Digite a cidade da faculdade:");
            fac.SetCidade(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Dados da faculdade:");
            Console.WriteLine("CNPJ: " + fac.GetCnpj());
            Console.WriteLine("Razão Social: " + fac.GetRazaoSocial());
            Console.WriteLine("Cidade: " + fac.GetCidade());
        }
    }
}
