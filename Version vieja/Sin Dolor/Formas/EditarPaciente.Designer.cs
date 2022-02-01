
namespace Sin_Dolor.Formas
{
    partial class EditarPaciente
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditarPacienteCorreo = new System.Windows.Forms.TextBox();
            this.txtEditarPacienteTelefono = new System.Windows.Forms.TextBox();
            this.txtEditarPacienteApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtEditarPacienteApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtEditarPacienteNombre = new System.Windows.Forms.TextBox();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre(s):";
            // 
            // txtEditarPacienteCorreo
            // 
            this.txtEditarPacienteCorreo.ForeColor = System.Drawing.Color.Silver;
            this.txtEditarPacienteCorreo.Location = new System.Drawing.Point(238, 124);
            this.txtEditarPacienteCorreo.Name = "txtEditarPacienteCorreo";
            this.txtEditarPacienteCorreo.Size = new System.Drawing.Size(218, 22);
            this.txtEditarPacienteCorreo.TabIndex = 18;
            this.txtEditarPacienteCorreo.Enter += new System.EventHandler(this.txtEditarPacienteCorreo_Enter);
            this.txtEditarPacienteCorreo.Leave += new System.EventHandler(this.txtEditarPacienteCorreo_Leave);
            // 
            // txtEditarPacienteTelefono
            // 
            this.txtEditarPacienteTelefono.ForeColor = System.Drawing.Color.Silver;
            this.txtEditarPacienteTelefono.Location = new System.Drawing.Point(15, 124);
            this.txtEditarPacienteTelefono.MaxLength = 10;
            this.txtEditarPacienteTelefono.Name = "txtEditarPacienteTelefono";
            this.txtEditarPacienteTelefono.Size = new System.Drawing.Size(218, 22);
            this.txtEditarPacienteTelefono.TabIndex = 17;
            this.txtEditarPacienteTelefono.Enter += new System.EventHandler(this.txtEditarPacienteTelefono_Enter);
            this.txtEditarPacienteTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditarPacienteTelefono_KeyPress);
            this.txtEditarPacienteTelefono.Leave += new System.EventHandler(this.txtEditarPacienteTelefono_Leave);
            // 
            // txtEditarPacienteApellidoMaterno
            // 
            this.txtEditarPacienteApellidoMaterno.ForeColor = System.Drawing.Color.Silver;
            this.txtEditarPacienteApellidoMaterno.Location = new System.Drawing.Point(462, 79);
            this.txtEditarPacienteApellidoMaterno.Name = "txtEditarPacienteApellidoMaterno";
            this.txtEditarPacienteApellidoMaterno.Size = new System.Drawing.Size(218, 22);
            this.txtEditarPacienteApellidoMaterno.TabIndex = 16;
            this.txtEditarPacienteApellidoMaterno.Enter += new System.EventHandler(this.txtEditarPacienteApellidoMaterno_Enter);
            this.txtEditarPacienteApellidoMaterno.Leave += new System.EventHandler(this.txtEditarPacienteApellidoMaterno_Leave);
            // 
            // txtEditarPacienteApellidoPaterno
            // 
            this.txtEditarPacienteApellidoPaterno.ForeColor = System.Drawing.Color.Silver;
            this.txtEditarPacienteApellidoPaterno.Location = new System.Drawing.Point(238, 79);
            this.txtEditarPacienteApellidoPaterno.Name = "txtEditarPacienteApellidoPaterno";
            this.txtEditarPacienteApellidoPaterno.Size = new System.Drawing.Size(218, 22);
            this.txtEditarPacienteApellidoPaterno.TabIndex = 15;
            this.txtEditarPacienteApellidoPaterno.Enter += new System.EventHandler(this.txtEditarPacienteApellidoPaterno_Enter);
            this.txtEditarPacienteApellidoPaterno.Leave += new System.EventHandler(this.txtEditarPacienteApellidoPaterno_Leave);
            // 
            // txtEditarPacienteNombre
            // 
            this.txtEditarPacienteNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtEditarPacienteNombre.Location = new System.Drawing.Point(14, 79);
            this.txtEditarPacienteNombre.Name = "txtEditarPacienteNombre";
            this.txtEditarPacienteNombre.Size = new System.Drawing.Size(218, 22);
            this.txtEditarPacienteNombre.TabIndex = 14;
            this.txtEditarPacienteNombre.Enter += new System.EventHandler(this.txtEditarPacienteNombre_Enter);
            this.txtEditarPacienteNombre.Leave += new System.EventHandler(this.txtEditarPacienteNombre_Leave);
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.AutoSize = true;
            this.btnModificarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarPaciente.Location = new System.Drawing.Point(14, 29);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(92, 27);
            this.btnModificarPaciente.TabIndex = 13;
            this.btnModificarPaciente.Text = "MODIFICAR";
            this.btnModificarPaciente.UseVisualStyleBackColor = true;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "MODIFICACION DE PACIENTE";
            // 
            // EditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 157);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEditarPacienteCorreo);
            this.Controls.Add(this.txtEditarPacienteTelefono);
            this.Controls.Add(this.txtEditarPacienteApellidoMaterno);
            this.Controls.Add(this.txtEditarPacienteApellidoPaterno);
            this.Controls.Add(this.txtEditarPacienteNombre);
            this.Controls.Add(this.btnModificarPaciente);
            this.Controls.Add(this.label1);
            this.Name = "EditarPaciente";
            this.Text = "EditarPaciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarPaciente_FormClosed);
            this.Load += new System.EventHandler(this.EditarPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditarPacienteCorreo;
        private System.Windows.Forms.TextBox txtEditarPacienteTelefono;
        private System.Windows.Forms.TextBox txtEditarPacienteApellidoMaterno;
        private System.Windows.Forms.TextBox txtEditarPacienteApellidoPaterno;
        private System.Windows.Forms.TextBox txtEditarPacienteNombre;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Label label1;
    }
}