using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sin_Dolor.Formas
{
    public partial class Inicio : Form
    {
        AgregarConsulta AgrCon = new AgregarConsulta();
        AgregarPaciente AgrPac = new AgregarPaciente();
        AgregarProducto AgrPro = new AgregarProducto();

        MostrarConsulta MostCon = new MostrarConsulta();
        MostrarPacientes MostPac = new MostrarPacientes();
        MostrarProductos MostPro = new MostrarProductos();

        Buscador browser = new Buscador();

        public bool AgrConForm = false,
                    AgrPacForm = false,
                    AgrProForm = false,

                    MostConForm = false,
                    MostPacForm = false,
                    MostProForm = false,

                    browserForm = false;

        public Inicio()
        {
            InitializeComponent();
            ocultarPaneles();
            //Form = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //panelGeneral.AutoSize = true;
            //panelGeneral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public void ocultarPaneles()
        {
            panelPacientes.Visible = false;
            panelInventario.Visible = false;
            panelConsultas.Visible = false;
        }

        //MOSTRAR SUS RESPECTIVOS BOTONES
        #region
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            if (panelConsultas.Visible == true)
            {
                panelConsultas.Visible = false;
            }
            else
            {
                panelConsultas.Visible = true;
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            if (panelPacientes.Visible == true)
            {
                panelPacientes.Visible = false;
            }
            else
            {
                panelPacientes.Visible = true;
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (panelInventario.Visible == true)
            {
                panelInventario.Visible = false;
            }
            else
            {
                panelInventario.Visible = true;
            }
        }
        #endregion

        public void CerrarTodo()
        {
            if (AgrConForm == true)
            {
                AgrCon.Close();
                AgrConForm = false;
            }
            if (AgrPacForm == true)
            {
                AgrPac.Close();
                AgrPacForm = false;
            }
            if (AgrProForm == true)
            {
                AgrPro.Close();
                AgrProForm = false;
            }
            if (MostConForm == true)
            {
                MostCon.Close();
                MostConForm = false;
            }
            if (MostPacForm == true)
            {
                MostPac.Close();
                MostPacForm = false;
            }
            if (MostProForm == true)
            {
                MostPro.Close();
                MostProForm = false;
            }
            if (browserForm == true)
            {
                browser.Close();
                browserForm = false;
            }
        }       

        private void btnCerrarFormas_Click(object sender, EventArgs e)
        {
            //if (AgrConForm == true)
            //{
            //    AgrCon.Close();
            //    AgrConForm = false;
            //}
            //if (AgrPacForm == true)
            //{
            //    AgrPac.Close();
            //    AgrPacForm = false;
            //}
            //if (AgrProForm == true)
            //{
            //    AgrPro.Close();
            //    AgrProForm = false;
            //}
            //if (MostConForm == true)
            //{
            //    MostCon.Close();
            //    MostConForm = false;
            //}
            //if (MostPacForm == true)
            //{
            //    MostPac.Close();
            //    MostPacForm = false;
            //}
            //if (MostProForm == true)
            //{
            //    MostPro.Close();
            //    MostProForm = false;
            //}
            //if (browserForm == true)
            //{
            //    browser.Close();
            //    browserForm = false;
            //}

            //panelGeneral.Refresh();
            //AgrCon.Refresh();
        }

        private void btnConsultasAgregar_Click(object sender, EventArgs e)
        {
            if (AgrConForm == false)
            {
                AgrCon = new AgregarConsulta() { TopLevel = false, TopMost = true };
                AgrCon.FormBorderStyle = FormBorderStyle.None;
                AgrCon.Dock = DockStyle.Fill;
                AgrCon.AutoSize = true;
                AgrCon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                panelGeneral.Size = new System.Drawing.Size(AgrCon.Width, AgrCon.Height);

                this.panelGeneral.Controls.Add(AgrCon);
                AgrCon.Show();                

                AgrConForm = true;
            }
            else
            {
                AgrCon.Close();
                AgrConForm = false;
            }

            //OTROS FORMS
            #region
            if (AgrPacForm == true)
            {
                AgrPac.Close();
                AgrPacForm = false;
            }
            if (AgrProForm == true)
            {
                AgrPro.Close();
                AgrProForm = false;
            }
            if (MostConForm == true)
            {
                MostCon.Close();
                MostConForm = false;
            }
            if (MostPacForm == true)
            {
                MostPac.Close();
                MostPacForm = false;
            }
            if (MostProForm == true)
            {
                MostPro.Close();
                MostProForm = false;
            }
            if (browserForm == true)
            {
                browser.Close();
                browserForm = false;
            }            
            #endregion
        }

        private void btnConsultasMostrar_Click(object sender, EventArgs e)
        {
            if (MostConForm == false)
            {
                MostCon = new MostrarConsulta() { TopLevel = false, TopMost = true };
                MostCon.FormBorderStyle = FormBorderStyle.None;
                MostCon.Dock = DockStyle.Fill;
                panelGeneral.Size = new System.Drawing.Size(MostCon.Width, MostCon.Height);
                this.panelGeneral.Controls.Add(MostCon);
                MostCon.Show();
                
                MostConForm = true;
            }
            else
            {
                MostCon.Close();
                MostConForm = false;
            }

            //OTROS FORMS
            #region
            if (AgrConForm == true)
            {
                AgrCon.Close();
                AgrConForm = false;
            }
            if (AgrPacForm == true)
            {
                AgrPac.Close();
                AgrPacForm = false;
            }
            if (AgrProForm == true)
            {
                AgrPro.Close();
                AgrProForm = false;
            }
            if (MostPacForm == true)
            {
                MostPac.Close();
                MostPacForm = false;
            }
            if (MostProForm == true)
            {
                MostPro.Close();
                MostProForm = false;
            }
            if (browserForm == true)
            {
                browser.Close();
                browserForm = false;
            }
            #endregion
        }

        private void btnPacientesAgregar_Click(object sender, EventArgs e)
        {
            if (AgrPacForm == false)
            {
                AgrPac = new AgregarPaciente() { TopLevel = false, TopMost = true };
                AgrPac.FormBorderStyle = FormBorderStyle.None;
                panelGeneral.Size = new System.Drawing.Size(AgrPac.Width, AgrPac.Height);
                this.panelGeneral.Controls.Add(AgrPac);
                AgrPac.Show();

                AgrPacForm = true;
            }
            else
            {
                AgrPac.Close();
                AgrPacForm = false;
            }
            //OTROS FORMS
            #region
            if (AgrConForm == true)
            {
                AgrCon.Close();
                AgrConForm = false;
            }
            if (AgrProForm == true)
            {
                AgrPro.Close();
                AgrProForm = false;
            }
            if (MostConForm == true)
            {
                MostCon.Close();
                MostConForm = false;
            }
            if (MostPacForm == true)
            {
                MostPac.Close();
                MostPacForm = false;
            }
            if (MostProForm == true)
            {
                MostPro.Close();
                MostProForm = false;
            }
            if (browserForm == true)
            {
                browser.Close();
                browserForm = false;
            }
            #endregion
        }

        private void btnPacientesMostrar_Click(object sender, EventArgs e)
        {
            if (MostPacForm == false)
            {
                MostPac = new MostrarPacientes() { TopLevel = false, TopMost = true };
                MostPac.FormBorderStyle = FormBorderStyle.None;
                panelGeneral.Size = new System.Drawing.Size(MostPac.Width, MostPac.Height);
                this.panelGeneral.Controls.Add(MostPac);
                MostPac.Show();                

                MostPacForm = true;
            }
            else
            {
                MostPac.Close();
                MostPacForm = false;
            }

            //OTROS FORMS
            #region
            if (AgrConForm == true)
            {
                AgrCon.Close();
                AgrConForm = false;
            }
            if (AgrPacForm == true)
            {
                AgrPac.Close();
                AgrPacForm = false;
            }
            if (AgrProForm == true)
            {
                AgrPro.Close();
                AgrProForm = false;
            }
            if (MostConForm == true)
            {
                MostCon.Close();
                MostConForm = false;
            }
            if (MostProForm == true)
            {
                MostPro.Close();
                MostProForm = false;
            }
            if (browserForm == true)
            {
                browser.Close();
                browserForm = false;
            }
            #endregion
        }

        private void btnInventarioAgregar_Click(object sender, EventArgs e)
        {
            if (AgrProForm == false)
            {
                AgrPro = new AgregarProducto() { TopLevel = false, TopMost = true };
                AgrPro.FormBorderStyle = FormBorderStyle.None;
                panelGeneral.Size = new System.Drawing.Size(AgrPro.Width, AgrPro.Height);
                this.panelGeneral.Controls.Add(AgrPro);
                AgrPro.Show();                

                AgrProForm = true;
            }
            else
            {
                AgrPro.Close();
                AgrProForm = false;
            }

            //OTROS FORMS
            #region
            if (AgrConForm == true)
            {
                AgrCon.Close();
                AgrConForm = false;
            }
            if (AgrPacForm == true)
            {
                AgrPac.Close();
                AgrPacForm = false;
            }
            if (MostConForm == true)
            {
                MostCon.Close();
                MostConForm = false;
            }
            if (MostPacForm == true)
            {
                MostPac.Close();
                MostPacForm = false;
            }
            if (MostProForm == true)
            {
                MostPro.Close();
                MostProForm = false;
            }
            if (browserForm == true)
            {
                browser.Close();
                browserForm = false;
            }
            #endregion
        }
 
        private void btnInventarioMostrar_Click(object sender, EventArgs e)
        {
            if (MostProForm == false)
            {
                MostPro = new MostrarProductos() { TopLevel = false, TopMost = true };
                MostPro.FormBorderStyle = FormBorderStyle.None;
                MostPro.Dock = DockStyle.Fill;
                panelGeneral.Size = new System.Drawing.Size(MostPro.Width, MostPro.Height);
                this.panelGeneral.Controls.Add(MostPro);
                MostPro.Show();                

                MostProForm = true;
            }
            else
            {
                MostPro.Close();
                MostProForm = false;
            }

            //OTROS FORMS
            #region
            if (AgrConForm == true)
            {
                AgrCon.Close();
                AgrConForm = false;
            }
            if (AgrPacForm == true)
            {
                AgrPac.Close();
                AgrPacForm = false;
            }
            if (AgrProForm == true)
            {
                AgrPro.Close();
                AgrProForm = false;
            }
            if (MostConForm == true)
            {
                MostCon.Close();
                MostConForm = false;
            }
            if (MostPacForm == true)
            {
                MostPac.Close();
                MostPacForm = false;
            }
            if (browserForm == true)
            {
                browser.Close();
                browserForm = false;
            }
            #endregion
        }
    }
}
