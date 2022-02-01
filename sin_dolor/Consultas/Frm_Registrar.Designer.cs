
namespace sin_dolor
{
    partial class Frm_Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registrar));
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpb_consulta = new System.Windows.Forms.GroupBox();
            this.panel_total = new System.Windows.Forms.Panel();
            this.btn_finalizar_consulta = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_cambio_result = new System.Windows.Forms.Label();
            this.lbl_total_resul = new System.Windows.Forms.Label();
            this.lbl_paga_con = new System.Windows.Forms.Label();
            this.txt_pago = new System.Windows.Forms.TextBox();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_productos = new System.Windows.Forms.Label();
            this.panel_tratamiento = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rich_tratamiento = new System.Windows.Forms.RichTextBox();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.lbl_tratamiento = new System.Windows.Forms.Label();
            this.panel_paciente = new System.Windows.Forms.Panel();
            this.combo_pacientes = new System.Windows.Forms.ComboBox();
            this.lbl_paciente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpb_consulta.SuspendLayout();
            this.panel_total.SuspendLayout();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_tratamiento.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_paciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(-168, -30);
            this.cmbPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(563, 24);
            this.cmbPaciente.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-241, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "Productos Utilizados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-241, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tratamiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-241, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Paciente:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpb_consulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 788);
            this.panel1.TabIndex = 78;
            // 
            // gpb_consulta
            // 
            this.gpb_consulta.Controls.Add(this.panel_total);
            this.gpb_consulta.Controls.Add(this.panel_grid);
            this.gpb_consulta.Controls.Add(this.panel2);
            this.gpb_consulta.Controls.Add(this.panel_tratamiento);
            this.gpb_consulta.Controls.Add(this.panel_paciente);
            this.gpb_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_consulta.Location = new System.Drawing.Point(0, 0);
            this.gpb_consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_consulta.Name = "gpb_consulta";
            this.gpb_consulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_consulta.Size = new System.Drawing.Size(1387, 788);
            this.gpb_consulta.TabIndex = 0;
            this.gpb_consulta.TabStop = false;
            // 
            // panel_total
            // 
            this.panel_total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_total.Controls.Add(this.btn_finalizar_consulta);
            this.panel_total.Controls.Add(this.lbl_total);
            this.panel_total.Controls.Add(this.lbl_cambio_result);
            this.panel_total.Controls.Add(this.lbl_total_resul);
            this.panel_total.Controls.Add(this.lbl_paga_con);
            this.panel_total.Controls.Add(this.txt_pago);
            this.panel_total.Controls.Add(this.lbl_cambio);
            this.panel_total.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_total.Location = new System.Drawing.Point(3, 685);
            this.panel_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_total.Name = "panel_total";
            this.panel_total.Size = new System.Drawing.Size(1381, 101);
            this.panel_total.TabIndex = 45;
            // 
            // btn_finalizar_consulta
            // 
            this.btn_finalizar_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_finalizar_consulta.Location = new System.Drawing.Point(1177, 44);
            this.btn_finalizar_consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_finalizar_consulta.Name = "btn_finalizar_consulta";
            this.btn_finalizar_consulta.Size = new System.Drawing.Size(195, 48);
            this.btn_finalizar_consulta.TabIndex = 36;
            this.btn_finalizar_consulta.Text = "Finalizar Consulta";
            this.btn_finalizar_consulta.UseVisualStyleBackColor = true;
            this.btn_finalizar_consulta.Click += new System.EventHandler(this.btn_finalizar_consulta_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(752, 6);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(51, 20);
            this.lbl_total.TabIndex = 39;
            this.lbl_total.Text = "Total:";
            // 
            // lbl_cambio_result
            // 
            this.lbl_cambio_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_cambio_result.AutoSize = true;
            this.lbl_cambio_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio_result.Location = new System.Drawing.Point(816, 38);
            this.lbl_cambio_result.Name = "lbl_cambio_result";
            this.lbl_cambio_result.Size = new System.Drawing.Size(31, 20);
            this.lbl_cambio_result.TabIndex = 44;
            this.lbl_cambio_result.Text = "0.0";
            // 
            // lbl_total_resul
            // 
            this.lbl_total_resul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_total_resul.AutoSize = true;
            this.lbl_total_resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_resul.Location = new System.Drawing.Point(816, 6);
            this.lbl_total_resul.Name = "lbl_total_resul";
            this.lbl_total_resul.Size = new System.Drawing.Size(31, 20);
            this.lbl_total_resul.TabIndex = 43;
            this.lbl_total_resul.Text = "0.0";
            // 
            // lbl_paga_con
            // 
            this.lbl_paga_con.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_paga_con.AutoSize = true;
            this.lbl_paga_con.BackColor = System.Drawing.Color.Transparent;
            this.lbl_paga_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paga_con.Location = new System.Drawing.Point(711, 69);
            this.lbl_paga_con.Name = "lbl_paga_con";
            this.lbl_paga_con.Size = new System.Drawing.Size(84, 20);
            this.lbl_paga_con.TabIndex = 40;
            this.lbl_paga_con.Text = "Paga con:";
            // 
            // txt_pago
            // 
            this.txt_pago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_pago.Location = new System.Drawing.Point(820, 66);
            this.txt_pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pago.Name = "txt_pago";
            this.txt_pago.Size = new System.Drawing.Size(140, 27);
            this.txt_pago.TabIndex = 41;
            this.txt_pago.TextChanged += new System.EventHandler(this.txt_pago_TextChanged);
            this.txt_pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pago_KeyPress);
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.Location = new System.Drawing.Point(726, 38);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(71, 20);
            this.lbl_cambio.TabIndex = 42;
            this.lbl_cambio.Text = "Cambio:";
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.dgv_productos);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(3, 459);
            this.panel_grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(1381, 327);
            this.panel_grid.TabIndex = 38;
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.Producto,
            this.Cantidad,
            this.Precio_unitario,
            this.Costo,
            this.Modificar,
            this.Eliminar});
            this.dgv_productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_productos.Location = new System.Drawing.Point(0, 0);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(1381, 327);
            this.dgv_productos.TabIndex = 32;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            this.dgv_productos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_productos_RowsAdded);
            this.dgv_productos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_productos_RowsRemoved);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.HeaderText = "P.U";
            this.Precio_unitario.MinimumWidth = 6;
            this.Precio_unitario.Name = "Precio_unitario";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Image = global::sin_dolor.Properties.Resources.edit;
            this.Modificar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Modificar.MinimumWidth = 6;
            this.Modificar.Name = "Modificar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::sin_dolor.Properties.Resources.basura;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_productos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 425);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 34);
            this.panel2.TabIndex = 37;
            // 
            // lbl_productos
            // 
            this.lbl_productos.AutoSize = true;
            this.lbl_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productos.Location = new System.Drawing.Point(3, 2);
            this.lbl_productos.Name = "lbl_productos";
            this.lbl_productos.Size = new System.Drawing.Size(166, 20);
            this.lbl_productos.TabIndex = 33;
            this.lbl_productos.Text = "Productos utilizados:";
            // 
            // panel_tratamiento
            // 
            this.panel_tratamiento.Controls.Add(this.tableLayoutPanel1);
            this.panel_tratamiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tratamiento.Location = new System.Drawing.Point(3, 91);
            this.panel_tratamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_tratamiento.Name = "panel_tratamiento";
            this.panel_tratamiento.Size = new System.Drawing.Size(1381, 334);
            this.panel_tratamiento.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rich_tratamiento, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_agregar_producto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tratamiento, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1381, 334);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // rich_tratamiento
            // 
            this.rich_tratamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_tratamiento.Location = new System.Drawing.Point(3, 22);
            this.rich_tratamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rich_tratamiento.Name = "rich_tratamiento";
            this.rich_tratamiento.Size = new System.Drawing.Size(1375, 269);
            this.rich_tratamiento.TabIndex = 8;
            this.rich_tratamiento.Text = "";
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Location = new System.Drawing.Point(3, 295);
            this.btn_agregar_producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(197, 37);
            this.btn_agregar_producto.TabIndex = 10;
            this.btn_agregar_producto.Text = "Agregar Producto";
            this.btn_agregar_producto.UseVisualStyleBackColor = true;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // lbl_tratamiento
            // 
            this.lbl_tratamiento.AutoSize = true;
            this.lbl_tratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tratamiento.Location = new System.Drawing.Point(3, 0);
            this.lbl_tratamiento.Name = "lbl_tratamiento";
            this.lbl_tratamiento.Size = new System.Drawing.Size(103, 20);
            this.lbl_tratamiento.TabIndex = 7;
            this.lbl_tratamiento.Text = "Tratamiento:";
            // 
            // panel_paciente
            // 
            this.panel_paciente.Controls.Add(this.combo_pacientes);
            this.panel_paciente.Controls.Add(this.lbl_paciente);
            this.panel_paciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_paciente.Location = new System.Drawing.Point(3, 22);
            this.panel_paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_paciente.Name = "panel_paciente";
            this.panel_paciente.Size = new System.Drawing.Size(1381, 69);
            this.panel_paciente.TabIndex = 14;
            // 
            // combo_pacientes
            // 
            this.combo_pacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_pacientes.FormattingEnabled = true;
            this.combo_pacientes.Location = new System.Drawing.Point(112, 23);
            this.combo_pacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_pacientes.Name = "combo_pacientes";
            this.combo_pacientes.Size = new System.Drawing.Size(1267, 28);
            this.combo_pacientes.TabIndex = 3;
            this.combo_pacientes.TextChanged += new System.EventHandler(this.combo_pacientes_TextChanged);
            // 
            // lbl_paciente
            // 
            this.lbl_paciente.AutoSize = true;
            this.lbl_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paciente.Location = new System.Drawing.Point(3, 26);
            this.lbl_paciente.Name = "lbl_paciente";
            this.lbl_paciente.Size = new System.Drawing.Size(79, 20);
            this.lbl_paciente.TabIndex = 2;
            this.lbl_paciente.Text = "Paciente:";
            // 
            // Frm_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Registrar";
            this.Text = "Registrar consulta";
            this.Load += new System.EventHandler(this.Frm_Registrar_Load);
            this.panel1.ResumeLayout(false);
            this.gpb_consulta.ResumeLayout(false);
            this.panel_total.ResumeLayout(false);
            this.panel_total.PerformLayout();
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_tratamiento.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_paciente.ResumeLayout(false);
            this.panel_paciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpb_consulta;
        private System.Windows.Forms.Panel panel_tratamiento;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.RichTextBox rich_tratamiento;
        private System.Windows.Forms.Label lbl_tratamiento;
        private System.Windows.Forms.Panel panel_paciente;
        private System.Windows.Forms.ComboBox combo_pacientes;
        private System.Windows.Forms.Label lbl_paciente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_total;
        private System.Windows.Forms.Button btn_finalizar_consulta;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_cambio_result;
        private System.Windows.Forms.Label lbl_total_resul;
        private System.Windows.Forms.Label lbl_paga_con;
        private System.Windows.Forms.TextBox txt_pago;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}