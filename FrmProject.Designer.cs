namespace EmployeeTaskApplication
{
    partial class FrmProject
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbBudget = new TextBox();
            dtpEndDate = new DateTimePicker();
            tbDescription = new TextBox();
            btnDeleteProject = new Button();
            btnUpdateProject = new Button();
            btnBack = new Button();
            label1 = new Label();
            btnAddProject = new Button();
            listBox1 = new ListBox();
            dtpStartDate = new DateTimePicker();
            tbTitle = new TextBox();
            cbTaskId = new ComboBox();
            label7 = new Label();
            tbTaskTitle = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(588, 237);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 31;
            label6.Text = "Budget";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(588, 193);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 30;
            label5.Text = "End Date";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(588, 149);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 29;
            label4.Text = "Start Date";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(588, 105);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 28;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(588, 61);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 27;
            label2.Text = "Title";
            // 
            // tbBudget
            // 
            tbBudget.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbBudget.Location = new Point(588, 255);
            tbBudget.Name = "tbBudget";
            tbBudget.Size = new Size(200, 23);
            tbBudget.TabIndex = 26;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpEndDate.Location = new Point(588, 211);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 25;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbDescription.Location = new Point(588, 123);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(200, 23);
            tbDescription.TabIndex = 23;
            // 
            // btnDeleteProject
            // 
            btnDeleteProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteProject.Location = new Point(588, 417);
            btnDeleteProject.Name = "btnDeleteProject";
            btnDeleteProject.Size = new Size(200, 30);
            btnDeleteProject.TabIndex = 21;
            btnDeleteProject.Text = "Delete";
            btnDeleteProject.UseVisualStyleBackColor = true;
            btnDeleteProject.Click += btnDeleteProject_Click;
            // 
            // btnUpdateProject
            // 
            btnUpdateProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateProject.Location = new Point(588, 381);
            btnUpdateProject.Name = "btnUpdateProject";
            btnUpdateProject.Size = new Size(200, 30);
            btnUpdateProject.TabIndex = 20;
            btnUpdateProject.Text = "Update";
            btnUpdateProject.UseVisualStyleBackColor = true;
            btnUpdateProject.Click += btnUpdateProject_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.Location = new Point(588, 453);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 30);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 10);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 18;
            label1.Text = "Project Menu";
            // 
            // btnAddProject
            // 
            btnAddProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddProject.Location = new Point(588, 345);
            btnAddProject.Name = "btnAddProject";
            btnAddProject.Size = new Size(200, 30);
            btnAddProject.TabIndex = 17;
            btnAddProject.Text = "Add New";
            btnAddProject.UseVisualStyleBackColor = true;
            btnAddProject.Click += btnAddProject_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(570, 424);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpStartDate.Location = new Point(588, 167);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 32;
            // 
            // tbTitle
            // 
            tbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTitle.Location = new Point(588, 79);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(200, 23);
            tbTitle.TabIndex = 33;
            // 
            // cbTaskId
            // 
            cbTaskId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTaskId.FormattingEnabled = true;
            cbTaskId.Location = new Point(588, 299);
            cbTaskId.Name = "cbTaskId";
            cbTaskId.Size = new Size(54, 23);
            cbTaskId.TabIndex = 34;
            cbTaskId.SelectedIndexChanged += cbTaskId_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(588, 281);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 35;
            label7.Text = "Tasks";
            // 
            // tbTaskTitle
            // 
            tbTaskTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTaskTitle.Location = new Point(648, 299);
            tbTaskTitle.Name = "tbTaskTitle";
            tbTaskTitle.Size = new Size(140, 23);
            tbTaskTitle.TabIndex = 36;
            // 
            // FrmProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(tbTaskTitle);
            Controls.Add(label7);
            Controls.Add(cbTaskId);
            Controls.Add(tbTitle);
            Controls.Add(dtpStartDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbBudget);
            Controls.Add(dtpEndDate);
            Controls.Add(tbDescription);
            Controls.Add(btnDeleteProject);
            Controls.Add(btnUpdateProject);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnAddProject);
            Controls.Add(listBox1);
            Name = "FrmProject";
            Text = "FrmProject";
            Load += FrmProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbBudget;
        private DateTimePicker dtpEndDate;
        private TextBox tbDescription;
        private Button btnDeleteProject;
        private Button btnUpdateProject;
        private Button btnBack;
        private Label label1;
        private Button btnAddProject;
        private ListBox listBox1;
        private DateTimePicker dtpStartDate;
        private TextBox tbTitle;
        private ComboBox cbTaskId;
        private Label label7;
        private TextBox tbTaskTitle;
    }
}