namespace EmployeeTaskApplication
{
    partial class FrmEmployee
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
            listBox1 = new ListBox();
            btnAddEmployee = new Button();
            btnBack = new Button();
            btnUpdateEmployee = new Button();
            btnDeleteEmployee = new Button();
            label1 = new Label();
            tbName = new TextBox();
            tbEmail = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            tbSalary = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbPhone = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(570, 379);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddEmployee.Location = new Point(588, 300);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(200, 30);
            btnAddEmployee.TabIndex = 1;
            btnAddEmployee.Text = "Add New";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.Location = new Point(588, 408);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 30);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateEmployee.Location = new Point(588, 336);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(200, 30);
            btnUpdateEmployee.TabIndex = 4;
            btnUpdateEmployee.Text = "Update";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteEmployee.Location = new Point(588, 372);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(200, 30);
            btnDeleteEmployee.TabIndex = 5;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 2;
            label1.Text = "Employee Menu";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbName.Location = new Point(588, 78);
            tbName.Name = "tbName";
            tbName.Size = new Size(200, 23);
            tbName.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbEmail.Location = new Point(588, 122);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(200, 23);
            tbEmail.TabIndex = 7;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDateOfBirth.Location = new Point(588, 210);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 23);
            dtpDateOfBirth.TabIndex = 9;
            // 
            // tbSalary
            // 
            tbSalary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSalary.Location = new Point(588, 254);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(200, 23);
            tbSalary.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(588, 60);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 11;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(588, 104);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(588, 192);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 14;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(588, 236);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 15;
            label6.Text = "Monthly Salary";
            // 
            // tbPhone
            // 
            tbPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbPhone.Location = new Point(588, 166);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(200, 23);
            tbPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(588, 148);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 13;
            label4.Text = "Phone Number";
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbSalary);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnAddEmployee);
            Controls.Add(listBox1);
            Name = "FrmEmployee";
            Text = "FrmEmployee";
            Load += FrmEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnAddEmployee;
        private Button btnBack;
        private Button btnUpdateEmployee;
        private Button btnDeleteEmployee;
        private Label label1;
        private TextBox tbName;
        private TextBox tbEmail;
        private DateTimePicker dtpDateOfBirth;
        private TextBox tbSalary;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox tbPhone;
        private Label label4;
    }
}