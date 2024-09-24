using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMSStc
{
    public partial class AgentUc : UserControl
    {
        UserCommonData UCD1 = new UserCommonData();
        TicketCommonData TIC = new TicketCommonData();
        string TicID = "";
        int ticST;
        string U = Form1.user;
        string pa = Form1.pass;
        public AgentUc()
        {
            InitializeComponent();
            Fillchart();
            int role = UCD1.CheckUserRole(U, pa);
            DataTable dt = TIC.SelectTicketsByAssignVal(Form1.user);
            AgentTicketsDGV.DataSource = dt;

        }

        private void AgentTicketsTab_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTicketPic_Click(object sender, EventArgs e)
        {

            TIC.TicketID = TicID;
            TIC.Status = ticST;
            bool success = TIC.UpdateStatus(TIC);
            if (success == true)
            {
                MessageBox.Show("cont updated");

            }
            else
            {
                MessageBox.Show("cont not updated");
            }
            DataTable dt = TIC.SelectTicketsByAssignVal(U);
            AgentTicketsDGV.DataSource = dt;

        }

        private void RevertTicketPic_Click(object sender, EventArgs e)
        {

            TIC.TicketID = TicID;
            TIC.Status = ticST;
            bool success = TIC.RevertStatus(TIC);
            if (success == true)
            {
                MessageBox.Show("cont updated");

            }
            else
            {
                MessageBox.Show("cont not updated");
            }
            DataTable dt = TIC.SelectTicketsByAssignVal(U);
            AgentTicketsDGV.DataSource = dt;

        }
        public void Fillchart()
        {
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            DataSet dt = new DataSet();
            conn.Open();
            string sql = "select AssignedTo,TicketIDre,Time_Taken_To_Activate,Time_Taken_To_Assign,Time_Taken_To_Resolve from Tickets right join TicketTime on Tickets.TicketID=TicketTime.TicketIDre where AssignedTo=@ato;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ato", U);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //AdminChart.DataSource = dt;
            DataView source = new DataView(dt.Tables[0]);
            AgentChart.DataSource = source;
            conn.Close();
            AgentChart.Series["Time_Taken_To_Assign"].XValueMember = "TicketIDre";
            AgentChart.Series["Time_Taken_To_Assign"].YValueMembers = "Time_Taken_To_Assign";
            AgentChart.Series["Time_Taken_To_Activate"].XValueMember = "TicketIDre";
            AgentChart.Series["Time_Taken_To_Activate"].YValueMembers = "Time_Taken_To_Activate";
            AgentChart.Series["Time_Taken_To_Resolve"].XValueMember = "TicketIDre";
            AgentChart.Series["Time_Taken_To_Resolve"].YValueMembers = "Time_Taken_To_Resolve";
            AgentChart.DataBind();

        }

        private void AgentTicketsDGV_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TicID = AgentTicketsDGV.Rows[rowIndex].Cells[0].Value.ToString();
            ticST = Convert.ToInt32(AgentTicketsDGV.Rows[rowIndex].Cells[5].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 fm = new Form1();
            //fm.Show();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 fm = new Form1();
            //fm.Show();
            //this.Close();
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            Fillchart();
            int role = UCD1.CheckUserRole(U, pa);
            DataTable dt = TIC.SelectTicketsByAssignVal(Form1.user);
            AgentTicketsDGV.DataSource = dt;
        }
    }
}
