using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTaskApplication
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(sender);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            OpenForm(sender);
        }
        private void btnProject_Click(object sender, EventArgs e)
        {
            OpenForm(sender);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            OpenForm(sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenForm(object sender)
        {
            Form form = new Form();
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnEmployee":
                    form = new FrmEmployee();
                    break;
                case "btnTask":
                    form = new FrmTask();
                    break;
                case "btnProject":
                    form = new FrmProject();
                    break;
                case "btnStatistics":
                    form = new FrmStatistics();
                    break;
            }

            form.MdiParent = FrmMainContainer.ActiveForm;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();

        }
    }
}
