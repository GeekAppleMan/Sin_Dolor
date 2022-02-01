using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sin_Dolor.Clases
{
    class MostrarTabla:ConectarBD
    {
        string comando;

        public DataTable SeleccionarTablaPacientes()
        {
            comando = "SELECT * FROM tb_pacientes";
            MySqlDataAdapter adp = new MySqlDataAdapter(comando, Conexion());
            DataTable Consulta = new DataTable();
            adp.Fill(Consulta);
            return Consulta;
        }

        public DataTable SeleccionarTablaProductos()
        {
            comando = "SELECT * FROM tb_productos";
            MySqlDataAdapter adp = new MySqlDataAdapter(comando, Conexion());
            DataTable Consulta = new DataTable();
            adp.Fill(Consulta);
            return Consulta;
        }
    }
}
