using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sin_Dolor
{
    public partial class AgregarPaciente : Form
    {

        string connectionString;
        MySqlConnection databaseConnection;
        DataSet ds;

        public AgregarPaciente()
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

        private void txtPacienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPacienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPacienteApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPacienteApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string Nombre = txtPacienteNombre.Text;
                string Domicilio = txtPacienteDomicilio.Text;
                string fechaNacimiento = dateTimePacienteFechaNacimiento.Value.ToString("yyyy-MM-dd");
                string Telefono = txtPacienteTelefono.Text;
                string RecomendadoPor = cmbRecomendacion.Text;

                databaseConnection.Open();

                MySqlCommand mostrarPaciente = new MySqlCommand("INSERT INTO tb_pacientes (nombre, domicilio, fecha_nacimiento, telefono, recomendado_por) " +
                                                                "VALUES ('" + Nombre + "', '" + Domicilio + "', '" + fechaNacimiento + "', '" + Telefono + "', '" + RecomendadoPor + "');", databaseConnection);

                MySqlDataAdapter m_Paciente = new MySqlDataAdapter(mostrarPaciente);
                ds = new DataSet();
                m_Paciente.Fill(ds);
                databaseConnection.Close();

                MessageBox.Show("Registro Exitoso");

                txtPacienteNombre.Clear();
                txtPacienteDomicilio.Clear();
                txtPacienteTelefono.Clear();
            }
            else
            {
                MessageBox.Show("Favor de leer y aceptar las politicas de privacidad", "ADVERTENCIA");
            }
            
        }
    }
}
