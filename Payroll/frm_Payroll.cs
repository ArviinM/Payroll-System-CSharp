using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btn_Compute_Click(object sender, EventArgs e)
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
            double workAbsent = double.Parse(textAbsent);
            double totalAbsent = workAbsent * workSalary;

            double totalDeduc = totalLate + totalAbsent;
            txt_TotalDeductions.Text = totalDeduc.ToString();

            //Total Salary
            double totalSalary = (totalSalaryPerDay + totalOT) - totalDeduc;
            lbl_TotalSalary.Text = "Total Salary: " + totalSalary.ToString();
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
            ws.Cells[12, 1] = "Total Deductions:";
            ws.Cells[14, 1] = "Total Salary: ";

            //Cells Text
            ws.Cells[1, 2] = txt_WorkingDay.Text;
            ws.Cells[2, 2] = txt_SalaryPerDay.Text;
            ws.Cells[4, 2] = txt_TotalSalary.Text;
            ws.Cells[6, 2] = txt_RegOT.Text;
            ws.Cells[7, 2] = txt_TotalOT.Text;
            ws.Cells[9, 2] = txt_Late.Text;
            ws.Cells[10, 2] = txt_TotalLate.Text;
            ws.Cells[11, 2] = txt_Absent.Text;
            ws.Cells[12, 2] = txt_TotalDeductions.Text;
            ws.Cells[14, 2] = lbl_TotalSalary.Text;
        }

        private void loadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT Emp_ID, Emp_FirstName, Emp_LastName, Emp_Salary FROM tbl_EmployeeInfos";
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
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            lbl_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void dgv_Employee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_FirstName.Text = this.dgv_Employee.CurrentRow.Cells[1].Value.ToString();
            lbl_LastName.Text = this.dgv_Employee.CurrentRow.Cells[2].Value.ToString();
            txt_SalaryPerDay.Text = this.dgv_Employee.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
