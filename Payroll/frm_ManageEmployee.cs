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
    public partial class frm_ManageEmployee : Form
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
        public frm_ManageEmployee()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            date_Join.Format = DateTimePickerFormat.Custom;
            date_Join.CustomFormat = "MMMM dd, yyyy";

            date_Birth.Format = DateTimePickerFormat.Custom;
            date_Birth.CustomFormat = "MMMM dd, yyyy";

            refreshData();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tbl_EmployeeInfos(Emp_ID, Emp_FirstName, Emp_LastName, Emp_Address, Emp_Gender, Emp_Status, Emp_JoinDate, " +
                "Emp_Dob, Emp_PhoneNo, Emp_SSS, Emp_Position, Emp_Salary) " +
                "VALUES (@Emp_ID, @Emp_FirstName, @Emp_LastName, @Emp_Address, @Emp_Gender, @Emp_Status, @Emp_JoinDate, @Emp_Dob, " +
                "@Emp_PhoneNo, @Emp_SSS, @Emp_Position, @Emp_Salary);";

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
                MessageBox.Show("Saved!", "Succesful!");
                con.Close();
            }

            refreshData();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_ManageEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void refreshData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM tbl_EmployeeInfos";
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
                dgv_Employee.Columns[3].HeaderText = "Address";
                dgv_Employee.Columns[4].HeaderText = "Gender";
                dgv_Employee.Columns[5].HeaderText = "Status";
                dgv_Employee.Columns[6].HeaderText = "Join Date";
                dgv_Employee.Columns[7].HeaderText = "Date of Birth";
                dgv_Employee.Columns[8].HeaderText = "Phone Number";
                dgv_Employee.Columns[9].HeaderText = "SSS";
                dgv_Employee.Columns[10].HeaderText = "Position";
                dgv_Employee.Columns[11].HeaderText = "Rate";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT * FROM tbl_EmployeeInfos";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                DataSet dataSet = new DataSet();

                con.Open();
                adapter.Fill(dataSet, "tbl_EmployeeInfos");
                con.Close();
                dgv_EditDeleteEmp.DataSource = dataSet;
                dgv_EditDeleteEmp.DataMember = "tbl_EmployeeInfos";
                dgv_EditDeleteEmp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_EditDeleteEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgv_EditDeleteEmp.Columns[0].HeaderText = "ID";
                dgv_EditDeleteEmp.Columns[1].HeaderText = "First Name";
                dgv_EditDeleteEmp.Columns[2].HeaderText = "Last Name";
                dgv_EditDeleteEmp.Columns[3].HeaderText = "Address";
                dgv_EditDeleteEmp.Columns[4].HeaderText = "Gender";
                dgv_EditDeleteEmp.Columns[5].HeaderText = "Status";
                dgv_EditDeleteEmp.Columns[6].HeaderText = "Join Date";
                dgv_EditDeleteEmp.Columns[7].HeaderText = "Date of Birth";
                dgv_EditDeleteEmp.Columns[8].HeaderText = "Phone Number";
                dgv_EditDeleteEmp.Columns[9].HeaderText = "SSS";
                dgv_EditDeleteEmp.Columns[10].HeaderText = "Position";
                dgv_EditDeleteEmp.Columns[11].HeaderText = "Rate";
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv_EditDeleteEmp.Rows.Count >= 1)
                {
                    if(dgv_EditDeleteEmp.CurrentRow.Index == dgv_EditDeleteEmp.Rows.Count - 0)
                    {
                        MessageBox.Show("Please Select Data", "Warning!");
                    }
                    else
                    {
                        if(MessageBox.Show("Do you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string del = dgv_EditDeleteEmp.CurrentRow.Cells[0].Value.ToString();
                            string query = "DELETE FROM tbl_EmployeeInfos WHERE Emp_ID = '" + del + "'";

                            using (SqlConnection con = new SqlConnection(connectionString))
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data Deleted!", "Done!");
                                con.Close();
                            }

                            refreshData();
                        }
                    }
                } else
                {
                    MessageBox.Show("No More Data", "Warning!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}


