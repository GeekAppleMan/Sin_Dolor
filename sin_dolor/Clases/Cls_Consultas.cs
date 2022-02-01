using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace sin_dolor
{
    class Cls_Consultas : Cls_Conexion
    {
        public static DataTable tablaid = new DataTable();
        public void verificar_producto(string codigo,TextBox nombre, RichTextBox descripcion,TextBox precio,TextBox stock,PictureBox foto)
        {
            
            try
            {
                string query = "SELECT * FROM `tb_productos` WHERE codigo  = " + "'" + codigo + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    Frm_agregar_producto.id_producto = reader.GetString(0);
                    nombre.Text = reader.GetString(2);
                    descripcion.Text = reader.GetString(3);
                    precio.Text = reader.GetString(4);
                    stock.Text = reader.GetString(5);
                    foto.Image = new Bitmap(reader.GetString(6));
                }
                else
                {
                    MessageBox.Show("El producto no se encuentra registrado");
                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
            
        }
        public void mostrar_pacientes(ComboBox pacientes)
        {
            tablaid.Rows.Clear();
            if (tablaid.Columns.Count == 0)
            {
                tablaid.Columns.Add("idpaciente");
            }
            try
            {
               
                string query = "SELECT * FROM `tb_pacientes`";
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
                        tablaid.Rows.Add(reader.GetString(0));
                        pacientes.Items.Add(reader.GetString(1));
                    }
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
        }
        public void mostrar_consulta(DataGridView tabla_citas,string fecha)
        {
            try
            {
                tabla_citas.Rows.Clear();
                string query = "SELECT p.nombre,c.fecha,c.hora FROM `tb_pacientes` AS p INNER JOIN tb_consulta AS c WHERE c.fecha LIKE " + "'%" + fecha + "%'"; 
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
                        tabla_citas.Rows.Add(reader.GetString(0), reader.GetString(1) + " " + reader.GetString(2));
                    }
                }

                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
        }
        public void registrar_almacen(DataGridView productos)
        {
           
            try
            {
                for (int i = 0; i < productos.Rows.Count; i++)
                {
                    string query = "INSERT INTO `tb_almacen`(`id_producto`, `cantidad`, `fecha`) VALUES(' " + productos[0, i].Value.ToString() + "','" + productos[3, i].Value.ToString() + "','" + DateTime.Now.ToString("d") + "')";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    modificar_cantidad_producto(productos[3, i].Value.ToString(), productos[0, i].Value.ToString());
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
        }
        public void modificar_cantidad_producto(string cantidad, string id)
        {
            try
            {
                int cantidadresult = obtener_cantidad_producto(id) - Convert.ToInt32(cantidad);
                string query = "UPDATE `tb_productos` SET `cantidad`='" + cantidadresult + "'" + "WHERE id_producto = " + "'" + id + "'";
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
        public int obtener_cantidad_producto(string id)
        {
            int cantidad = 0;
            try
            {
                string query = "SELECT * FROM `tb_productos` WHERE id_producto  = " + "'" + id + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    cantidad = reader.GetInt32(5);
                }
                else
                {
                    MessageBox.Show("El producto no se encuentra registrado");
                }
                databaseConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas");
            }
            return cantidad;
        }
        public void registrar_consulta(string id, string tratamiento)
        {

            try
            {
                string query = "INSERT INTO `tb_consulta`(`fecha`, `hora`, `paciente`,`tratamiento`) VALUES(' " + DateTime.Now.ToString("d") + "','" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + "','" + id + "','" + tratamiento + "')";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                MessageBox.Show("Se registro la consulta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema, Comuniquese con el equipo de sistemas" + ex.ToString());
            }
        }
    }
}
