using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using sin_dolor;
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

namespace sin_dolor.Pacientes
{
    public partial class Frm_DataGridPacientes : Form
    {
       
        public Frm_DataGridPacientes()
        {
            InitializeComponent();            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            dgv_pacientes.Columns.RemoveAt(0);
            if (dgv_pacientes.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Tabla_Pacientes.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("no fue posible guardar" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv_pacientes.Columns.Count);
                            pdfTable.DefaultCell.Padding = 5;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            PdfPCell cell = new PdfPCell(new Phrase("nombre"));
                            pdfTable.AddCell(cell);
                            cell = new PdfPCell(new Phrase("domicilio"));
                            pdfTable.AddCell(cell);
                            cell = new PdfPCell(new Phrase("fecha_nacimiento"));
                            pdfTable.AddCell(cell);
                            cell = new PdfPCell(new Phrase("telefono"));
                            pdfTable.AddCell(cell);
                            cell = new PdfPCell(new Phrase("recomendado_por"));
                            pdfTable.AddCell(cell);

                            foreach (DataGridViewRow row in dgv_pacientes.Rows)
                            {
                                foreach (DataGridViewCell cell1 in row.Cells)
                                {
                                    pdfTable.AddCell(cell1.Value.ToString());
                                }

                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Se ha completado el guardado !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex.Message);
                        }
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("No se exporto el documento!!!", "Info");
            }
        }

        private void Frm_DataGridPacientes_Load(object sender, EventArgs e)
        {
            new Cls_Pacientes().Mostrar_Paciente(dgv_pacientes);
        }
    }
}
