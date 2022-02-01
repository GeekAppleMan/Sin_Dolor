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
    public partial class MostrarConsulta : Form
    {
        string connectionString;
        MySqlConnection databaseConnection;
        DataSet ds;

        public MostrarConsulta()
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            databaseConnection.Open();

            MySqlCommand mostrarPaciente = new MySqlCommand("SELECT paciente, hora FROM tb_consulta WHERE fecha = '" + fecha + "';", databaseConnection);

            MySqlDataAdapter m_Paciente = new MySqlDataAdapter(mostrarPaciente);
            ds = new DataSet();
            m_Paciente.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            databaseConnection.Close();
        }        
    }
}
