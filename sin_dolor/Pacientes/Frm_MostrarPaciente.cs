using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using sin_dolor;
using sin_dolor.Pacientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_dolor
{
    public partial class Frm_MostrarPaciente : Form
    {
        
        public Frm_MostrarPaciente()
        {
            InitializeComponent(); 
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Frm_DataGridPacientes frmData = new Frm_DataGridPacientes();
            frmData.Show();
        }

        private void Frm_MostrarPaciente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            dgv_pacientes.Rows.Clear();
            new Cls_Pacientes().Mostrar_Paciente(dgv_pacientes);
        }

        private void dgv_pacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                Frm_ModificarPaciente.id_paciente = dgv_pacientes[0, e.RowIndex].Value.ToString();
                Frm_ModificarPaciente.editarNombre = dgv_pacientes[1, e.RowIndex].Value.ToString();
                Frm_ModificarPaciente.editarDomicilio = dgv_pacientes[2, e.RowIndex].Value.ToString();
                Frm_ModificarPaciente.editarFechaNacimiento = dgv_pacientes[3, e.RowIndex].Value.ToString();
                Frm_ModificarPaciente.editarTelefono = dgv_pacientes[4, e.RowIndex].Value.ToString();
                Frm_ModificarPaciente.editarRecomendacion = dgv_pacientes[5, e.RowIndex].Value.ToString();
                new Frm_ModificarPaciente().ShowDialog();
                cargar();

            }
            if (e.ColumnIndex == 7 && e.RowIndex != -1)
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al paciente?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new Cls_Pacientes().Eliminar_paciente(dgv_pacientes[0, e.RowIndex].Value.ToString());
                    cargar();
                }
              
            }
        }
    }
}
