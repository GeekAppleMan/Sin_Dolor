using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin_dolor
{
    class Cls_Conexion
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;database=bd_sin_dolor;";
        public MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    }
}
