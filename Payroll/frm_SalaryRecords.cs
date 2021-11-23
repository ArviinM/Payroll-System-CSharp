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
    public partial class frm_SalaryRecords : Form
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
        public frm_SalaryRecords()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            loadData();
        }

        private void frm_SalaryRecords_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void loadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM tbl_SalaryRecords";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                DataSet dataSet = new DataSet();

                con.Open();
                adapter.Fill(dataSet, "tbl_SalaryRecords");
                con.Close();
                dgv_SalaryRecords.DataSource = dataSet;
                dgv_SalaryRecords.DataMember = "tbl_SalaryRecords";
                dgv_SalaryRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_SalaryRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgv_SalaryRecords.Columns[0].HeaderText = "ID";
                dgv_SalaryRecords.Columns[1].HeaderText = "Time";
                dgv_SalaryRecords.Columns[2].HeaderText = "Date";
                dgv_SalaryRecords.Columns[3].HeaderText = "Employee ID";
                dgv_SalaryRecords.Columns[4].HeaderText = "Last Name";
                dgv_SalaryRecords.Columns[5].HeaderText = "First Name";
                dgv_SalaryRecords.Columns[6].HeaderText = "Work Days";
                dgv_SalaryRecords.Columns[7].HeaderText = "Total Work Days";
                dgv_SalaryRecords.Columns[8].HeaderText = "Regular OT";
                dgv_SalaryRecords.Columns[9].HeaderText = "Total OT";
                dgv_SalaryRecords.Columns[10].HeaderText = "Late";
                dgv_SalaryRecords.Columns[11].HeaderText = "Total Late";
                dgv_SalaryRecords.Columns[12].HeaderText = "Absent";
                dgv_SalaryRecords.Columns[13].HeaderText = "SSS Deduction";
                dgv_SalaryRecords.Columns[14].HeaderText = "Overall Deductions";
                dgv_SalaryRecords.Columns[15].HeaderText = "Total Salary";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
