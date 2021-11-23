namespace Payroll
{
    partial class frm_Payroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TotalSalary = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Compute = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_TotalOT = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_RegOT = new System.Windows.Forms.TextBox();
            this.txt_TotalSalary = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_SalaryPerDay = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_WorkingDay = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_TotalDeductions = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txt_Absent = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_TotalLate = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_Late = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(336, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 35);
            this.label1.TabIndex = 35;
            this.label1.Text = "PAYROLL MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(459, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Income:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_TotalSalary);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Excel);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Compute);
            this.panel1.Controls.Add(this.lbl_1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.txt_TotalSalary);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txt_SalaryPerDay);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txt_WorkingDay);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(441, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 595);
            this.panel1.TabIndex = 37;
            // 
            // lbl_TotalSalary
            // 
            this.lbl_TotalSalary.AutoSize = true;
            this.lbl_TotalSalary.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalSalary.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_TotalSalary.Location = new System.Drawing.Point(136, 556);
            this.lbl_TotalSalary.Name = "lbl_TotalSalary";
            this.lbl_TotalSalary.Size = new System.Drawing.Size(0, 28);
            this.lbl_TotalSalary.TabIndex = 58;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btn_Exit.Location = new System.Drawing.Point(293, 484);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(146, 37);
            this.btn_Exit.TabIndex = 57;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_Excel
            // 
            this.btn_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Excel.FlatAppearance.BorderSize = 0;
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Excel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btn_Excel.Location = new System.Drawing.Point(293, 436);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(146, 37);
            this.btn_Excel.TabIndex = 56;
            this.btn_Excel.Text = "EXCEL";
            this.btn_Excel.UseVisualStyleBackColor = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btn_Clear.Location = new System.Drawing.Point(293, 386);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(146, 37);
            this.btn_Clear.TabIndex = 55;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_Compute
            // 
            this.btn_Compute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Compute.FlatAppearance.BorderSize = 0;
            this.btn_Compute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Compute.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Compute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btn_Compute.Location = new System.Drawing.Point(293, 338);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.Size = new System.Drawing.Size(146, 37);
            this.btn_Compute.TabIndex = 54;
            this.btn_Compute.Text = "COMPUTE";
            this.btn_Compute.UseVisualStyleBackColor = false;
            this.btn_Compute.Click += new System.EventHandler(this.btn_Compute_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_1.Location = new System.Drawing.Point(33, 556);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(109, 28);
            this.lbl_1.TabIndex = 53;
            this.lbl_1.Text = "Total Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(33, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 51;
            this.label4.Text = "Deductions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(33, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 38;
            this.label3.Text = "Overtime:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_TotalOT);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.txt_RegOT);
            this.panel7.Location = new System.Drawing.Point(25, 147);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(388, 141);
            this.panel7.TabIndex = 50;
            // 
            // txt_TotalOT
            // 
            this.txt_TotalOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_TotalOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalOT.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalOT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_TotalOT.Location = new System.Drawing.Point(101, 82);
            this.txt_TotalOT.Name = "txt_TotalOT";
            this.txt_TotalOT.PlaceholderText = "Total Amount of OT:";
            this.txt_TotalOT.Size = new System.Drawing.Size(191, 20);
            this.txt_TotalOT.TabIndex = 49;
            this.txt_TotalOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel6.Location = new System.Drawing.Point(101, 59);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 3);
            this.panel6.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel5.Location = new System.Drawing.Point(101, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 3);
            this.panel5.TabIndex = 48;
            // 
            // txt_RegOT
            // 
            this.txt_RegOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_RegOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_RegOT.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_RegOT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_RegOT.Location = new System.Drawing.Point(101, 34);
            this.txt_RegOT.Name = "txt_RegOT";
            this.txt_RegOT.PlaceholderText = "Regular OT (hr/s):";
            this.txt_RegOT.Size = new System.Drawing.Size(191, 20);
            this.txt_RegOT.TabIndex = 47;
            this.txt_RegOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalSalary
            // 
            this.txt_TotalSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_TotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalSalary.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_TotalSalary.Location = new System.Drawing.Point(222, 83);
            this.txt_TotalSalary.Name = "txt_TotalSalary";
            this.txt_TotalSalary.PlaceholderText = "Total Salary per day: ";
            this.txt_TotalSalary.Size = new System.Drawing.Size(191, 20);
            this.txt_TotalSalary.TabIndex = 45;
            this.txt_TotalSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(222, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 3);
            this.panel4.TabIndex = 44;
            // 
            // txt_SalaryPerDay
            // 
            this.txt_SalaryPerDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_SalaryPerDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SalaryPerDay.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SalaryPerDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_SalaryPerDay.Location = new System.Drawing.Point(222, 35);
            this.txt_SalaryPerDay.Name = "txt_SalaryPerDay";
            this.txt_SalaryPerDay.PlaceholderText = "Salary per day:";
            this.txt_SalaryPerDay.Size = new System.Drawing.Size(191, 20);
            this.txt_SalaryPerDay.TabIndex = 43;
            this.txt_SalaryPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(222, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 3);
            this.panel3.TabIndex = 42;
            // 
            // txt_WorkingDay
            // 
            this.txt_WorkingDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_WorkingDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_WorkingDay.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_WorkingDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_WorkingDay.Location = new System.Drawing.Point(25, 35);
            this.txt_WorkingDay.Name = "txt_WorkingDay";
            this.txt_WorkingDay.PlaceholderText = "No. of Working day(s):";
            this.txt_WorkingDay.Size = new System.Drawing.Size(191, 20);
            this.txt_WorkingDay.TabIndex = 41;
            this.txt_WorkingDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(25, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 3);
            this.panel2.TabIndex = 40;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_TotalDeductions);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.txt_Absent);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.txt_TotalLate);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.txt_Late);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(25, 321);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(243, 223);
            this.panel8.TabIndex = 52;
            // 
            // txt_TotalDeductions
            // 
            this.txt_TotalDeductions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_TotalDeductions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalDeductions.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalDeductions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_TotalDeductions.Location = new System.Drawing.Point(24, 170);
            this.txt_TotalDeductions.Name = "txt_TotalDeductions";
            this.txt_TotalDeductions.PlaceholderText = "Total Deductions:";
            this.txt_TotalDeductions.Size = new System.Drawing.Size(191, 20);
            this.txt_TotalDeductions.TabIndex = 57;
            this.txt_TotalDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel11.Location = new System.Drawing.Point(24, 147);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(191, 3);
            this.panel11.TabIndex = 54;
            // 
            // txt_Absent
            // 
            this.txt_Absent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_Absent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Absent.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Absent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_Absent.Location = new System.Drawing.Point(24, 122);
            this.txt_Absent.Name = "txt_Absent";
            this.txt_Absent.PlaceholderText = "Absent:";
            this.txt_Absent.Size = new System.Drawing.Size(191, 20);
            this.txt_Absent.TabIndex = 55;
            this.txt_Absent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel12.Location = new System.Drawing.Point(24, 195);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(191, 3);
            this.panel12.TabIndex = 56;
            // 
            // txt_TotalLate
            // 
            this.txt_TotalLate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_TotalLate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalLate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalLate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_TotalLate.Location = new System.Drawing.Point(24, 72);
            this.txt_TotalLate.Name = "txt_TotalLate";
            this.txt_TotalLate.PlaceholderText = "Total Amount of Late:";
            this.txt_TotalLate.Size = new System.Drawing.Size(191, 20);
            this.txt_TotalLate.TabIndex = 53;
            this.txt_TotalLate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel9.Location = new System.Drawing.Point(24, 49);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(191, 3);
            this.panel9.TabIndex = 50;
            // 
            // txt_Late
            // 
            this.txt_Late.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.txt_Late.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Late.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Late.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txt_Late.Location = new System.Drawing.Point(24, 24);
            this.txt_Late.Name = "txt_Late";
            this.txt_Late.PlaceholderText = "Late (hr/s): ";
            this.txt_Late.Size = new System.Drawing.Size(191, 20);
            this.txt_Late.TabIndex = 51;
            this.txt_Late.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel10.Location = new System.Drawing.Point(24, 97);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(191, 3);
            this.panel10.TabIndex = 52;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_Close.Location = new System.Drawing.Point(885, -3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(36, 34);
            this.btn_Close.TabIndex = 57;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(29, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 28);
            this.label5.TabIndex = 58;
            this.label5.Text = "Employee: ";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.dgv_Employee);
            this.panel13.Controls.Add(this.lbl_LastName);
            this.panel13.Controls.Add(this.lbl_FirstName);
            this.panel13.Controls.Add(this.lbl_Date);
            this.panel13.Controls.Add(this.lbl_Time);
            this.panel13.Location = new System.Drawing.Point(12, 69);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(423, 596);
            this.panel13.TabIndex = 59;
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AllowUserToAddRows = false;
            this.dgv_Employee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Employee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Employee.Location = new System.Drawing.Point(17, 134);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.ReadOnly = true;
            this.dgv_Employee.RowTemplate.Height = 18;
            this.dgv_Employee.Size = new System.Drawing.Size(395, 451);
            this.dgv_Employee.TabIndex = 64;
            this.dgv_Employee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employee_CellDoubleClick);
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LastName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_LastName.Location = new System.Drawing.Point(179, 84);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(96, 28);
            this.lbl_LastName.TabIndex = 63;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FirstName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_FirstName.Location = new System.Drawing.Point(18, 84);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(96, 28);
            this.lbl_FirstName.TabIndex = 62;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_Date.Location = new System.Drawing.Point(179, 36);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(50, 28);
            this.lbl_Date.TabIndex = 61;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_Time.Location = new System.Drawing.Point(18, 36);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(51, 28);
            this.lbl_Time.TabIndex = 60;
            this.lbl_Time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(920, 677);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Payroll";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Payroll_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel8;
        private Label label4;
        private Label label3;
        private Panel panel7;
        private Panel panel6;
        public TextBox txt_RegOT;
        public TextBox txt_SalaryPerDay;
        private Panel panel3;
        public TextBox txt_WorkingDay;
        private Label lbl_1;
        public TextBox txt_TotalOT;
        private Panel panel5;
        public TextBox txt_TotalSalary;
        private Panel panel4;
        public TextBox txt_TotalDeductions;
        private Panel panel11;
        public TextBox txt_Absent;
        private Panel panel12;
        public TextBox txt_TotalLate;
        private Panel panel9;
        public TextBox txt_Late;
        private Panel panel10;
        private Button btn_Excel;
        private Button btn_Clear;
        private Button btn_Compute;
        private Button btn_Close;
        private Button btn_Exit;
        private Label lbl_TotalSalary;
        private Label label5;
        private Panel panel13;
        private Label lbl_LastName;
        private Label lbl_FirstName;
        private Label lbl_Date;
        private Label lbl_Time;
        private DataGridView dgv_Employee;
        private System.Windows.Forms.Timer timer1;
    }
}