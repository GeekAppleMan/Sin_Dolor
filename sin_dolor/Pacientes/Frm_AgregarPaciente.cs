using MySql.Data.MySqlClient;
using sin_dolor;
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
    public partial class Frm_AgregarPaciente : Form
    {
        public Frm_AgregarPaciente()
        {
            InitializeComponent();

        }

        private void txtPacienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPacienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPacienteRegistrar_Click(object sender, EventArgs e)
        {
            if (checkBoxLeido.Checked == true && txtPacienteNombre.Text != "" && txtPacienteDomicilio.Text != "" && txtPacienteTelefono.Text != "" && cmbRecomendado.Text != "")
            {
                string Nombre = txtPacienteNombre.Text;
                string Domicilio = txtPacienteDomicilio.Text;
                string fechaNacimiento = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string Telefono = txtPacienteTelefono.Text;
                string RecomendadoPor = cmbRecomendado.Text;

                new Cls_Pacientes().Registrar_Paciente(Nombre, Domicilio, fechaNacimiento, Telefono, RecomendadoPor);
                MessageBox.Show("Se registro el paciente ☆⌒(≧▽​° )");
                txtPacienteNombre.Clear();
                txtPacienteDomicilio.Clear();
                txtPacienteTelefono.Clear();                                
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos, leer y aceptar las politicas de privacidad", "ADVERTENCIA");
            }
        }

        private void checkBoxLeido_KeyDown(object sender, KeyEventArgs e)
        {
            CheckBox c1 = this.ActiveControl as CheckBox;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(c1))
            {                
                if (c1.Checked == true)
                {
                    c1.Checked = false;
                }
                else
                {
                    c1.Checked = true;
                }
            }                
        }

        private void btnPacienteRegistrar_KeyDown(object sender, KeyEventArgs e)
        {
            Button b1 = this.ActiveControl as Button;
            if (e.KeyData == Keys.Enter && this.ActiveControl.Equals(b1))
            {
                if (checkBoxLeido.Checked == true && txtPacienteNombre.Text != "" && txtPacienteDomicilio.Text != "" && txtPacienteTelefono.Text != "" && cmbRecomendado.Text != "")
                {
                    string Nombre = txtPacienteNombre.Text;
                    string Domicilio = txtPacienteDomicilio.Text;
                    string fechaNacimiento = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string Telefono = txtPacienteTelefono.Text;
                    string RecomendadoPor = cmbRecomendado.Text;

                    new Cls_Pacientes().Registrar_Paciente(Nombre, Domicilio, fechaNacimiento, Telefono, RecomendadoPor);
                    MessageBox.Show("Se registro el paciente ☆⌒(≧▽​° )");
                    txtPacienteNombre.Clear();
                    txtPacienteDomicilio.Clear();
                    txtPacienteTelefono.Clear();
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos, leer y aceptar las politicas de privacidad", "ADVERTENCIA");
                }
            }
        }

        private void Frm_AgregarPaciente_Load(object sender, EventArgs e)
        {
            new Cls_Pacientes().Recomendado_por(cmbRecomendado);
        }

    }
}
