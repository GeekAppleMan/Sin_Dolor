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

namespace Sin_Dolor.Formas
{
    public partial class EditarPaciente : Form
    {
        MostrarPacientes frmMostrarPacientes = new MostrarPacientes();

        string connectionString;
        MySqlConnection databaseConnection;
        DataSet dataS;

        public EditarPaciente()
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

        public string editarID, editarNombre, editarApellidoP, editarApellidoM, editarCorreo;
        public int editarNumTelefono;

        bool yaUsado = false;

        //EVENTOS Y PROPIEDADES
        #region
        private void txtEditarPacienteNombre_Enter(object sender, EventArgs e)
        {
            if (txtEditarPacienteNombre.Text == editarNombre)
            {
                txtEditarPacienteNombre.Text = "";
                txtEditarPacienteNombre.ForeColor = Color.Black;
            }
        }

        private void txtEditarPacienteNombre_Leave(object sender, EventArgs e)
        {
            if (txtEditarPacienteNombre.Text == "")
            {
                txtEditarPacienteNombre.Text = editarNombre;
                txtEditarPacienteNombre.ForeColor = Color.Silver;
            }
        }

        private void txtEditarPacienteApellidoPaterno_Enter(object sender, EventArgs e)
        {
            if (txtEditarPacienteApellidoPaterno.Text == editarApellidoP)
            {
                txtEditarPacienteApellidoPaterno.Text = "";
                txtEditarPacienteApellidoPaterno.ForeColor = Color.Black;
            }
        }

        private void txtEditarPacienteApellidoPaterno_Leave(object sender, EventArgs e)
        {
            if (txtEditarPacienteApellidoPaterno.Text == "")
            {
                txtEditarPacienteApellidoPaterno.Text = editarApellidoP;
                txtEditarPacienteApellidoPaterno.ForeColor = Color.Silver;
            }
        }

        private void txtEditarPacienteApellidoMaterno_Enter(object sender, EventArgs e)
        {
            if (txtEditarPacienteNombre.Text == editarApellidoM)
            {
                txtEditarPacienteApellidoMaterno.Text = "";
                txtEditarPacienteApellidoMaterno.ForeColor = Color.Black;
            }
        }

        private void txtEditarPacienteApellidoMaterno_Leave(object sender, EventArgs e)
        {
            if (txtEditarPacienteApellidoMaterno.Text == "")
            {
                txtEditarPacienteApellidoMaterno.Text = editarApellidoM;
                txtEditarPacienteApellidoMaterno.ForeColor = Color.Silver;
            }
        }

        private void txtEditarPacienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEditarPacienteTelefono_Enter(object sender, EventArgs e)
        {
            if (txtEditarPacienteTelefono.Text == editarNumTelefono.ToString())
            {
                txtEditarPacienteTelefono.Text = "";
                txtEditarPacienteTelefono.ForeColor = Color.Black;
            }
        }

        private void txtEditarPacienteTelefono_Leave(object sender, EventArgs e)
        {
            if (txtEditarPacienteTelefono.Text == "")
            {
                txtEditarPacienteTelefono.Text = editarNumTelefono.ToString();
                txtEditarPacienteTelefono.ForeColor = Color.Silver;
            }
        }

        private void EditarPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (yaUsado == false)
            {
                frmMostrarPacientes.Cargar();
            }
        }

        private void txtEditarPacienteCorreo_Enter(object sender, EventArgs e)
        {
            if (txtEditarPacienteCorreo.Text == editarCorreo)
            {
                txtEditarPacienteCorreo.Text = "";
                txtEditarPacienteCorreo.ForeColor = Color.Black;
            }
        }

        private void txtEditarPacienteCorreo_Leave(object sender, EventArgs e)
        {
            if (txtEditarPacienteCorreo.Text == "")
            {
                txtEditarPacienteCorreo.Text = editarCorreo;
                txtEditarPacienteCorreo.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void EditarPaciente_Load(object sender, EventArgs e)
        {
            txtEditarPacienteNombre.Text = editarNombre;
            txtEditarPacienteApellidoPaterno.Text = editarApellidoP;
            txtEditarPacienteApellidoMaterno.Text = editarApellidoM;
            txtEditarPacienteTelefono.Text = editarNumTelefono.ToString();
            txtEditarPacienteCorreo.Text = editarCorreo;
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            yaUsado = true;

            databaseConnection.Open();

            MySqlCommand update = new MySqlCommand("UPDATE tb_pacientes SET nombre = '" + txtEditarPacienteNombre.Text + "', " +
                                                    "apellido_paterno = '" + txtEditarPacienteApellidoPaterno.Text + "', " +
                                                    "apellido_materno = '" + txtEditarPacienteApellidoMaterno.Text + "', " +
                                                    "telefono = '" + txtEditarPacienteTelefono.Text + "', " +
                                                    "correo = '" + txtEditarPacienteCorreo.Text + "' " +
                                                    "WHERE id_paciente = " + editarID, databaseConnection);

            MySqlDataAdapter modificar_datos = new MySqlDataAdapter(update);
            dataS = new DataSet();
            modificar_datos.Fill(dataS);

            MessageBox.Show("Modificacion exitosa");

            databaseConnection.Close();
            this.Close();

            frmMostrarPacientes.Cargar();
        }
    }
}
