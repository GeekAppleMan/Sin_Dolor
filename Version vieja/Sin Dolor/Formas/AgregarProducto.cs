using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sin_Dolor
{
    public partial class AgregarProducto : Form
    {

        string connectionString;
        MySqlConnection databaseConnection;
        DataSet ds;

        public AgregarProducto()
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

        private void txtProductoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            string Nombre = txtProductoNombre.Text;
            string Descripcion = txtProductoDescripcion.Text;
            string Precio = txtProductoPrecio.Text;
            string FotoNombre = lblFotoNombre.Text;

            //MemoryStream ms = new MemoryStream();
            //pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            //byte[] aByte = ms.ToArray();

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Images|*.jpg ; *.png";
            ImageFormat format = ImageFormat.Jpeg;

            sv.FileName = lblFotoNombre.Text;

            if (sv.ShowDialog() == DialogResult.OK)
            {
                switch (sv.Filter)
                {
                    case ".jpg":
                        format = ImageFormat.Png;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }               

                pictureBox1.Image.Save(sv.FileName, format);
            }

            try
            {
                databaseConnection.Open();

                MySqlCommand mostrarPaciente = new MySqlCommand("INSERT INTO tb_productos (nombre, descripcion, precio, foto) " +
                                                                "VALUES ('" + Nombre + "', '" + Descripcion + "', '" + Precio + "', '" + FotoNombre + "');", databaseConnection);

                MySqlDataAdapter m_Paciente = new MySqlDataAdapter(mostrarPaciente);
                ds = new DataSet();
                m_Paciente.Fill(ds);
                databaseConnection.Close();

                MessageBox.Show("Registro Exitoso ☆⌒(≧▽​° )");

            }
            catch (Exception)
            {

                MessageBox.Show("NO SIRVIO, VALIENDO (╯°益°)╯彡┻━┻");
            }


            txtProductoNombre.Clear();
            txtProductoDescripcion.Clear();
            txtProductoPrecio.Clear();
            lblFotoNombre.Text = "-.-.-.-.-";
            lblFotoNombre.Visible = false;
            pictureBox1.Visible = false;
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
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(buscador.FileName);
            }
        }
    }
}
