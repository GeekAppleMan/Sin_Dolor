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
using Sin_Dolor.Formas;

namespace Sin_Dolor
{
    public partial class MostrarPacientes : Form
    {
        string connectionString;
        MySqlConnection databaseConnection;
        DataSet ds;

        public string PacienteNombre, PacienteApellidoP, PacienteApellidoM, PacienteCorreo;
        public int PacienteTelefono;

        public MostrarPacientes()
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

        private void MostrarPacientes_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSize = true;
            dataGridView1.Dock = DockStyle.Fill;
            //dataGridView1.DataSource = objeto.SeleccionarTablaPacientes();
            Cargar();
        }

        public void Cargar()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            MySqlCommand mostrarPaciente = new MySqlCommand("SELECT * FROM tb_pacientes;", databaseConnection);

            DataTable sqlDT = new DataTable();
            MySqlDataReader reader;

            MySqlDataAdapter m_Pacientes = new MySqlDataAdapter(mostrarPaciente);
            ds = new DataSet();
            m_Pacientes.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            DataGridViewButtonColumn btngridModificar = new DataGridViewButtonColumn();
            btngridModificar.Name = "Modificar";
            btngridModificar.Text = "Modificar";
            dataGridView1.Columns.Add(btngridModificar);

            DataGridViewButtonColumn btngridEliminar = new DataGridViewButtonColumn();
            btngridEliminar.Name = "Eliminar";
            btngridEliminar.Text = "Eliminar";
            dataGridView1.Columns.Add(btngridEliminar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MySqlDataReader agregarDato;

                string ID = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                databaseConnection.Open();

                EditarPaciente frmEditarPaciente = new EditarPaciente();

                MySqlCommand comandoID = new MySqlCommand("SELECT id_paciente FROM tb_pacientes WHERE id_paciente= '" + ID + "'", databaseConnection);
                agregarDato = comandoID.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarPaciente.editarID = agregarDato["id_paciente"].ToString();
                }
                databaseConnection.Close();
                databaseConnection.Open();

                MySqlCommand EnviarNombre = new MySqlCommand("SELECT nombre FROM tb_pacientes WHERE id_paciente= '" + ID + "'", databaseConnection);
                agregarDato = EnviarNombre.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarPaciente.editarNombre = agregarDato["nombre"].ToString();
                    PacienteNombre = agregarDato["nombre"].ToString();
                }
                databaseConnection.Close();
                databaseConnection.Open();

                MySqlCommand EnviarApellidoP = new MySqlCommand("SELECT apellido_paterno FROM tb_pacientes WHERE id_paciente= '" + ID + "'", databaseConnection);
                agregarDato = EnviarApellidoP.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarPaciente.editarApellidoP = agregarDato["apellido_paterno"].ToString();
                    PacienteApellidoP = agregarDato["apellido_paterno"].ToString();
                }
                databaseConnection.Close();
                databaseConnection.Open();

                MySqlCommand EnviarApellidoM = new MySqlCommand("SELECT apellido_materno FROM tb_pacientes WHERE id_paciente= '" + ID + "'", databaseConnection);
                agregarDato = EnviarApellidoM.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarPaciente.editarApellidoM = agregarDato["apellido_materno"].ToString();
                    PacienteApellidoM = agregarDato["apellido_materno"].ToString();
                }
                databaseConnection.Close();
                databaseConnection.Open();

                MySqlCommand EnviarTelefono = new MySqlCommand("SELECT telefono FROM tb_pacientes WHERE id_paciente= '" + ID + "'", databaseConnection);
                agregarDato = EnviarTelefono.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarPaciente.editarNumTelefono = Convert.ToInt32(agregarDato["telefono"].ToString());
                    PacienteTelefono = Convert.ToInt32(agregarDato["telefono"].ToString());
                }
                databaseConnection.Close();
                databaseConnection.Open();

                MySqlCommand EnviarCorreo = new MySqlCommand("SELECT correo FROM tb_pacientes WHERE id_paciente= '" + ID + "'", databaseConnection);
                agregarDato = EnviarCorreo.ExecuteReader();
                while (agregarDato.Read())
                {
                    frmEditarPaciente.editarCorreo = agregarDato["correo"].ToString();
                    PacienteCorreo = agregarDato["correo"].ToString();
                }
                databaseConnection.Close();

                frmEditarPaciente.Show();
            }

            if (e.ColumnIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Desea eliminar el registro", "VERIFICACION", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlDataReader eliminarDato;

                    string ID = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    databaseConnection.Open();

                    MySqlCommand comandoDELETE = new MySqlCommand("DELETE FROM tb_pacientes WHERE id_paciente= '" + ID + "'", databaseConnection);
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