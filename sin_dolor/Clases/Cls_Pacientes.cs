using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_dolor
{
    class Cls_Pacientes:Cls_Conexion
    {
        public static Form frm_modificar;

        //Restructurado por Jaime :v COPYRIGHT 27/01/2022 A LAS 12:23 P.M.
        public void Recomendado_por(ComboBox recomendado)
        {
            try
            {
                string query = "SELECT recomendado_por FROM tb_pacientes GROUP BY recomendado_por";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        recomendado.Items.Add(reader.GetString(0));
                    }
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
           
        }
        public void Mostrar_Paciente(DataGridView tabla)
        {
            try
            {
                string query = "SELECT * FROM `tb_pacientes`; ";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tabla.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    }
                }
               
                databaseConnection.Close();            
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
        }
        public void Registrar_Paciente(string Nombre, string Domicilio, string fechaNacimiento, string Telefono, string RecomendadoPor)
        {
            try
            {
                string query = "INSERT INTO `tb_pacientes` (`nombre`, `domicilio`, `fecha_nacimiento`, `telefono`, `recomendado_por`) " +
                               "VALUES ('" + Nombre + "', '" + Domicilio + "', '" + fechaNacimiento + "', '" + Telefono + "', '" + RecomendadoPor + "'); ";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
        }
        public void Modificar_Paciente(string id,string nombre, string domicilio, string fecha, string telefono, string recomendado)
        {
            try
            {
                string query = "UPDATE tb_pacientes SET nombre = '" + nombre + "', " + "domicilio = '" + domicilio + "', " + "fecha_nacimiento = '" + fecha + "', " + "telefono = '" + telefono + "', " + "recomendado_por = '" + recomendado + "' " + "WHERE id_paciente = " + id;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                databaseConnection.Open();
                MessageBox.Show("Se modifico correctamente");
                frm_modificar.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
            
        }
        public void Eliminar_paciente(string id)
        {
            try
            {
                string query = "DELETE FROM tb_pacientes WHERE id_paciente = " + id;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Se elimino al paciente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
           
        }
    }
}
