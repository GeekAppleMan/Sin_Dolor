using MySql.Data.MySqlClient;
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
    public partial class Frm_ModificarPaciente : Form
    {
        public Frm_ModificarPaciente()
        {
            InitializeComponent();
            Cls_Pacientes.frm_modificar = this;
        }

        public static string id_paciente,editarNombre, editarDomicilio, editarFechaNacimiento, editarTelefono, editarRecomendacion;

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Frm_ModificarPaciente_Load(object sender, EventArgs e)
        {
            txtPacienteNombre.Text = editarNombre;
            txtPacienteDomicilio.Text = editarDomicilio;
            dateTimePicker1.Value = Convert.ToDateTime(editarFechaNacimiento);
            txtPacienteTelefono.Text = editarTelefono;
            cmbRecomendado.Text = editarRecomendacion;
            new Cls_Pacientes().Recomendado_por(cmbRecomendado);

        }        

        private void btnPacienteRegistrar_Click(object sender, EventArgs e)
        {
            new Cls_Pacientes().Modificar_Paciente(id_paciente,txtPacienteNombre.Text,txtPacienteDomicilio.Text,dateTimePicker1.Value.ToString("d"),txtPacienteTelefono.Text,cmbRecomendado.Text);
        }
    }
}
