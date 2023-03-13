namespace EmployeeTaskApplication
{
    partial class FrmStatistics
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
            btnTopPastMonth = new Button();
            btnCurrMonth = new Button();
            btnTopProjects = new Button();
            btnBack = new Button();
            btnProjects = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(348, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 6;
            label1.Text = "Statistics";
            // 
            // btnTopPastMonth
            // 
            btnTopPastMonth.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTopPastMonth.Location = new Point(233, 135);
            btnTopPastMonth.Name = "btnTopPastMonth";
            btnTopPastMonth.Size = new Size(334, 40);
            btnTopPastMonth.TabIndex = 7;
            btnTopPastMonth.Text = "Top 5 employees with the most completed tasks in the past month";
            btnTopPastMonth.UseVisualStyleBackColor = true;
            btnTopPastMonth.Click += btnTopEmployees_Click;
            // 
            // btnCurrMonth
            // 
            btnCurrMonth.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCurrMonth.Location = new Point(233, 182);
            btnCurrMonth.Name = "btnCurrMonth";
            btnCurrMonth.Size = new Size(334, 40);
            btnCurrMonth.TabIndex = 8;
            btnCurrMonth.Text = "Top 5 employees with the most ongoing tasks this month";
            btnCurrMonth.UseVisualStyleBackColor = true;
            btnCurrMonth.Click += btnCurrMonth_Click;
            // 
            // btnTopProjects
            // 
            btnTopProjects.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTopProjects.Location = new Point(233, 229);
            btnTopProjects.Name = "btnTopProjects";
            btnTopProjects.Size = new Size(334, 40);
            btnTopProjects.TabIndex = 9;
            btnTopProjects.Text = "Top 5 employees with the biggest monthly salaries";
            btnTopProjects.UseVisualStyleBackColor = true;
            btnTopProjects.Click += btnTopSalary_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBack.Location = new Point(330, 323);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 30);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnProjects
            // 
            btnProjects.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnProjects.Location = new Point(233, 276);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(334, 40);
            btnProjects.TabIndex = 11;
            btnProjects.Text = "Top 5 projects with the most tasks";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // FrmStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProjects);
            Controls.Add(btnBack);
            Controls.Add(btnTopProjects);
            Controls.Add(btnCurrMonth);
            Controls.Add(btnTopPastMonth);
            Controls.Add(label1);
            Name = "FrmStatistics";
            Text = "FrmStatistics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTopPastMonth;
        private Button btnCurrMonth;
        private Button btnTopProjects;
        private Button btnBack;
        private Button btnProjects;
    }
}