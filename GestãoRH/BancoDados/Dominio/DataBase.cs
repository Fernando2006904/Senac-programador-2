using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRH.BancoDados.Dominio
{
    internal class DataBase
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=localhost;user=root;password=;database=GestaoRH;");
        }
    }
}

