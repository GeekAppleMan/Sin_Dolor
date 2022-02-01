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

namespace Sin_Dolor.Formas
{
    public partial class EditarProducto : Form
    {
        MostrarProductos frmMostrarProductos = new MostrarProductos();

        public EditarProducto()
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

        string connectionString;
        MySqlConnection databaseConnection;
        DataSet dataS;

        public string editarID, editarNombre, editarDescripcion;
        public double editarPrecio;        

        bool yaUsado = false;

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            txtEditarProductoNombre.Text = editarNombre;
            txtEditarProductoDescripcion.Text = editarDescripcion;
            txtEditarProductoPrecio.Text = editarPrecio.ToString();

            //editarNombre = frmMostrarProductos.ProductoNombre;
            //editarDescripcion = frmMostrarProductos.ProductoDescripcion;
            //editarPrecio = frmMostrarProductos.ProductoPrecio;
        }

        //METODOS DEL LOAD
        #region
        private void txtEditarProductoNombre_Enter(object sender, EventArgs e)
        {
            if (txtEditarProductoNombre.Text == editarNombre)
            {
                txtEditarProductoNombre.Text = "";
                txtEditarProductoNombre.ForeColor = Color.Black;
            }
        }

        private void txtEditarProductoNombre_Leave(object sender, EventArgs e)
        {
            if (txtEditarProductoNombre.Text == "")
            {
                txtEditarProductoNombre.Text = editarNombre;
                txtEditarProductoNombre.ForeColor = Color.Silver;
            }
        }

        private void txtEditarProductoDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtEditarProductoDescripcion.Text == editarDescripcion)
            {
                txtEditarProductoDescripcion.Text = "";
                txtEditarProductoDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtEditarProductoDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtEditarProductoDescripcion.Text == "")
            {
                txtEditarProductoDescripcion.Text = editarDescripcion;
                txtEditarProductoDescripcion.ForeColor = Color.Silver;
            }
        }

        private void txtEditarProductoPrecio_Enter(object sender, EventArgs e)
        {
            if (txtEditarProductoPrecio.Text == editarPrecio.ToString())
            {
                txtEditarProductoPrecio.Text = "";
                txtEditarProductoPrecio.ForeColor = Color.Black;
            }
        }

        private void txtEditarProductoPrecio_Leave(object sender, EventArgs e)
        {
            if (txtEditarProductoPrecio.Text == "")
            {
                txtEditarProductoPrecio.Text = editarPrecio.ToString();
                txtEditarProductoPrecio.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void EditarProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (yaUsado == false)
            {
                frmMostrarProductos.Cargar();
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            yaUsado = true;

            databaseConnection.Open();

            MySqlCommand update = new MySqlCommand("UPDATE tb_productos SET nombre = '" + txtEditarProductoNombre.Text + "', " +
                                                    "descripcion = '" + txtEditarProductoDescripcion.Text + "', " + 
                                                    "precio = '" + txtEditarProductoPrecio.Text + "', " +
                                                    "foto = '" + lblFotoNombre.Text + "' " +
                                                    "WHERE id_paciente = " + editarID, databaseConnection);

            MySqlDataAdapter modificar_datos = new MySqlDataAdapter(update);
            dataS = new DataSet();
            modificar_datos.Fill(dataS);

            frmMostrarProductos.Cargar();

            MessageBox.Show("Modificacion exitosa");

            databaseConnection.Close();
            this.Close();
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Imagenes|*.jpg; *.png";
            buscador.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            buscador.Title = "Selecciona una imagen";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                string filename = Path.GetFileName(buscador.FileName);
                lblFotoNombre.Text = filename;
                lblFotoNombre.Visible = true;
                pictureBoxEditarProducto.Visible = true;
                pictureBoxEditarProducto.Image = Image.FromFile(buscador.FileName);
            }
        }
    }
}
