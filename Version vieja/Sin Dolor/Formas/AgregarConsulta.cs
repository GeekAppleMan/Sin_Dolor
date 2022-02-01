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
    public partial class AgregarConsulta : Form
    {
        string connectionString;
        MySqlConnection databaseConnection;
        DataSet ds;

        int cantidad;
        double preUnit, preFinal;

        //AgregarConsulta AgrCon = new AgregarConsulta();

        public AgregarConsulta()
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
            //CARGAR COMBOBOX
            #region
            string selectQuery = "SELECT * FROM tb_pacientes";
            databaseConnection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbPaciente.Items.Add(reader.GetString("nombre"));
                cmbPaciente.SelectedValue = "nombre";
            }
            databaseConnection.Close();
            #endregion
            CargarProductos();
        }
        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            panelSeleccionarProducto.Visible = true;
        }

        public void CargarProductos()
        {
            dataGridViewProductos.Columns.Clear();
            dataGridViewProductos.Refresh();

            MySqlCommand mostrarProducto = new MySqlCommand("SELECT * FROM tb_productos;", databaseConnection);

            MySqlDataAdapter m_Producto = new MySqlDataAdapter(mostrarProducto);
            ds = new DataSet();
            m_Producto.Fill(ds);

            DataTable dt = new DataTable();
            m_Producto.Fill(dt);

            dataGridViewProductos.DataSource = dt;
        }

        private void dataGridViewProductos_DoubleClick(object sender, EventArgs e)
        {
            dataGridViewListado.Rows.Add(dataGridViewProductos.CurrentRow.Cells[1].Value, dataGridViewProductos.CurrentRow.Cells[3].Value);
            panelSeleccionarProducto.Visible = false;
            //AgrCon.Resize(671, 623);
        }

        private void dataGridViewListado_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //// only allow one decimal point
            //if (e.KeyChar == '.'
            //    && (sender as TextBox).Text.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}
        }

        private void dataGridViewListado_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridViewListado.Rows)
            {
                total += Convert.ToDouble(row.Cells["CostoTotal"].Value);
            }
            lblTotalAPagar.Text = total.ToString();
        }

        private void txtPago_Leave(object sender, EventArgs e)
        {
            double cambio;
            cambio = Convert.ToDouble(txtPago.Text) - Convert.ToDouble(lblTotalAPagar.Text);
            lblCambio.Text = cambio.ToString();
        }


        private void dataGridViewListado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListado.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                cantidad = int.Parse(dataGridViewListado.Rows[e.RowIndex].Cells[2].Value.ToString());
                preUnit = double.Parse(dataGridViewListado.Rows[e.RowIndex].Cells[1].Value.ToString());
                preFinal = cantidad * preUnit;
                dataGridViewListado.Rows[e.RowIndex].Cells[3].Value = preFinal;
            }
        }
    }
}
