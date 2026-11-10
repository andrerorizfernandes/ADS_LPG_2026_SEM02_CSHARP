using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Conexao
    {
        public static MySqlConnection ConectarBD()
        {
            const string stringConexao = "server=127.0.0.1;user=root;password=;database=dataschool";

            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }
    }
}
