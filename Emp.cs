using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Emp : UserControl
    {
        UserCommonData UCD1 = new UserCommonData();
        TicketCommonData TIC = new TicketCommonData();
        public Emp()
        {
            InitializeComponent();
        }

        private void Emp_Load(object sender, EventArgs e)
        {
           
            EmployeeChart.Hide();
            EmployeeTicketsDGV.Hide();
        }

        private void ShowTicketsBtn_Click(object sender, EventArgs e)
        {
            int role = UCD1.CheckUserRole(Form1.id, Form1.pass);

            DataTable dt = TIC.SelectTicketsByUser(Form1.id);
            EmployeeTicketsDGV.DataSource = dt;
            EmployeeChart.Hide();
            EmployeeTicketsDGV.Show();

        }

        private void ShowAnalyticsBtn_Click(object sender, EventArgs e)
        {
            EmployeeChart.Show();
            EmployeeTicketsDGV.Hide();
        }

        private void CreateNewTicketBtn_Click(object sender, EventArgs e)
        {
            create_new_ticket CNT = new create_new_ticket();  
            CNT.ShowDialog();
            DataTable dt = TIC.SelectTicketsByUser(Form1.id);
            EmployeeTicketsDGV.DataSource = dt;
        }

        private void EmployeeChart_Click(object sender, EventArgs e)
        {

        }
    }
}
