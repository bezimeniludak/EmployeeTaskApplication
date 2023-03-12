namespace EmployeeTaskApplication
{
    partial class FrmMainMenu
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
            btnExit = new Button();
            btnStatistics = new Button();
            btnTask = new Button();
            btnEmployee = new Button();
            label1 = new Label();
            btnProject = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnExit.Location = new Point(233, 301);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(334, 30);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnStatistics.Location = new Point(233, 264);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(334, 30);
            btnStatistics.TabIndex = 8;
            btnStatistics.Text = "View Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnTask
            // 
            btnTask.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTask.Location = new Point(233, 190);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(334, 30);
            btnTask.TabIndex = 7;
            btnTask.Text = "Manage Tasks";
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEmployee.Location = new Point(233, 153);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(334, 30);
            btnEmployee.TabIndex = 6;
            btnEmployee.Text = "Manage Employees";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 5;
            label1.Text = "Main Menu";
            // 
            // btnProject
            // 
            btnProject.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnProject.Location = new Point(233, 227);
            btnProject.Name = "btnProject";
            btnProject.Size = new Size(334, 30);
            btnProject.TabIndex = 10;
            btnProject.Text = "Manage Projects";
            btnProject.UseVisualStyleBackColor = true;
            btnProject.Click += btnProject_Click;
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProject);
            Controls.Add(btnExit);
            Controls.Add(btnStatistics);
            Controls.Add(btnTask);
            Controls.Add(btnEmployee);
            Controls.Add(label1);
            Name = "FrmMainMenu";
            Text = "FrmMainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnStatistics;
        private Button btnTask;
        private Button btnEmployee;
        private Label label1;
        private Button btnProject;
    }
}