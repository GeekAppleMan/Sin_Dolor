using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_dolor
{
    public partial class Frm_agregar_producto : Form
    {
        public static string id_producto;
        public static int cantidad;
        public static int preciototal;
        public static bool modificar { get; set; }
        public Frm_agregar_producto()
        {
            InitializeComponent();
        }

        private void Frm_agregar_producto_Load(object sender, EventArgs e)
        {
            cantidad = 0;
        }

        private void txtcodigo_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                verificar_producto();
            }
        }

        public void verificar_producto()
        {
            new Cls_Consultas().verificar_producto(txtcodigo_producto.Text,txtnombre_producto,rich_descripcion,txt_precio,txt_stock,picture_foto);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            verificar_producto();
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Tiene que agregar almenos 1 producto");
            }
            else
            {
                if (modificar == true)
                {
                    cantidad = Convert.ToInt32(numericUpDown1.Value);
                    preciototal = Convert.ToInt32(txt_precio.Text) * Convert.ToInt32(numericUpDown1.Value);
                    modificar = false;
                    this.Close();
                }
                else if(modificar == false)
                {
                    Frm_Registrar.productos.Rows.Add(id_producto, txtcodigo_producto.Text, txtnombre_producto.Text, numericUpDown1.Value.ToString(), txt_precio.Text, Convert.ToInt32(txt_precio.Text) * numericUpDown1.Value);
                    id_producto = null;
                    txtcodigo_producto.Text = null;
                    txtnombre_producto.Text = null;
                    numericUpDown1.Value = 1;
                    txt_precio.Text = null;
                    txt_stock.Text = null;
                    picture_foto.Image = null;
                    rich_descripcion.Text = null;
                    modificar = false;
                    this.Close();
                }
            }
        }

        private void txtcodigo_producto_Leave(object sender, EventArgs e)
        {
            verificar_producto();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value >= Convert.ToInt32(txt_stock.Text))
                {
                    numericUpDown1.Value = Convert.ToInt32(txt_stock.Text);
                    MessageBox.Show("Se han seleccionado todo el stock disponible");
                }
                if (numericUpDown1.Value < 0)
                {
                    numericUpDown1.Value = 1;
                }
            }
            catch (Exception)
            {

            }
           
        }
    }
}
