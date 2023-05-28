using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_BancoDados_TurmaB.Controller_DAO
{
    class ConexaoMySQL
    {
        public MySqlConnection String_Conexao()
        {
            return new MySqlConnection("user id=root;password=root;server=localhost;database=BD_BCOLOGIN;SslMode=none");
        }
    }
}
