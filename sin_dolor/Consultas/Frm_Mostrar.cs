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
    public partial class Frm_Mostrar : Form
    {
        
        public Frm_Mostrar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Mostrar_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            new Cls_Consultas().mostrar_consulta(dgv_consulta, date_fecha.Value.ToString("d"));
        }
        private void date_fecha_ValueChanged(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
