using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace testando
{
    class conexão
    {
        static private string servidor = "localhost";
        static private string bd = "testando";
        static private string usuario = "root";
        static private string senha = "";
        static private string StrCon = "server=" + servidor + ";database=" + bd + ";user id=" + usuario + ";password=" + senha;
    public MySqlConnection getConexao()
        {
            MySqlConnection conexao = new MySqlConnection(StrCon);
            return conexao;
        }
    }
}
