
namespace sin_dolor
{
    partial class Frm_agregar_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_agregar_producto));
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.rich_descripcion = new System.Windows.Forms.RichTextBox();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.picture_foto = new System.Windows.Forms.PictureBox();
            this.txtnombre_producto = new System.Windows.Forms.TextBox();
            this.txtcodigo_producto = new System.Windows.Forms.TextBox();
            this.lblcodigoprod = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picture_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_producto.Location = new System.Drawing.Point(12, 83);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(192, 21);
            this.lbl_nombre_producto.TabIndex = 0;
            this.lbl_nombre_producto.Text = "Nombre del producto";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 159);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(107, 21);
            this.lbl_descripcion.TabIndex = 2;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // rich_descripcion
            // 
            this.rich_descripcion.Location = new System.Drawing.Point(16, 197);
            this.rich_descripcion.Name = "rich_descripcion";
            this.rich_descripcion.Size = new System.Drawing.Size(315, 117);
            this.rich_descripcion.TabIndex = 2;
            this.rich_descripcion.Text = "";
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.Location = new System.Drawing.Point(12, 331);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(47, 21);
            this.lbl_foto.TabIndex = 4;
            this.lbl_foto.Text = "Foto";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(216, 420);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(115, 22);
            this.txt_stock.TabIndex = 4;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(212, 396);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(56, 21);
            this.lbl_stock.TabIndex = 9;
            this.lbl_stock.Text = "Stock";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(216, 519);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(115, 35);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // picture_foto
            // 
            this.picture_foto.BackColor = System.Drawing.Color.Gray;
            this.picture_foto.Location = new System.Drawing.Point(16, 355);
            this.picture_foto.Name = "picture_foto";
            this.picture_foto.Size = new System.Drawing.Size(174, 199);
            this.picture_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_foto.TabIndex = 7;
            this.picture_foto.TabStop = false;
            // 
            // txtnombre_producto
            // 
            this.txtnombre_producto.Location = new System.Drawing.Point(16, 120);
            this.txtnombre_producto.Name = "txtnombre_producto";
            this.txtnombre_producto.Size = new System.Drawing.Size(315, 22);
            this.txtnombre_producto.TabIndex = 1;
            // 
            // txtcodigo_producto
            // 
            this.txtcodigo_producto.Location = new System.Drawing.Point(16, 46);
            this.txtcodigo_producto.Name = "txtcodigo_producto";
            this.txtcodigo_producto.Size = new System.Drawing.Size(315, 22);
            this.txtcodigo_producto.TabIndex = 0;
            this.txtcodigo_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_producto_KeyPress);
            this.txtcodigo_producto.Leave += new System.EventHandler(this.txtcodigo_producto_Leave);
            // 
            // lblcodigoprod
            // 
            this.lblcodigoprod.AutoSize = true;
            this.lblcodigoprod.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoprod.Location = new System.Drawing.Point(12, 9);
            this.lblcodigoprod.Name = "lblcodigoprod";
            this.lblcodigoprod.Size = new System.Drawing.Size(187, 21);
            this.lblcodigoprod.TabIndex = 12;
            this.lblcodigoprod.Text = "Codigo del producto";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(212, 331);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(61, 21);
            this.lbl_precio.TabIndex = 15;
            this.lbl_precio.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(216, 355);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(115, 22);
            this.txt_precio.TabIndex = 3;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(212, 460);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(92, 21);
            this.lbl_cantidad.TabIndex = 17;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(216, 484);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Frm_agregar_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 579);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txtcodigo_producto);
            this.Controls.Add(this.lblcodigoprod);
            this.Controls.Add(this.txtnombre_producto);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.picture_foto);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.rich_descripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_nombre_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_agregar_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar producto";
            this.Load += new System.EventHandler(this.Frm_agregar_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.RichTextBox rich_descripcion;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.PictureBox picture_foto;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txtnombre_producto;
        private System.Windows.Forms.Label lblcodigoprod;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_cantidad;
        public System.Windows.Forms.TextBox txtcodigo_producto;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}