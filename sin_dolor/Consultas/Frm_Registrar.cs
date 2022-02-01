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
    public partial class Frm_Registrar : Form
    {
        Frm_agregar_producto obj_agregar = new Frm_agregar_producto();
        public static DataGridView productos;
        private string id_paciente;
        public Frm_Registrar()
        {
            InitializeComponent();
        }

        private void txt_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_pago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_pago.Text))
                {
                    lbl_cambio_result.Text = "0.0";
                }
                else
                {
                    int total = Convert.ToInt32(lbl_total_resul.Text);
                    lbl_cambio_result.Text = (Convert.ToInt32(txt_pago.Text) - total).ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            obj_agregar.ShowDialog();
        }

        private void Frm_Registrar_Load(object sender, EventArgs e)
        {
            productos = dgv_productos;
            new Cls_Consultas().mostrar_pacientes(combo_pacientes);
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7 && e.RowIndex != -1)
                {
                    if (MessageBox.Show("¿Estas seguro que quieres eliminar el producto?","ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dgv_productos.Rows.RemoveAt(e.RowIndex);
                    } 
                }
                if (e.ColumnIndex == 6 && e.RowIndex != -1)
                {
                    if (MessageBox.Show("¿Estas seguro que quieres modificar el producto?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Frm_agregar_producto obj = new Frm_agregar_producto();
                        obj.txtcodigo_producto.Text = dgv_productos[1, e.RowIndex].Value.ToString();
                        obj.txtcodigo_producto.Enabled = false;
                        obj.verificar_producto();
                        obj.numericUpDown1.Value = Convert.ToInt32(dgv_productos[3, e.RowIndex].Value);
                        Frm_agregar_producto.modificar = true;
                        obj.ShowDialog();
                        dgv_productos[3, e.RowIndex].Value = Frm_agregar_producto.cantidad.ToString();
                        dgv_productos[5, e.RowIndex].Value = Frm_agregar_producto.preciototal.ToString();
                        calcular();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
        }
        
        private void calcular()
        {
            int total = 0;
            for (int i = 0; i < dgv_productos.Rows.Count; i++)
            {
                total += Convert.ToInt32(dgv_productos[5, i].Value);
            }
            lbl_total_resul.Text = total.ToString();
        }

        private void dgv_productos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcular();
        }

        private void dgv_productos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calcular();
        }

        private void combo_pacientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                id_paciente = Cls_Consultas.tablaid.Rows[combo_pacientes.SelectedIndex]["idpaciente"].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_finalizar_consulta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(combo_pacientes.Text) || string.IsNullOrEmpty(rich_tratamiento.Text))
            {
                MessageBox.Show("Debe seleccionar al paciente y agregar el tratamiento");
            }
            else
            {
                new Cls_Consultas().registrar_consulta(id_paciente, rich_tratamiento.Text);
                new Cls_Consultas().registrar_almacen(dgv_productos);
                combo_pacientes.Text = "";
                rich_tratamiento.Text = "";
                id_paciente = "";
                dgv_productos.Rows.Clear();
                lbl_cambio_result.Text = "0.0";
                lbl_cambio_result.Text = "0.0";
                txt_pago.Text = "";
            }
        }
    }
}
