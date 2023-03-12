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
            btnTopSalary = new Button();
            btnBack = new Button();
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
            btnCurrMonth.Location = new Point(233, 185);
            btnCurrMonth.Name = "btnCurrMonth";
            btnCurrMonth.Size = new Size(334, 40);
            btnCurrMonth.TabIndex = 8;
            btnCurrMonth.Text = "Top 5 employees with the most ongoing tasks this month";
            btnCurrMonth.UseVisualStyleBackColor = true;
            btnCurrMonth.Click += btnCurrMonth_Click;
            // 
            // btnTopSalary
            // 
            btnTopSalary.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTopSalary.Location = new Point(233, 235);
            btnTopSalary.Name = "btnTopSalary";
            btnTopSalary.Size = new Size(334, 40);
            btnTopSalary.TabIndex = 9;
            btnTopSalary.Text = "Top 5 employees with the biggest monthly salaries";
            btnTopSalary.UseVisualStyleBackColor = true;
            btnTopSalary.Click += btnTopSalary_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBack.Location = new Point(329, 285);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 30);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnTopSalary);
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
        private Button btnTopSalary;
        private Button btnBack;
    }
}