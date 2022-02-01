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

namespace Sin_Dolor.Formas
{
    public partial class Buscador : Form
    {
        string connectionString;
        MySqlConnection databaseConnection;
        DataSet ds;

        public string PacienteNombre, PacienteApellidoP, PacienteApellidoM, PacienteCorreo;
        public int PacienteTelefono;

        public string ProductoNombre, ProductoDescripcion;

        AgregarConsulta AgrConsulta = new AgregarConsulta();
        public string cadena;

        public double ProductoPrecio;

        bool pacientes = false, productos = false;

        //OTROS FORMS
        #region
        //AgregarConsulta AgrCon;
        //AgregarPaciente AgrPac;
        //AgregarProducto AgrPro;

        MostrarConsulta MostCon;
        //MostrarPacientes MostPac;
        //MostrarProductos MostPro;

        Inicio Inicio;

        //Buscador browser;

        //bool AgrConForm = false,
        //     AgrPacForm = false,
        //     AgrProForm = false,

        //     MostConForm = false,
        //     MostPacForm = false,
        //     MostProForm = false,

        //     browserForm = false;
        #endregion

        public Buscador()
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

        //CARGAR DATAGRID
        #region
        public void CargarProductos()
        {
            productos = true;
            pacientes = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            MySqlCommand mostrarPaciente = new MySqlCommand("SELECT * FROM tb_productos;", databaseConnection);

            MySqlDataAdapter m_Pacientes = new MySqlDataAdapter(mostrarPaciente);
            ds = new DataSet();
            m_Pacientes.Fill(ds);

            DataTable dt = new DataTable();
            m_Pacientes.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        public void CargarPacientes()
        {
            pacientes = true;
            productos = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            MySqlCommand mostrarPaciente = new MySqlCommand("SELECT * FROM tb_pacientes;", databaseConnection);

            MySqlDataAdapter m_Pacientes = new MySqlDataAdapter(mostrarPaciente);
            ds = new DataSet();
            m_Pacientes.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        #endregion

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (pacientes == true)
            {
                cadena = dataGridView1.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //AgrConsulta.btnSeleccionarPaciente.Text = cadena;
                //AgrConsulta.btnSeleccionarPaciente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[3].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Program.PacienteNombreCompleto = cadena;
                this.Close();
                //MessageBox.Show(Program.PacienteNombreCompleto);
                //AgrConsulta.btnSeleccionarPaciente.Text = Program.PacienteNombreCompleto;
                //AgrConsulta.nombre = cadena;
                //AgrConsulta.lblprueba.Text = Program.PacienteNombreCompleto;                
            }
            if (productos == true)
            {
                AgrConsulta.dataGridViewListado.Rows.Add(new string[] {
                dataGridView1[0, Convert.ToInt32(dataGridView1.CurrentRow.Cells[2])].Value.ToString(),
                dataGridView1[1, Convert.ToInt32(dataGridView1.CurrentRow.Cells[4])].Value.ToString()
                });
            }
        }
        
        private void Buscador_FormClosing(object sender, FormClosingEventArgs e)
        {
            AgrConsulta = new AgregarConsulta();
            AgrConsulta.Show();
            //AgrConsulta.Close();
            ////Inicio = new Inicio();
            ////Inicio.AgrConForm = true;
            ////Inicio.CerrarTodo();
            //AgrConsulta.Hide();
            //Inicio.F5AgrCon();
        }
    }
}
