using MySqlConnector;
using Pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Persistencia
    {
        public static MySqlDataReader ExecutarSQL(string pSQL, object pEntidade)
        {
            MySqlCommand comando = new MySqlCommand(pSQL, Conexao.ConectarBD());
            if (pEntidade is Aluno aluno)
            {
                comando.Parameters.AddWithValue("@codaluno", aluno.CodigoAluno);
                comando.Parameters.AddWithValue("@nome", aluno.Nome);
                comando.Parameters.AddWithValue("@cpf", aluno.Cpf);
                comando.Parameters.AddWithValue("@sexo", aluno.Sexo);
                comando.Parameters.AddWithValue("@idade", aluno.Idade);

            }
            
            MySqlDataReader dr = comando.ExecuteReader();
            return dr;
        }

        public static int RetornarProximoId(string pNomeTabela, string pNomeCampoChave)
        {
            var lSql = "Select Coalesce(Max(" + pNomeCampoChave + ")+1, 1) ProximoCodigo From " + pNomeTabela;
            using (var dr = ExecutarSQL(lSql, null))
            {
                dr.Read();
                return Convert.ToInt32(dr["ProximoCodigo"].ToString());
            }
        }
    }
}
