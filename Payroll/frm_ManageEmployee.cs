using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
            loadCmbData();
        }

        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tbl_EmployeeInfos(Emp_ID, Emp_FirstName, Emp_LastName, Emp_Address, Emp_Gender, Emp_Status, Emp_JoinDate, " +
                "Emp_Dob, Emp_PhoneNo, Emp_SSS, Emp_Position, Emp_Salary) " +
                "VALUES (@Emp_ID, @Emp_FirstName, @Emp_LastName, @Emp_Address, @Emp_Gender, @Emp_Status, @Emp_JoinDate, @Emp_Dob, " +
                "@Emp_PhoneNo, @Emp_SSS, @Emp_Position, @Emp_Salary);";

            if(txt_ID.Text == "" || txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_Street.Text == "" || txt_Barangay.Text == "" || txt_City.Text == "" ||
                cmb_Gender.Text == "" || cmb_Status.Text == "" || date_Join.Text == "" || date_Birth.Text == "" || txt_PhoneNo.Text == "" || cmb_Position.Text == "" ||
                cmb_BasicRate.Text == "")
            {
                MessageBox.Show("Please input all fields!", "Warning");
            } else
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
                    MessageBox.Show("Saved!", "Succesful!");
                    con.Close();
                }

                refreshData();
            }


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void loadCmbData()
        {
            string query = "SELECT * FROM tbl_EmployeePositions";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        cmb_Position.Items.Add(read[0]);
                    }
                }
                con.Close();
            }
            cmb_Position.SelectedIndex = 6;
            cmb_BasicRate.SelectedIndex = 1;
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Payroll.frm_Update frm = new frm_Update();
            string selected = this.dgv_EditDeleteEmp.CurrentRow.Cells[0].Value.ToString();
            string query = "SELECT * FROM tbl_EmployeeInfos WHERE Emp_ID = '" + selected + "'";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {

                            string address = read["Emp_Address"].ToString();
                            var street = Regex.Replace(address.Split()[0], @"[^0-9a-zA-Z\ ]+", "");
                            var barangay = Regex.Replace(address.Split()[1], @"[^0-9a-zA-Z\ ]+", "");
                            var city = Regex.Replace(address.Split()[2], @"[^0-9a-zA-Z\ ]+", "");
                            //(Emp_ID, Emp_FirstName, Emp_LastName, Emp_Address, Emp_Gender, Emp_Status, Emp_JoinDate, " +
                            //"Emp_Dob, Emp_PhoneNo, Emp_SSS, Emp_Position, Emp_Salary)
                            frm.txt_ID.Text = (read["Emp_ID"].ToString());
                            frm.txt_FirstName.Text = (read["Emp_FirstName"].ToString());
                            frm.txt_LastName.Text = (read["Emp_LastName"].ToString());
                            frm.txt_Street.Text = street;
                            frm.txt_Barangay.Text = barangay;
                            frm.txt_City.Text = city;
                            frm.cmb_Gender.Text = (read["Emp_Gender"].ToString());
                            frm.cmb_Status.Text = (read["Emp_Status"].ToString());
                            frm.date_Join.Value = (DateTime)read["Emp_JoinDate"];
                            frm.date_Birth.Value = (DateTime)read["Emp_Dob"];
                            frm.txt_PhoneNo.Text = (read["Emp_PhoneNo"].ToString());
                            frm.txt_SSS.Text = (read["Emp_SSS"].ToString());
                            frm.cmb_Position.Text = (read["Emp_Position"].ToString());
                            frm.cmb_BasicRate.Text = (read["Emp_Salary"].ToString());

                        }
                        read.Close();
                    }
                }
                finally
                {
                    con.Close();
                }
            }   
            frm.ShowDialog();

        }

        private void cmb_Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_BasicRate.Items.Clear();
            if(cmb_Position.Text == "Manager")
            {
                cmb_BasicRate.Items.Add("1200");
                cmb_BasicRate.Items.Add("1000");
            } else if (cmb_Position.Text == "Secretary")
            {
                cmb_BasicRate.Items.Add("950");
                cmb_BasicRate.Items.Add("900");
            }else if (cmb_Position.Text == "Programmer")
            {
                cmb_BasicRate.Items.Add("900");
                cmb_BasicRate.Items.Add("850");
            }else if (cmb_Position.Text == "Consultant")
            {
                cmb_BasicRate.Items.Add("800");
                cmb_BasicRate.Items.Add("750");
            }else if (cmb_Position.Text == "Guard")
            {
                cmb_BasicRate.Items.Add("700");
                cmb_BasicRate.Items.Add("600");
            }else if (cmb_Position.Text == "Driver")
            {
                cmb_BasicRate.Items.Add("750");
                cmb_BasicRate.Items.Add("650");
            }else if (cmb_Position.Text == "Janitor")
            {
                cmb_BasicRate.Items.Add("700");
                cmb_BasicRate.Items.Add("600");
            }
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ID.Text))
            {
                string query = "SELECT * FROM tbl_EmployeeInfos WHERE Emp_ID = @Emp_ID";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Emp_ID", txt_ID.Text);
                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        lbl_Status.Visible = true;
                        lbl_Status.Text = "ID has already taken!";
                        lbl_Status.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_Status.Visible = true;
                        lbl_Status.Text = "This ID is available!";
                        lbl_Status.ForeColor = Color.Green;
                    }
                    if (txt_ID.Text == "")
                    {
                        lbl_Status.Visible = false;
                    }
                    

                    con.Close();
                }
            }
        }
    }
}


