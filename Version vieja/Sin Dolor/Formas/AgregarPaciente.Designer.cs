
namespace Sin_Dolor
{
    partial class AgregarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPaciente));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            this.txtPacienteNombre = new System.Windows.Forms.TextBox();
            this.txtPacienteTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPacienteDomicilio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePacienteFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxPoliticasDePrivacidad = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbRecomendacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PACIENTE";
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.AutoSize = true;
            this.btnRegistrarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(202, 423);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(98, 27);
            this.btnRegistrarPaciente.TabIndex = 8;
            this.btnRegistrarPaciente.Text = "REGISTRAR";
            this.btnRegistrarPaciente.UseVisualStyleBackColor = true;
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // txtPacienteNombre
            // 
            this.txtPacienteNombre.Location = new System.Drawing.Point(13, 50);
            this.txtPacienteNombre.Name = "txtPacienteNombre";
            this.txtPacienteNombre.Size = new System.Drawing.Size(478, 22);
            this.txtPacienteNombre.TabIndex = 1;
            this.txtPacienteNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteNombre_KeyPress);
            // 
            // txtPacienteTelefono
            // 
            this.txtPacienteTelefono.Location = new System.Drawing.Point(366, 123);
            this.txtPacienteTelefono.MaxLength = 10;
            this.txtPacienteTelefono.Name = "txtPacienteTelefono";
            this.txtPacienteTelefono.Size = new System.Drawing.Size(125, 22);
            this.txtPacienteTelefono.TabIndex = 4;
            this.txtPacienteTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Recomendado por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Domicilio:";
            // 
            // txtPacienteDomicilio
            // 
            this.txtPacienteDomicilio.Location = new System.Drawing.Point(13, 95);
            this.txtPacienteDomicilio.Name = "txtPacienteDomicilio";
            this.txtPacienteDomicilio.Size = new System.Drawing.Size(478, 22);
            this.txtPacienteDomicilio.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePacienteFechaNacimiento
            // 
            this.dateTimePacienteFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePacienteFechaNacimiento.Location = new System.Drawing.Point(161, 124);
            this.dateTimePacienteFechaNacimiento.Name = "dateTimePacienteFechaNacimiento";
            this.dateTimePacienteFechaNacimiento.Size = new System.Drawing.Size(125, 22);
            this.dateTimePacienteFechaNacimiento.TabIndex = 3;
            // 
            // richTextBoxPoliticasDePrivacidad
            // 
            this.richTextBoxPoliticasDePrivacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPoliticasDePrivacidad.Location = new System.Drawing.Point(14, 199);
            this.richTextBoxPoliticasDePrivacidad.Name = "richTextBoxPoliticasDePrivacidad";
            this.richTextBoxPoliticasDePrivacidad.Size = new System.Drawing.Size(477, 191);
            this.richTextBoxPoliticasDePrivacidad.TabIndex = 15;
            this.richTextBoxPoliticasDePrivacidad.Text = resources.GetString("richTextBoxPoliticasDePrivacidad.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(95, 396);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(319, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "He leido y aceptado las politcas de privacidad";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbRecomendacion
            // 
            this.cmbRecomendacion.FormattingEnabled = true;
            this.cmbRecomendacion.Location = new System.Drawing.Point(145, 152);
            this.cmbRecomendacion.Name = "cmbRecomendacion";
            this.cmbRecomendacion.Size = new System.Drawing.Size(346, 24);
            this.cmbRecomendacion.TabIndex = 5;
            this.cmbRecomendacion.Text = "Nadie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Politicas de privacidad:";
            // 
            // AgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 462);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRecomendacion);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBoxPoliticasDePrivacidad);
            this.Controls.Add(this.dateTimePacienteFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPacienteDomicilio);
            this.Controls.Add(this.txtPacienteTelefono);
            this.Controls.Add(this.txtPacienteNombre);
            this.Controls.Add(this.btnRegistrarPaciente);
            this.Controls.Add(this.label1);
            this.Name = "AgregarPaciente";
            this.Text = "AgregarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarPaciente;
        private System.Windows.Forms.TextBox txtPacienteNombre;
        private System.Windows.Forms.TextBox txtPacienteTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPacienteDomicilio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePacienteFechaNacimiento;
        private System.Windows.Forms.RichTextBox richTextBoxPoliticasDePrivacidad;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbRecomendacion;
        private System.Windows.Forms.Label label7;
    }
}