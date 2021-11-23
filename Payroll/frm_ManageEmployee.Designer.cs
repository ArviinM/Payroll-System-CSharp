namespace Payroll
{
    partial class frm_ManageEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_BasicRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.cmb_Position = new System.Windows.Forms.ComboBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txt_SSS = new System.Windows.Forms.TextBox();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Birth = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Join = new System.Windows.Forms.DateTimePicker();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Barangay = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Street = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_EditDeleteEmp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tbCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EditDeleteEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCtrl
            // 
            this.tbCtrl.Controls.Add(this.tabPage1);
            this.tbCtrl.Controls.Add(this.tabPage2);
            this.tbCtrl.Controls.Add(this.tabPage3);
            this.tbCtrl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCtrl.Location = new System.Drawing.Point(20, 52);
            this.tbCtrl.Name = "tbCtrl";
            this.tbCtrl.SelectedIndex = 0;
            this.tbCtrl.Size = new System.Drawing.Size(827, 418);
            this.tbCtrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tabPage1.Controls.Add(this.dgv_Employee);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee List";
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Employee.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Employee.Location = new System.Drawing.Point(15, 12);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.ReadOnly = true;
            this.dgv_Employee.RowTemplate.Height = 18;
            this.dgv_Employee.Size = new System.Drawing.Size(791, 352);
            this.dgv_Employee.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tabPage2.Controls.Add(this.panel15);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Employee";
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.btn_Save);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Controls.Add(this.cmb_BasicRate);
            this.panel15.Controls.Add(this.label7);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.cmb_Position);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.txt_SSS);
            this.panel15.Controls.Add(this.txt_PhoneNo);
            this.panel15.Location = new System.Drawing.Point(507, 20);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(297, 337);
            this.panel15.TabIndex = 11;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btn_Save.Location = new System.Drawing.Point(77, 279);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(146, 37);
            this.btn_Save.TabIndex = 33;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(103, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Basic Rate *";
            // 
            // cmb_BasicRate
            // 
            this.cmb_BasicRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_BasicRate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_BasicRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmb_BasicRate.FormattingEnabled = true;
            this.cmb_BasicRate.Items.AddRange(new object[] {
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cmb_BasicRate.Location = new System.Drawing.Point(31, 234);
            this.cmb_BasicRate.Name = "cmb_BasicRate";
            this.cmb_BasicRate.Size = new System.Drawing.Size(237, 31);
            this.cmb_BasicRate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(113, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Position *";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel17.Location = new System.Drawing.Point(31, 111);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(238, 3);
            this.panel17.TabIndex = 17;
            // 
            // cmb_Position
            // 
            this.cmb_Position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Position.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmb_Position.FormattingEnabled = true;
            this.cmb_Position.Items.AddRange(new object[] {
            "Janitor",
            "Driver",
            "Guard",
            "Help Desk",
            "Programmer",
            "Secretary"});
            this.cmb_Position.Location = new System.Drawing.Point(31, 161);
            this.cmb_Position.Name = "cmb_Position";
            this.cmb_Position.Size = new System.Drawing.Size(237, 31);
            this.cmb_Position.TabIndex = 13;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel16.Location = new System.Drawing.Point(30, 57);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(238, 3);
            this.panel16.TabIndex = 15;
            // 
            // txt_SSS
            // 
            this.txt_SSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_SSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SSS.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SSS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_SSS.Location = new System.Drawing.Point(29, 83);
            this.txt_SSS.Name = "txt_SSS";
            this.txt_SSS.PlaceholderText = "SSS *";
            this.txt_SSS.Size = new System.Drawing.Size(241, 20);
            this.txt_SSS.TabIndex = 12;
            this.txt_SSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PhoneNo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_PhoneNo.Location = new System.Drawing.Point(28, 29);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.PlaceholderText = "Phone Number *";
            this.txt_PhoneNo.Size = new System.Drawing.Size(241, 20);
            this.txt_PhoneNo.TabIndex = 11;
            this.txt_PhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.date_Birth);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.date_Join);
            this.panel7.Controls.Add(this.cmb_Status);
            this.panel7.Controls.Add(this.cmb_Gender);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.txt_City);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.txt_Barangay);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.txt_Street);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.txt_LastName);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.txt_FirstName);
            this.panel7.Controls.Add(this.txt_ID);
            this.panel7.Location = new System.Drawing.Point(14, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(481, 337);
            this.panel7.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(293, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Status *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(91, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Gender *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(286, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date of Birth *";
            // 
            // date_Birth
            // 
            this.date_Birth.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_Birth.Location = new System.Drawing.Point(235, 278);
            this.date_Birth.Name = "date_Birth";
            this.date_Birth.Size = new System.Drawing.Size(193, 27);
            this.date_Birth.TabIndex = 10;
            this.date_Birth.Value = new System.DateTime(2021, 11, 19, 15, 3, 12, 0);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.dateTimePicker2);
            this.panel8.Controls.Add(this.comboBox2);
            this.panel8.Controls.Add(this.comboBox3);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.textBox3);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.textBox4);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.textBox5);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.textBox6);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.textBox7);
            this.panel8.Controls.Add(this.textBox8);
            this.panel8.Location = new System.Drawing.Point(492, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(295, 337);
            this.panel8.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(183, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Join Date *";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Location = new System.Drawing.Point(80, 267);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(279, 27);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 31);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "Status *";
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(25, 189);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 31);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.Text = "Gender *";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel9.Location = new System.Drawing.Point(280, 152);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(136, 3);
            this.panel9.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel10.Location = new System.Drawing.Point(140, 152);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(123, 3);
            this.panel10.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBox3.Location = new System.Drawing.Point(278, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "City/Municipality * ";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel11.Location = new System.Drawing.Point(26, 152);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(98, 3);
            this.panel11.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBox4.Location = new System.Drawing.Point(138, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Barangay *";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel12.Location = new System.Drawing.Point(224, 99);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(191, 3);
            this.panel12.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBox5.Location = new System.Drawing.Point(24, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Street *";
            this.textBox5.Size = new System.Drawing.Size(101, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel13.Location = new System.Drawing.Point(28, 45);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(98, 3);
            this.panel13.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBox6.Location = new System.Drawing.Point(222, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Last Name *";
            this.textBox6.Size = new System.Drawing.Size(194, 20);
            this.textBox6.TabIndex = 3;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel14.Location = new System.Drawing.Point(24, 99);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(191, 3);
            this.panel14.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBox7.Location = new System.Drawing.Point(22, 71);
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "First Name *";
            this.textBox7.Size = new System.Drawing.Size(194, 20);
            this.textBox7.TabIndex = 2;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBox8.Location = new System.Drawing.Point(26, 17);
            this.textBox8.Name = "textBox8";
            this.textBox8.PlaceholderText = "ID Number *";
            this.textBox8.Size = new System.Drawing.Size(101, 20);
            this.textBox8.TabIndex = 1;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Join Date *";
            // 
            // date_Join
            // 
            this.date_Join.CustomFormat = "MMMM dd yyyy";
            this.date_Join.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_Join.Location = new System.Drawing.Point(39, 278);
            this.date_Join.Name = "date_Join";
            this.date_Join.Size = new System.Drawing.Size(190, 27);
            this.date_Join.TabIndex = 9;
            this.date_Join.Value = new System.DateTime(2021, 11, 19, 15, 3, 16, 0);
            // 
            // cmb_Status
            // 
            this.cmb_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Status.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cmb_Status.Location = new System.Drawing.Point(235, 211);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(194, 31);
            this.cmb_Status.TabIndex = 8;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Gender.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_Gender.Location = new System.Drawing.Point(38, 211);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(191, 31);
            this.cmb_Gender.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel6.Location = new System.Drawing.Point(293, 163);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 3);
            this.panel6.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Location = new System.Drawing.Point(153, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(123, 3);
            this.panel5.TabIndex = 16;
            // 
            // txt_City
            // 
            this.txt_City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_City.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_City.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_City.Location = new System.Drawing.Point(291, 135);
            this.txt_City.Name = "txt_City";
            this.txt_City.PlaceholderText = "City/Municipality * ";
            this.txt_City.Size = new System.Drawing.Size(139, 20);
            this.txt_City.TabIndex = 6;
            this.txt_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(39, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 3);
            this.panel4.TabIndex = 14;
            // 
            // txt_Barangay
            // 
            this.txt_Barangay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_Barangay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Barangay.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Barangay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_Barangay.Location = new System.Drawing.Point(151, 135);
            this.txt_Barangay.Name = "txt_Barangay";
            this.txt_Barangay.PlaceholderText = "Barangay *";
            this.txt_Barangay.Size = new System.Drawing.Size(126, 20);
            this.txt_Barangay.TabIndex = 5;
            this.txt_Barangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(237, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 3);
            this.panel2.TabIndex = 13;
            // 
            // txt_Street
            // 
            this.txt_Street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_Street.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Street.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_Street.Location = new System.Drawing.Point(37, 135);
            this.txt_Street.Name = "txt_Street";
            this.txt_Street.PlaceholderText = "Street *";
            this.txt_Street.Size = new System.Drawing.Size(101, 20);
            this.txt_Street.TabIndex = 4;
            this.txt_Street.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(41, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 3);
            this.panel3.TabIndex = 12;
            // 
            // txt_LastName
            // 
            this.txt_LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LastName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_LastName.Location = new System.Drawing.Point(235, 82);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.PlaceholderText = "Last Name *";
            this.txt_LastName.Size = new System.Drawing.Size(194, 20);
            this.txt_LastName.TabIndex = 3;
            this.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(37, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 3);
            this.panel1.TabIndex = 11;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FirstName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_FirstName.Location = new System.Drawing.Point(35, 82);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.PlaceholderText = "First Name *";
            this.txt_FirstName.Size = new System.Drawing.Size(194, 20);
            this.txt_FirstName.TabIndex = 2;
            this.txt_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_ID.Location = new System.Drawing.Point(39, 28);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PlaceholderText = "ID Number *";
            this.txt_ID.Size = new System.Drawing.Size(101, 20);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.tabPage3.Controls.Add(this.btn_Refresh);
            this.tabPage3.Controls.Add(this.btn_Edit);
            this.tabPage3.Controls.Add(this.btn_Delete);
            this.tabPage3.Controls.Add(this.dgv_EditDeleteEmp);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(819, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit & Delete Employee";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Location = new System.Drawing.Point(616, 165);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(146, 37);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_EditDeleteEmp
            // 
            this.dgv_EditDeleteEmp.AllowUserToAddRows = false;
            this.dgv_EditDeleteEmp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EditDeleteEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_EditDeleteEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_EditDeleteEmp.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_EditDeleteEmp.Location = new System.Drawing.Point(17, 17);
            this.dgv_EditDeleteEmp.Name = "dgv_EditDeleteEmp";
            this.dgv_EditDeleteEmp.ReadOnly = true;
            this.dgv_EditDeleteEmp.RowTemplate.Height = 25;
            this.dgv_EditDeleteEmp.Size = new System.Drawing.Size(540, 342);
            this.dgv_EditDeleteEmp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(315, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMPLOYEE MANAGEMENT";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Close.Location = new System.Drawing.Point(836, -1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 34);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Edit.Location = new System.Drawing.Point(616, 122);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(146, 37);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.Location = new System.Drawing.Point(616, 208);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(146, 37);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "REFRESH";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(871, 497);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_ManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ManageEmployee";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_ManageEmployee_MouseDown);
            this.tbCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EditDeleteEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tbCtrl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button btn_Close;
        private DataGridView dgv_Employee;
        private Panel panel15;
        private Button btn_Save;
        private Label label8;
        private ComboBox cmb_BasicRate;
        private Label label7;
        private Panel panel17;
        private ComboBox cmb_Position;
        private Panel panel16;
        private TextBox txt_SSS;
        private TextBox txt_PhoneNo;
        private Panel panel7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker date_Birth;
        private Panel panel8;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Panel panel9;
        private Panel panel10;
        private TextBox textBox3;
        private Panel panel11;
        private TextBox textBox4;
        private Panel panel12;
        private TextBox textBox5;
        private Panel panel13;
        private TextBox textBox6;
        private Panel panel14;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label2;
        private DateTimePicker date_Join;
        private ComboBox cmb_Status;
        private ComboBox cmb_Gender;
        private Panel panel6;
        private Panel panel5;
        private TextBox txt_City;
        private Panel panel4;
        private TextBox txt_Barangay;
        private Panel panel2;
        private TextBox txt_Street;
        private Panel panel3;
        private TextBox txt_LastName;
        private Panel panel1;
        private TextBox txt_FirstName;
        private TextBox txt_ID;
        private TabPage tabPage3;
        private Button btn_Delete;
        private DataGridView dgv_EditDeleteEmp;
        private Button btn_Refresh;
        private Button btn_Edit;
    }
}