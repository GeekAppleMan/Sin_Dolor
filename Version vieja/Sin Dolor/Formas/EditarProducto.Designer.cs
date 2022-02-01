
namespace Sin_Dolor.Formas
{
    partial class EditarProducto
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
            this.lblFotoNombre = new System.Windows.Forms.Label();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditarProductoPrecio = new System.Windows.Forms.TextBox();
            this.txtEditarProductoDescripcion = new System.Windows.Forms.TextBox();
            this.txtEditarProductoNombre = new System.Windows.Forms.TextBox();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxEditarProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFotoNombre
            // 
            this.lblFotoNombre.AutoSize = true;
            this.lblFotoNombre.Location = new System.Drawing.Point(11, 240);
            this.lblFotoNombre.Name = "lblFotoNombre";
            this.lblFotoNombre.Size = new System.Drawing.Size(49, 17);
            this.lblFotoNombre.TabIndex = 37;
            this.lblFotoNombre.Text = "-.-.-.-.-";
            this.lblFotoNombre.Visible = false;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(14, 214);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFoto.TabIndex = 35;
            this.btnBuscarFoto.Text = "Buscar";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Foto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre:";
            // 
            // txtEditarProductoPrecio
            // 
            this.txtEditarProductoPrecio.ForeColor = System.Drawing.Color.Silver;
            this.txtEditarProductoPrecio.Location = new System.Drawing.Point(14, 169);
            this.txtEditarProductoPrecio.Name = "txtEditarProductoPrecio";
            this.txtEditarProductoPrecio.Size = new System.Drawing.Size(218, 22);
            this.txtEditarProductoPrecio.TabIndex = 30;
            this.txtEditarProductoPrecio.Enter += new System.EventHandler(this.txtEditarProductoPrecio_Enter);
            this.txtEditarProductoPrecio.Leave += new System.EventHandler(this.txtEditarProductoPrecio_Leave);
            // 
            // txtEditarProductoDescripcion
            // 
            this.txtEditarProductoDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtEditarProductoDescripcion.Location = new System.Drawing.Point(14, 124);
            this.txtEditarProductoDescripcion.Name = "txtEditarProductoDescripcion";
            this.txtEditarProductoDescripcion.Size = new System.Drawing.Size(218, 22);
            this.txtEditarProductoDescripcion.TabIndex = 29;
            this.txtEditarProductoDescripcion.Enter += new System.EventHandler(this.txtEditarProductoDescripcion_Enter);
            this.txtEditarProductoDescripcion.Leave += new System.EventHandler(this.txtEditarProductoDescripcion_Leave);
            // 
            // txtEditarProductoNombre
            // 
            this.txtEditarProductoNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtEditarProductoNombre.Location = new System.Drawing.Point(14, 79);
            this.txtEditarProductoNombre.Name = "txtEditarProductoNombre";
            this.txtEditarProductoNombre.Size = new System.Drawing.Size(218, 22);
            this.txtEditarProductoNombre.TabIndex = 28;
            this.txtEditarProductoNombre.Tag = "";
            this.txtEditarProductoNombre.Enter += new System.EventHandler(this.txtEditarProductoNombre_Enter);
            this.txtEditarProductoNombre.Leave += new System.EventHandler(this.txtEditarProductoNombre_Leave);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.AutoSize = true;
            this.btnModificarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarProducto.Location = new System.Drawing.Point(14, 29);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(75, 27);
            this.btnModificarProducto.TabIndex = 27;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "MODIFICACION DE PRODUCTOS";
            // 
            // pictureBoxEditarProducto
            // 
            this.pictureBoxEditarProducto.Location = new System.Drawing.Point(15, 260);
            this.pictureBoxEditarProducto.Name = "pictureBoxEditarProducto";
            this.pictureBoxEditarProducto.Size = new System.Drawing.Size(225, 172);
            this.pictureBoxEditarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditarProducto.TabIndex = 36;
            this.pictureBoxEditarProducto.TabStop = false;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 448);
            this.Controls.Add(this.lblFotoNombre);
            this.Controls.Add(this.pictureBoxEditarProducto);
            this.Controls.Add(this.btnBuscarFoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEditarProductoPrecio);
            this.Controls.Add(this.txtEditarProductoDescripcion);
            this.Controls.Add(this.txtEditarProductoNombre);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.label1);
            this.Name = "EditarProducto";
            this.Text = "EditarProducto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarProducto_FormClosed);
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFotoNombre;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditarProductoPrecio;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEditarProductoDescripcion;
        public System.Windows.Forms.TextBox txtEditarProductoNombre;
        public System.Windows.Forms.PictureBox pictureBoxEditarProducto;
    }
}