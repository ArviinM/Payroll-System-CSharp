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
    public partial class frm_Update : Form
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
        public frm_Update()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            date_Join.Format = DateTimePickerFormat.Custom;
            date_Join.CustomFormat = "MMMM dd, yyyy";

            date_Birth.Format = DateTimePickerFormat.Custom;
            date_Birth.CustomFormat = "MMMM dd, yyyy";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tbl_EmployeeInfos SET Emp_FirstName = @Emp_FirstName, Emp_LastName = @Emp_LastName, Emp_Address = @Emp_Address, " +
                "Emp_Gender = @Emp_Gender, Emp_Status = @Emp_Status, Emp_JoinDate = @Emp_JoinDate, Emp_Dob = @Emp_Dob, Emp_PhoneNo = @Emp_PhoneNo, " +
                "Emp_SSS = @Emp_SSS, Emp_Position = @Emp_Position, Emp_Salary = @Emp_Salary WHERE Emp_ID = @Emp_ID";

            if (txt_ID.Text == "" || txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_Street.Text == "" || txt_Barangay.Text == "" || txt_City.Text == "" ||
                cmb_Gender.Text == "" || cmb_Status.Text == "" || date_Join.Text == "" || date_Birth.Text == "" || txt_PhoneNo.Text == "" || txt_SSS.Text == "" || cmb_Position.Text == "" ||
                cmb_BasicRate.Text == "")
            {
                MessageBox.Show("Please input all fields!", "Warning");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //cmd.Parameters.Add("@Birthdate", SqlDbType.Date).Value = dateTimePicker.Value.Date;
                    cmd.Parameters.Add("@Emp_ID", SqlDbType.BigInt).Value = txt_ID.Text;
                    cmd.Parameters.Add("@Emp_FirstName", SqlDbType.NVarChar).Value = txt_FirstName.Text;
                    cmd.Parameters.Add("@Emp_LastName", SqlDbType.NVarChar).Value = txt_LastName.Text;
                    cmd.Parameters.Add("@Emp_Address", SqlDbType.NVarChar).Value = txt_Street.Text + ", " + txt_Barangay.Text + ", " + txt_City.Text;
                    cmd.Parameters.Add("@Emp_Gender", SqlDbType.NVarChar).Value = this.cmb_Gender.GetItemText(this.cmb_Gender.SelectedItem);
                    cmd.Parameters.Add("@Emp_Status", SqlDbType.NVarChar).Value = this.cmb_Status.GetItemText(this.cmb_Status.SelectedItem);
                    cmd.Parameters.Add("@Emp_JoinDate", SqlDbType.Date).Value = date_Join.Value.Date;
                    cmd.Parameters.Add("@Emp_Dob", SqlDbType.Date).Value = date_Birth.Value.Date;
                    cmd.Parameters.Add("@Emp_PhoneNo", SqlDbType.NVarChar).Value = txt_PhoneNo.Text;
                    cmd.Parameters.Add("@Emp_SSS", SqlDbType.NVarChar).Value = txt_SSS.Text;
                    cmd.Parameters.Add("@Emp_Position", SqlDbType.NVarChar).Value = this.cmb_Position.GetItemText(this.cmb_Position.SelectedItem);
                    cmd.Parameters.Add("@Emp_Salary", SqlDbType.NVarChar).Value = this.cmb_BasicRate.GetItemText(this.cmb_BasicRate.SelectedItem);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully, please close this window and click refresh at edit & delete employee tab!", "Done!");
                    con.Close();
                }
            }
        }
        private void frm_Update_MouseDown(object sender, MouseEventArgs e)
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

    }
}
