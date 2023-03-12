namespace EmployeeTaskApplication
{
    partial class FrmTask
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
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbAssigneeId = new TextBox();
            dtpDueDate = new DateTimePicker();
            tbDescription = new TextBox();
            tbTitle = new TextBox();
            btnDeleteTask = new Button();
            btnUpdateTask = new Button();
            btnBack = new Button();
            btnAddTask = new Button();
            listBox1 = new ListBox();
            cbAssigneeName = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 6;
            label1.Text = "Tasks Menu";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(588, 191);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 30;
            label6.Text = "Assignee";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(588, 147);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 29;
            label5.Text = "Due Date";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(588, 103);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 27;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(588, 59);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 26;
            label2.Text = "Title";
            // 
            // tbAssigneeId
            // 
            tbAssigneeId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbAssigneeId.Enabled = false;
            tbAssigneeId.Location = new Point(588, 209);
            tbAssigneeId.Name = "tbAssigneeId";
            tbAssigneeId.Size = new Size(54, 23);
            tbAssigneeId.TabIndex = 25;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDueDate.Location = new Point(588, 165);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 23);
            dtpDueDate.TabIndex = 24;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbDescription.Location = new Point(588, 121);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(200, 23);
            tbDescription.TabIndex = 22;
            // 
            // tbTitle
            // 
            tbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTitle.Location = new Point(588, 77);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(200, 23);
            tbTitle.TabIndex = 21;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteTask.Location = new Point(588, 372);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(200, 30);
            btnDeleteTask.TabIndex = 20;
            btnDeleteTask.Text = "Delete";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateTask.Location = new Point(588, 336);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(200, 30);
            btnUpdateTask.TabIndex = 19;
            btnUpdateTask.Text = "Update";
            btnUpdateTask.UseVisualStyleBackColor = true;
            btnUpdateTask.Click += btnUpdateTask_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.Location = new Point(588, 408);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 30);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTask.Location = new Point(588, 300);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(200, 30);
            btnAddTask.TabIndex = 17;
            btnAddTask.Text = "Add New";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(570, 379);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // cbAssigneeName
            // 
            cbAssigneeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbAssigneeName.FormattingEnabled = true;
            cbAssigneeName.Location = new Point(648, 209);
            cbAssigneeName.Name = "cbAssigneeName";
            cbAssigneeName.Size = new Size(140, 23);
            cbAssigneeName.TabIndex = 32;
            cbAssigneeName.SelectedIndexChanged += cbAssigneeName_SelectedIndexChanged;
            // 
            // FrmTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbAssigneeName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbAssigneeId);
            Controls.Add(dtpDueDate);
            Controls.Add(tbDescription);
            Controls.Add(tbTitle);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnUpdateTask);
            Controls.Add(btnBack);
            Controls.Add(btnAddTask);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "FrmTask";
            Text = "FrmTask";
            Load += FrmTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox tbAssigneeId;
        private DateTimePicker dtpDueDate;
        private TextBox tbDescription;
        private TextBox tbTitle;
        private Button btnDeleteTask;
        private Button btnUpdateTask;
        private Button btnBack;
        private Button btnAddTask;
        private ListBox listBox1;
        private ComboBox cbAssigneeName;
    }
}