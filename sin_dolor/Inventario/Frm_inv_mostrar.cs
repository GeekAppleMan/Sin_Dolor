using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace sin_dolor
{
    public partial class Frm_inv_mostrar : Form
    {
        public Frm_inv_mostrar()
        {
            InitializeComponent();
        }


        private void Frm_inv_mostrar_Load(object sender, EventArgs e)
        {
            new Cls_Inventario().Mostrar(dgvInventario);
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvInventario.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Tabla_Inventario.pdf";
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
                            PdfPTable pdfTable = new PdfPTable(dgvInventario.Columns.Count -3);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            PdfPCell cell = new PdfPCell(new Phrase("Producto"));
                            pdfTable.AddCell(cell);
                             cell = new PdfPCell(new Phrase("Descripcion"));
                            pdfTable.AddCell(cell);
                            cell = new PdfPCell(new Phrase("Precio"));
                            pdfTable.AddCell(cell);

                            foreach (DataGridViewRow row in dgvInventario.Rows)
                            {
                                foreach (DataGridViewCell cell1 in row.Cells)
                                {
                                    if (cell1.ColumnIndex < 3)
                                    {
                                        pdfTable.AddCell(cell1.Value.ToString());
                                    }
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
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {

                if (MessageBox.Show("¿Esta seguro que desea eliminar este producto?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new Cls_Inventario().Eliminar_prod(e.RowIndex.ToString());
                    dgvInventario.Rows.RemoveAt(e.RowIndex);
                }
            }
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                Inventario.Frm_modificar_inv.codigo = dgvInventario[5, e.RowIndex].Value.ToString();
                new Inventario.Frm_modificar_inv().ShowDialog();
            }
        }
    }
}
