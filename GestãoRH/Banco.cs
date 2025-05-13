
using System.Data;
using MySql.Data.MySqlClient;

namespace GestaoRH
{
    static class Banco
    {
        public static DataTable BuscarSql(string ComandoSql)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=Dexter1010;database=gestaoRH;"))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(ComandoSql, conn))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;

        }

       
    }
}
