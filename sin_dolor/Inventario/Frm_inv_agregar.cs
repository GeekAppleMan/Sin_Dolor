using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sin_dolor;
using System.Windows.Forms;

namespace sin_dolor
{
    public partial class Frm_inv_agregar : Form
    {
       
        public Frm_inv_agregar()
        {
            InitializeComponent();
        }

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        TextBox txtRuta = new TextBox();
        public static string rutaresul { get; set; }
        private void ptbColor_Click(object sender, EventArgs e)
        {
            rutaresul = "";
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
                Bitmap btnImagen = new Bitmap(openFileDialog1.FileName);
                ptbImagen.Image = btnImagen;
                for (int i = 0; i < txtRuta.Text.Length; i++)
                {
                    if (txtRuta.Text.Substring(i, 1) == @"\")
                    {
                        rutaresul += "/";
                    }
                    else
                    {
                        rutaresul += txtRuta.Text.Substring(i, 1);
                    }
                }
            }
        }

        private void BtnFinRegistro_Click(object sender, EventArgs e)
        {
            if (txtNombreProd.Text.Length > 1 )
            {
                new Cls_Inventario().Registrar_Producto(txtNombreProd.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text,rutaresul,txtCodigo.Text);
                txtCodigo.Clear();
                txtNombreProd.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
                ptbImagen.Image = null;
            }
        }
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (new Cls_Inventario().Verificar_Codigo(txtCodigo.Text, txtNombreProd, txtDescripcion, txtPrecio, txtCantidad, ptbImagen) == true)
            {
                BtnFinRegistro.Visible = false;
                btnActualizar.Visible = true;
            }
            else
            {
                BtnFinRegistro.Visible = true;
                btnActualizar.Visible = false;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombreProd.Text.Length > 1)
            {
                new Cls_Inventario().Actualizar(txtNombreProd.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text, rutaresul, txtCodigo.Text);
            }
        }

        private void Frm_inv_modificar_Load(object sender, EventArgs e)
        {

        }
    }
}
