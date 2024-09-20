using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            EmployeeChart.Hide();
            EmployeeTicketsDGV.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();

        }
        public void HidEmp()
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
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
            label2.Hide();
            label3.Hide();
            label4.Hide();

        }

        private void ShowAnalyticsBtn_Click(object sender, EventArgs e)
        {
            EmployeeChart.Show();
            EmployeeTicketsDGV.Hide();
            Fillchart();
            label2.Show();
            label3.Show();
            label4.Show();
        }

        private void CreateNewTicketBtn_Click(object sender, EventArgs e)
        {
            create_new_ticket CNT = new create_new_ticket();  
            CNT.ShowDialog();
            DataTable dt = TIC.SelectTicketsByUser(Form1.id);
            EmployeeTicketsDGV.DataSource = dt;
            label2.Hide();
            label3.Hide();
            label4.Hide();
            EmployeeChart.Hide();
            EmployeeTicketsDGV.Hide();
        }

        private void EmployeeChart_Click(object sender, EventArgs e)
        {

        }
        public void Fillchart()
        {
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            DataSet dt = new DataSet();
            conn.Open();
            string sql = "select AssignedTo,TicketIDre,Time_Taken_To_Activate,Time_Taken_To_Assign,Time_Taken_To_Resolve from Tickets right join TicketTime on Tickets.TicketID=TicketTime.TicketIDre where CreatedBy=@ato;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ato", Form1.id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //AdminChart.DataSource = dt;
            DataView source = new DataView(dt.Tables[0]);
            EmployeeChart.DataSource = source;
            conn.Close();
            EmployeeChart.Series["Time_Taken_To_Assign"].XValueMember = "TicketIDre";
            EmployeeChart.Series["Time_Taken_To_Assign"].YValueMembers = "Time_Taken_To_Assign";
            EmployeeChart.Series["Time_Taken_To_Activate"].XValueMember = "TicketIDre";
            EmployeeChart.Series["Time_Taken_To_Activate"].YValueMembers = "Time_Taken_To_Activate";
            EmployeeChart.Series["Time_Taken_To_Resolve"].XValueMember = "TicketIDre";
            EmployeeChart.Series["Time_Taken_To_Resolve"].YValueMembers = "Time_Taken_To_Resolve";
            EmployeeChart.DataBind();

        }
    }
}
