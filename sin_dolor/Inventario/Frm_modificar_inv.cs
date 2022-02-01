using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_dolor.Inventario
{
    public partial class Frm_modificar_inv : Form
    {
        public static string codigo;
        public Frm_modificar_inv()
        {
            InitializeComponent();
        }

        private void Frm_modificar_inv_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = codigo;
            new Cls_Inventario().Verificar_Codigo(txtCodigo.Text, txtNombreProd, txtDescripcion, txtPrecio, txtCantidad, ptbImagen);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombreProd.Text.Length > 1)
            {
                new Cls_Inventario().Actualizar(txtNombreProd.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text, rutaresul2, txtCodigo.Text);
            }
            this.Close();
        }
        TextBox txtRuta = new TextBox();
        public static string rutaresul2 { get; set; }
        private void ptbColor_Click(object sender, EventArgs e)
        {
            rutaresul2 = "";
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
                        rutaresul2 += "/";
                    }
                    else
                    {
                        rutaresul2 += txtRuta.Text.Substring(i, 1);
                    }
                }
            }
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDescripcion.Text.Length >= 150)
            {
                e.Handled = true;
            }
            if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
        }
    }
}
