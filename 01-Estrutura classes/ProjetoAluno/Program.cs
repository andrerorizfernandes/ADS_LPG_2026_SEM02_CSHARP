using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno alTeste = new Aluno();
            alTeste.SetMatricula(123);
            alTeste.SetNome("João da Silva");  
            alTeste.SetSexo("Masculino");
            alTeste.SetTelefone("(11) 98765-4321");
            alTeste.SetEndereco("Rua das Flores, 123");
            alTeste.SetNomePai("José da Silva");
            alTeste.SetNomeMae("Maria da Silva");
            alTeste.SetEscolaridade("Ensino Médio Completo");
            alTeste.EnderecoPai = "Rua dos Pais, 456";
            alTeste.Idade = 18;

            alTeste.Matricular(689);

            Console.WriteLine(alTeste.GetMatricula());
            Console.WriteLine(alTeste.GetNome());
            Console.WriteLine(alTeste.GetSexo());
            Console.WriteLine(alTeste.GetTelefone());
            Console.WriteLine(alTeste.GetEndereco());
            Console.WriteLine(alTeste.GetNomePai());
            Console.WriteLine(alTeste.GetNomeMae());
            Console.WriteLine(alTeste.Getescolaridade());
            Console.WriteLine(alTeste.EnderecoPai);
            Console.WriteLine(alTeste.Idade);
        }
    }
}
