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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrir_form(object formhijo)
        {
            if (this.panel_contenedor.Controls.Count == 0)
            {
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_contenedor.Controls.Add(fh);
                this.panel_contenedor.Tag = fh;
                fh.Show();
            }
            else
            {
                this.panel_contenedor.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel_contenedor.Controls.Add(fh);
                this.panel_contenedor.Tag = fh;
                fh.Show();
            }
        }

        private void lbl_consultas_Click(object sender, EventArgs e)
        {
            if (btn_mostrar.Visible == true && btn_registrar.Visible == true)
            {
                btn_mostrar.Visible = false;
                btn_registrar.Visible = false;
                btn_mostrar_pacientes.Visible = false;
                btn_registrar_pacientes.Visible = false;
                btn_mostrar_inventario.Visible = false;
                btn_registrar_inventario.Visible = false;
            }
            else
            {
                btn_mostrar.Visible = true;
                btn_registrar.Visible = true;
                btn_mostrar_pacientes.Visible = false;
                btn_registrar_pacientes.Visible = false;
                btn_mostrar_inventario.Visible = false;
                btn_registrar_inventario.Visible = false;
            }
           
        }

        private void lbl_pacientes_Click(object sender, EventArgs e)
        {
            if (btn_mostrar_pacientes.Visible == true && btn_registrar_pacientes.Visible == true)
            {
                btn_mostrar.Visible = false;
                btn_registrar.Visible = false;
                btn_mostrar_pacientes.Visible = false;
                btn_registrar_pacientes.Visible = false;
                btn_mostrar_inventario.Visible = false;
                btn_registrar_inventario.Visible = false;
            }
            else
            {
                btn_mostrar.Visible = false;
                btn_registrar.Visible = false;
                btn_mostrar_pacientes.Visible = true;
                btn_registrar_pacientes.Visible = true;
                btn_mostrar_inventario.Visible = false;
                btn_registrar_inventario.Visible = false;
            }
           
        }

        private void lbl_inventario_Click(object sender, EventArgs e)
        {
            if (btn_mostrar_inventario.Visible == true && btn_registrar_inventario.Visible == true)
            {
                btn_mostrar.Visible = false;
                btn_registrar.Visible = false;
                btn_mostrar_pacientes.Visible = false;
                btn_registrar_pacientes.Visible = false;
                btn_mostrar_inventario.Visible = false;
                btn_registrar_inventario.Visible = false;
            }
            else
            {
                btn_mostrar.Visible = false;
                btn_registrar.Visible = false;
                btn_mostrar_pacientes.Visible = false;
                btn_registrar_pacientes.Visible = false;
                btn_mostrar_inventario.Visible = true;
                btn_registrar_inventario.Visible = true;
            }
            
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Consulta nueva";
            abrir_form(new Frm_Registrar());
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Bitacora de consultas";
            abrir_form(new Frm_Mostrar());
        }

        private void btn_registrar_pacientes_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Nuevo Paciente";
            abrir_form(new Frm_AgregarPaciente());
        }

        private void btn_mostrar_pacientes_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Mostrar Pacientes";
            abrir_form(new Frm_MostrarPaciente());
        }
        
        public void btn_registrar_inventario_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Registrar Producto";
            abrir_form(new Frm_inv_agregar());
        }

        private void btn_mostrar_inventario_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Reporte de inventario";
            abrir_form(new Frm_inv_mostrar());
        }
    }
}
