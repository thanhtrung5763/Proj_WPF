using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = Microsoft.Office.Interop.Word.Document;
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;
using System.Data.SqlClient;

namespace QuanLiKhachSan
{
    public partial class ManagerPaymentForm : Form
    {
        public ManagerPaymentForm()
        {
            InitializeComponent();
        }
        Check_in_out ck = new Check_in_out();
        private void ManagerPaymentForm_Load(object sender, EventArgs e)
        {
            dateSelected_DTP.Format = DateTimePickerFormat.Custom;
            dateSelected_DTP.CustomFormat = "dd/MM/yyyy";
        }
        private void showPay_BT_Click(object sender, EventArgs e)
        {
            DataTable dt = ck.getDataCheckInCheckOutAndCalPayment(dateSelected_DTP.Value);
            if (dt.Rows.Count != 0)
            {
                payment_DGV.DataSource = dt;
                payment_DGV.AllowUserToAddRows = false;
                payment_DGV.ReadOnly = true;

                payment_DGV.Columns[0].HeaderText = "Employee ID";
                payment_DGV.Columns[1].HeaderText = "First Name";
                payment_DGV.Columns[2].HeaderText = "Last Name";
                payment_DGV.Columns[3].HeaderText = "Date";
                payment_DGV.Columns[4].HeaderText = "Shift";
                payment_DGV.Columns[5].HeaderText = "Time Start";
                payment_DGV.Columns[5].DefaultCellStyle.Format = "hh\\:mm";
                payment_DGV.Columns[6].DefaultCellStyle.Format = "hh\\:mm";
                payment_DGV.Columns[6].HeaderText = "Time End";
                payment_DGV.Columns[7].HeaderText = "Time In";
                payment_DGV.Columns[8].HeaderText = "Time Out";
                payment_DGV.Columns[9].HeaderText = "Time Worked";
            }
        }

        
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }
                Document oDoc = new Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        if(c == 3)
                        {
                            oTemp = oTemp + DateTime.Parse(DGV.Rows[r].Cells[c].Value.ToString()).ToString("dd/MM/yyyy") + "\t";
                        }
                        else 
                            oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }

                oRange.Text = oTemp;

                object Separator = WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBoders = true;
                object AutoFit = true;
                object AutoFitBehavior = WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBoders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 1");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                foreach (Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.Text = "Payment Table " + dateSelected_DTP.Value.ToString("dd/MM/yyyy").Replace('/', '_');
                        ;
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                }
                oDoc.SaveAs(filename);
            }
        }

        private void export_BT_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document (*.docx)|*.docx";
            sfd.FileName = $"Payment_{dateSelected_DTP.Value.ToString("dd / MM / yyyy").Replace('/', '_')}.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(payment_DGV, sfd.FileName);
            }
        }
    }
}
