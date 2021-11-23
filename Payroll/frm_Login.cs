using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    
    public partial class frm_Login : Form
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

        static string path = Path.GetFullPath(Environment.CurrentDirectory);
        static string dbName = "db_payroll.mdf";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; AttachDbFilename=" + path + @"\" + dbName + "; Integrated Security = True;";

        public frm_Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Users WHERE Usernames='" + txt_Username.Text.Trim() + "' and Passwords='" + txt_Password.Text.Trim() + "'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if(dataTable.Rows.Count == 1)
                {
                    txt_Signing.Visible = true;
                    timer1.Start();
                } else if (txt_Username.Text == "" && txt_Password.Text == "")
                {
                    MessageBox.Show("Input all fields!", "Error");
                } else
                {
                    MessageBox.Show("Please check your user name and password, then try again.", "Error");
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(35);
            
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                frm_Dashboard dashboard = new frm_Dashboard();
                this.Hide();
                dashboard.Show();
                //frm_ManageEmployee manageEmployee = new frm_ManageEmployee();
                //manageEmployee.Show();
            }


        }

        private void chb_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void txt_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
