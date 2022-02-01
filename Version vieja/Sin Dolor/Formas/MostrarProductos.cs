using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sin_Dolor.Formas;

namespace Sin_Dolor
{
    public partial class MostrarProductos : Form
    {
        string connectionString;
        MySqlConnection databaseConnection;
        DataSet ds;

        public string ProductoNombre, ProductoDescripcion;
        public double ProductoPrecio;

        public MostrarProductos()
        {
            InitializeComponent();
            //CONECTAR A BD
            #region
            connectionString = "server=localhost; Database=bd_sin_dolor; uid=root; convert zero datetime=True";

            databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se encontro BD");
            }
            #endregion
        }

        private void MostrarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSize = true;            
            dataGridView1.Dock = DockStyle.Fill;
            Cargar();
        }

        public void Cargar()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            MySqlCommand mostrarPaciente = new MySqlCommand("SELECT * FROM tb_productos;", databaseConnection);

            MySqlDataAdapter m_Pacientes = new MySqlDataAdapter(mostrarPaciente);
            ds = new DataSet();
            m_Pacientes.Fill(ds);

            DataTable dt = new DataTable();
            m_Pacientes.Fill(dt);

            dataGridView1.DataSource = dt;

            DataGridViewButtonColumn btngridModificar = new DataGridViewButtonColumn();
            btngridModificar.Name = "Modificar";
            btngridModificar.Text = "Modificar";
            dataGridView1.Columns.Add(btngridModificar);

            DataGridViewButtonColumn btngridEliminar = new DataGridViewButtonColumn();
            btngridEliminar.Name = "Eliminar";
            btngridEliminar.Text = "Eliminar";
            dataGridView1.Columns.Add(btngridEliminar);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = dataGridView1.CurrentCell.ColumnIndex;
            if (e.ColumnIndex == 6)
            {
                ImagenProducto MostrarFoto = new ImagenProducto();
                string nombreImagen = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Image img;
                img = Image.FromFile(@"C:\Users\GabsPC\Documents\residencias-programas\Sin Dolor\Imagenes\" + nombreImagen);
                MostrarFoto.pictureBoxProducto.Image = img;
                MostrarFoto.ShowDialog();
            }            

            if (e.ColumnIndex == 0)
            {
                MySqlDataReader agregarDato;

                string ID = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                databaseConnection.Open();

                EditarProducto frmEditarProducto = new EditarProducto();

                MySqlCommand comandoID = new MySqlCommand("SELECT id_producto FROM tb_productos WHERE id_producto= '" + ID + "'", databaseConnection);
                agregarDato = comandoID.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarProducto.editarID = agregarDato["id_producto"].ToString();
                }
                databaseConnection.Close();
                databaseConnection.Open();

                MySqlCommand EnviarNombre = new MySqlCommand("SELECT nombre FROM tb_productos WHERE id_producto= '" + ID + "'", databaseConnection);
                agregarDato = EnviarNombre.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarProducto.editarNombre = agregarDato["nombre"].ToString();
                    ProductoNombre = agregarDato["nombre"].ToString();
                }
                databaseConnection.Close();
                databaseConnection.Open();

                MySqlCommand EnviarDescripcion = new MySqlCommand("SELECT descripcion FROM tb_productos WHERE id_producto= '" + ID + "'", databaseConnection);
                agregarDato = EnviarDescripcion.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarProducto.editarDescripcion = agregarDato["descripcion"].ToString();
                    ProductoDescripcion = agregarDato["descripcion"].ToString();
                }
                databaseConnection.Close();
                databaseConnection.Open();

                MySqlCommand EnviarPrecio = new MySqlCommand("SELECT precio FROM tb_productos WHERE id_producto= '" + ID + "'", databaseConnection);
                agregarDato = EnviarPrecio.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarProducto.editarPrecio = Convert.ToDouble(agregarDato["precio"].ToString());
                    ProductoPrecio = Convert.ToDouble(agregarDato["precio"]);
                }
                databaseConnection.Close();
                
                frmEditarProducto.Show();
            }

            if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro", "VERIFICACION", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlDataReader eliminarDato;

                    string ID = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    databaseConnection.Open();

                    MySqlCommand comandoDELETE = new MySqlCommand("DELETE FROM tb_productos WHERE id_producto= '" + ID + "'", databaseConnection);
                    eliminarDato = comandoDELETE.ExecuteReader();

                    databaseConnection.Close();

                    Cargar();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("ENTONCES NO ME HAGAS PERDER EL TIEMPO (╯°益°)╯彡┻━┻");
                }                
            }
        }
    }
}