using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace Payroll
{
    public partial class frm_Payroll : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // height of ellipse
              int nHeightEllipse // width of ellipse
          );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string dbName = "db_payroll.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=" + path + @"\" + dbName + "; Integrated Security = True;";
        public frm_Payroll()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            loadData();
        }

        private void frm_Payroll_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void computation()
        {
            //Number of Work Days Total Computation
            string textWork = txt_WorkingDay.Text;
            double workDays = double.Parse(textWork);

            string textSalary = txt_SalaryPerDay.Text;
            double workSalary = double.Parse(textSalary);

            double totalSalaryPerDay = workDays * workSalary;
            txt_TotalSalary.Text = totalSalaryPerDay.ToString();

            //Overtime
            string textOT = txt_RegOT.Text;
            double workOT = double.Parse(textOT);
            double totalOT = workOT * 50;
            txt_TotalOT.Text = totalOT.ToString();

            //Deductions
            string textLate = txt_Late.Text;
            double workLate = double.Parse(textLate);
            double totalLate = workLate * 20;
            txt_TotalLate.Text = totalLate.ToString();

            string textAbsent = txt_Absent.Text;
            string textSSS = txt_SSS.Text;
            double workAbsent = double.Parse(textAbsent);
            double workSSS = double.Parse(textSSS);
            double totalAbsent = workAbsent * workSalary;

            double totalDeduc = totalLate + totalAbsent + workSSS;
            txt_TotalDeductions.Text = totalDeduc.ToString();

            //Total Salary
            double totalSalary = (totalSalaryPerDay + totalOT) - totalDeduc;
            lbl_TotalSalary.Text = totalSalary.ToString();
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            if (txt_RegOT.Text == "" && txt_Late.Text == "" && txt_Absent.Text == "")
            {
                txt_RegOT.Text = "0";
                txt_Late.Text = "0";
                txt_Absent.Text = "0";
            }
            if(txt_RegOT.Text == "")
            {
                txt_RegOT.Text = "0";
            }
            if(txt_Late.Text == "")
            {
                txt_Late.Text = "0";
            }
            if(txt_Absent.Text == "")
            {
                txt_Absent.Text = "0";
            }
            computation();

            btn_Excel.Enabled = true;
            btn_Print.Enabled = true;
            btn_SaveRecord.Enabled = true;
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xls.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xls.ActiveSheet;

            ws.Columns.ColumnWidth = 20;
            xls.Visible = true;

            //Cells Titles
            ws.Cells[1, 1] = "No. of Working day(s): ";
            ws.Cells[2, 1] = "Salary per day:";
            ws.Cells[4, 1] = "Total Salary per day: ";
            ws.Cells[6, 1] = "Regular OT (hr/s):";
            ws.Cells[7, 1] = "Total Amount of OT: ";
            ws.Cells[9, 1] = "Late (hr/s): ";
            ws.Cells[10, 1] = "Total Amount of Late:";
            ws.Cells[11, 1] = "Absent: ";
            ws.Cells[11, 1] = "SSS:";
            ws.Cells[13, 1] = "Total Deductions:";
            ws.Cells[15, 1] = "Total Salary: ";

            //Cells Text
            ws.Cells[1, 2] = txt_WorkingDay.Text;
            ws.Cells[2, 2] = txt_SalaryPerDay.Text;
            ws.Cells[4, 2] = txt_TotalSalary.Text;
            ws.Cells[6, 2] = txt_RegOT.Text;
            ws.Cells[7, 2] = txt_TotalOT.Text;
            ws.Cells[9, 2] = txt_Late.Text;
            ws.Cells[10, 2] = txt_TotalLate.Text;
            ws.Cells[11, 2] = txt_Absent.Text;
            ws.Cells[12, 2] = txt_SSS.Text;
            ws.Cells[13, 2] = txt_TotalDeductions.Text;
            ws.Cells[15, 2] = lbl_TotalSalary.Text;
        }

        private void loadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT Emp_ID, Emp_FirstName, Emp_LastName, Emp_Salary, Emp_SSS FROM tbl_EmployeeInfos";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                DataSet dataSet = new DataSet();

                con.Open();
                adapter.Fill(dataSet, "tbl_EmployeeInfos");
                con.Close();
                dgv_Employee.DataSource = dataSet;
                dgv_Employee.DataMember = "tbl_EmployeeInfos";
                dgv_Employee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_Employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgv_Employee.Columns[0].HeaderText = "ID";
                dgv_Employee.Columns[1].HeaderText = "First Name";
                dgv_Employee.Columns[2].HeaderText = "Last Name";
                dgv_Employee.Columns[3].HeaderText = "Rate";
                dgv_Employee.Columns[4].HeaderText = "SSS";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            lbl_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void dgv_Employee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Compute.Enabled = true;
            lbl_EmpID.Text = this.dgv_Employee.CurrentRow.Cells[0].Value.ToString();
            lbl_FirstName.Text = this.dgv_Employee.CurrentRow.Cells[1].Value.ToString();
            lbl_LastName.Text = this.dgv_Employee.CurrentRow.Cells[2].Value.ToString();
            txt_SalaryPerDay.Text = this.dgv_Employee.CurrentRow.Cells[3].Value.ToString();
            txt_SSS.Text = this.dgv_Employee.CurrentRow.Cells[3].Value.ToString();

            if (txt_SSS.Text == "")
            {
                txt_SSS.Text = "0";
            }
            else
            {
                txt_SSS.Text = "200";
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_WorkingDay.Text = "";
            txt_SalaryPerDay.Text = "";
            txt_RegOT.Text = "";
            txt_Late.Text = "";
            txt_Absent.Text = "";

            txt_TotalSalary.Text = "0";
            lbl_TotalSalary.Text = "0";
            txt_TotalDeductions.Text = "0";
            txt_TotalLate.Text = "0";
            txt_TotalOT.Text = "0";

        }


        private void btn_Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font15 = new Font("Poppins", 15, FontStyle.Bold);
            Font font12 = new Font("Poppins", 12);

            Brush brush = Brushes.Black;
            string dash = "----------------------------------------------------------------";

            Image image = SetImageOpacity(Properties.Resources.armavilo_compan, 0.25F);
            //e.Graphics.DrawImage(image, 30, 70, image.Width, image.Height);
            graphics.DrawImage(image, (e.PageBounds.Width - 500) / 2,(e.PageBounds.Height -  212) / 2, 500, 212);
            graphics.DrawString("The Armavilo Company", font15, brush, new System.Drawing.Point((e.PageBounds.Width - 250 )/ 2, 50));

            graphics.DrawString("Time: ", font12, brush, new System.Drawing.Point(50, 250));
            graphics.DrawString("Date: ", font12, brush, new System.Drawing.Point(50, 270));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(50, 290));


            graphics.DrawString("First Name: ", font12, brush, new System.Drawing.Point(50, 310));
            graphics.DrawString("Last Name: ", font12, brush, new System.Drawing.Point(50, 330));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(50, 350));

            graphics.DrawString("No. of Work Days: ", font12, brush, new System.Drawing.Point(50, 370));
            graphics.DrawString("Rate: ", font12, brush, new System.Drawing.Point(50, 390));
            graphics.DrawString("Total Basic Rate: ", font12, brush, new System.Drawing.Point(50, 410));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(50, 430));

            graphics.DrawString("Regular OT (hr/s): ", font12, brush, new System.Drawing.Point(50, 440));
            graphics.DrawString("Total Amount of OT: ", font12, brush, new System.Drawing.Point(50, 460));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(50, 480));

            graphics.DrawString("Late: ", font12, brush, new System.Drawing.Point(50, 500));
            graphics.DrawString("Total Amount of Late: ", font12, brush, new System.Drawing.Point(50, 520));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(50, 540));

            graphics.DrawString("Absent: ", font12, brush, new System.Drawing.Point(50, 560));
            graphics.DrawString("SSS Deduction: ", font12, brush, new System.Drawing.Point(50, 580));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(50, 600));

            graphics.DrawString("Total Deduction: ", font12, brush, new System.Drawing.Point(50, 620));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(50, 640));

            graphics.DrawString("Total Salary: ", font12, brush, new System.Drawing.Point(50, 660));


            graphics.DrawString(lbl_Time.Text, font12, brush, new System.Drawing.Point(300, 250));
            graphics.DrawString(lbl_Date.Text, font12, brush, new System.Drawing.Point(300, 270));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(300, 290));


            graphics.DrawString(lbl_FirstName.Text, font12, brush, new System.Drawing.Point(300, 310));
            graphics.DrawString(lbl_LastName.Text, font12, brush, new System.Drawing.Point(300, 330));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(300, 350));

            graphics.DrawString(txt_WorkingDay.Text, font12, brush, new System.Drawing.Point(300, 370));
            graphics.DrawString(txt_SalaryPerDay.Text, font12, brush, new System.Drawing.Point(300, 390));
            graphics.DrawString(txt_TotalSalary.Text, font12, brush, new System.Drawing.Point(300, 410));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(300, 430));

            graphics.DrawString(txt_RegOT.Text, font12, brush, new System.Drawing.Point(300, 440));
            graphics.DrawString(txt_TotalOT.Text, font12, brush, new System.Drawing.Point(300, 460));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(300, 480));

            graphics.DrawString(txt_Late.Text, font12, brush, new System.Drawing.Point(300, 500));
            graphics.DrawString(txt_TotalLate.Text, font12, brush, new System.Drawing.Point(300, 520));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(300, 540));

            graphics.DrawString(txt_Absent.Text, font12, brush, new System.Drawing.Point(300, 560));
            graphics.DrawString(txt_SSS.Text, font12, brush, new System.Drawing.Point(300, 580));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(300, 600));

            graphics.DrawString(txt_TotalDeductions.Text, font12, brush, new System.Drawing.Point(300, 620));
            graphics.DrawString(dash, font12, brush, new System.Drawing.Point(300, 640));

            graphics.DrawString(lbl_TotalSalary.Text, font12, brush, new System.Drawing.Point(300, 660));
        }

        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void btn_SaveRecord_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tbl_SalaryRecords(Sal_Time, Sal_Date, Emp_ID, Sal_LastName, Sal_FirstName, Sal_Workdays, " +
                "Sal_TotalWork, Sal_RegOT, Sal_TotalOT, Sal_Late, Sal_TotalLate, Sal_Absent, Sal_SSS, Sal_TotalDeduction, Sal_TotalSalary) " +
                "VALUES (@Sal_Time, @Sal_Date, @Emp_ID, @Sal_LastName, @Sal_FirstName, @Sal_Workdays, " +
                "@Sal_TotalWork, @Sal_RegOT, @Sal_TotalOT, @Sal_Late, @Sal_TotalLate, @Sal_Absent, @Sal_SSS, @Sal_TotalDeduction, @Sal_TotalSalary);";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                //cmd.Parameters.Add("@Birthdate", SqlDbType.Date).Value = dateTimePicker.Value.Date;

                cmd.Parameters.Add("@Sal_Time", SqlDbType.NVarChar).Value = lbl_Time.Text;
                cmd.Parameters.Add("@Sal_Date", SqlDbType.NVarChar).Value = lbl_Date.Text;
                cmd.Parameters.Add("@Emp_ID", SqlDbType.BigInt).Value = lbl_EmpID.Text;
                cmd.Parameters.Add("@Sal_LastName", SqlDbType.NVarChar).Value = lbl_LastName.Text;
                cmd.Parameters.Add("@Sal_FirstName", SqlDbType.NVarChar).Value = lbl_FirstName.Text;
                cmd.Parameters.Add("@Sal_Workdays", SqlDbType.NVarChar).Value = txt_WorkingDay.Text;
                cmd.Parameters.Add("@Sal_TotalWork", SqlDbType.NVarChar).Value = txt_TotalSalary.Text;
                cmd.Parameters.Add("@Sal_RegOT", SqlDbType.NVarChar).Value = txt_RegOT.Text;
                cmd.Parameters.Add("@Sal_TotalOT", SqlDbType.NVarChar).Value = txt_RegOT.Text;
                cmd.Parameters.Add("@Sal_Late", SqlDbType.NVarChar).Value = txt_Late.Text;
                cmd.Parameters.Add("@Sal_TotalLate", SqlDbType.NVarChar).Value = txt_TotalLate.Text;
                cmd.Parameters.Add("@Sal_Absent", SqlDbType.NVarChar).Value = txt_Absent.Text;
                cmd.Parameters.Add("@Sal_SSS", SqlDbType.NVarChar).Value = txt_SSS.Text;
                cmd.Parameters.Add("@Sal_TotalDeduction", SqlDbType.NVarChar).Value = txt_TotalDeductions.Text;
                cmd.Parameters.Add("@Sal_TotalSalary", SqlDbType.NVarChar).Value = lbl_TotalSalary.Text;


                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!", "Succesful!");
                con.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
