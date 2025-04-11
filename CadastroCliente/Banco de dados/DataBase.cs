using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class DataBase
    {
        private static readonly string Connectionstring = "datasource=localhost;username=root;password=;database=senac;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(Connectionstring);

        }




    }
}
