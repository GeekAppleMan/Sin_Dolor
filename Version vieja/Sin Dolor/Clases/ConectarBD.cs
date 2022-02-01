using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sin_Dolor.Clases
{
    class ConectarBD
    {
        MySqlConnection conex;
        string cadenaconex;

        public MySqlConnection Conexion()
        {
            cadenaconex = "server=localhost; Database=bd_sin_dolor; uid=root";
            conex = new MySqlConnection(cadenaconex);
            return conex;
        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void CerrarConexion()
        {
            conex.Close();
        }
    }
}
