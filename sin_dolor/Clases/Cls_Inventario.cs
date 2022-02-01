using MySql.Data.MySqlClient;
using sin_dolor.RJContols;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_dolor
{
    class Cls_Inventario:Cls_Conexion
    {
        public void Registrar_Producto(string nombre,string descripcion,string precio,string cantidad ,string foto,string codigo)
        {
            try
            {
              
                    string query = "INSERT INTO `tb_productos` (`codigo`,`nombre`, `descripcion`, `precio`,`cantidad`,`foto`) VALUES ('" + codigo + "','" + nombre + "','" + descripcion + "','" + precio + "','" + cantidad + "','" + foto + "'); ";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    MessageBox.Show("se registro el producto");
               
            }
            catch (Exception)
            {

            }
        }
        public bool Verificar_Codigo (string codig,RJTextBox nombre , RJTextBox descripcion, RJTextBox precio, RJTextBox cantidad, PictureBox imagen)
        {
            bool verificar = false;
            try
            {
                string query = "select * from `tb_productos` where codigo = '"+ codig +"'"  ;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.Read())
                {
                    verificar = true;
                    nombre.Text = reader.GetString(2);
                    descripcion.Text = reader.GetString(3);
                    precio.Text = reader.GetString(4);
                    cantidad.Text = reader.GetString(5);
                    Frm_inv_agregar.rutaresul = reader.GetString(6);
                    Inventario.Frm_modificar_inv.rutaresul2 = reader.GetString(6);
                    Bitmap imagen2 = new Bitmap(reader.GetString(6));
                    imagen.Image = imagen2;
                }
                else
                {
                    verificar = false;
                    nombre.Text = "";
                    descripcion.Text = "";
                    precio.Text = "";
                    cantidad.Text = "";
                    imagen.Image = null;
                }

            }
            catch (Exception)
            {

            }
            return verificar;
        }
        public void Actualizar(string nombre, string descripcion, string precio, string cantidad, string foto, string codigo)
        {
            try
            {

                string query = "UPDATE `tb_productos` SET `nombre`='"+nombre+ "',`descripcion`='"+descripcion+"',`precio`='"+precio+"',`cantidad`='"+cantidad+"',`foto`='"+foto+"' WHERE codigo = " + codigo;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("se actualizo el producto");

            }
            catch (Exception)
            {
            }
        }
        public void Mostrar(DataGridView dgvINV)
        {
            try
            {
                string query = "SELECT `id_producto`, `codigo`, `nombre`, `descripcion`, `precio`, `cantidad`, `foto` FROM `tb_productos`";
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
                        dgvINV.Rows.Add(reader.GetString(2), reader.GetString(3), reader.GetString(4),null ,null,reader.GetString(1));
                    }
                }

            }
            catch (Exception)
            {
            }
        }
        public void Eliminar_prod(string Codig)
        {
            try
            {
                string query = "DELETE FROM `tb_productos` WHERE Codigo = " + Codig;
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("Se elimino el producto exitosamente");
            }
            catch (Exception)
            {
                
            }
        }
        
    }
}
