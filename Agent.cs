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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
    public partial class Agent : UserControl
    {
        UserCommonData UCD1 = new UserCommonData();
        TicketCommonData TIC = new TicketCommonData();
        string TicID = "";
        int ticST;

        public Agent()
        {
            InitializeComponent();
        }

        private void ShowAgentAnalyticsBtn_Click(object sender, EventArgs e)
        {
            AgentChart.Show();
            AgentListDGV.Hide();
            Fillchart();
        }

        private void ShowTicketBtn_Click(object sender, EventArgs e)
        {
            AgentChart.Hide();
            AgentListDGV.Show();
            int role = UCD1.CheckUserRole(Form1.id, Form1.pass);

            DataTable dt = TIC.SelectTicketsByAssignVal(Form1.id);
            AgentListDGV.DataSource = dt;
            
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            
            AgentChart.Hide();
            AgentListDGV.Hide();
            AgentChart.Hide();
            DataTable dt = TIC.SelectTicketsByAssignVal(Form1.id);
            AgentListDGV.DataSource = dt;
        }
        public void HidAgent()
        {
            
            AgentChart.Hide();
            AgentListDGV.Hide();
            AgentChart.Hide();
        }

        private void UpdateTicketBtn_Click(object sender, EventArgs e)
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
            DataTable dt = TIC.SelectTicketsByAssignVal(Form1.id);
            AgentListDGV.DataSource = dt;
        }

        private void AgentListDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TicID = AgentListDGV.Rows[rowIndex].Cells[0].Value.ToString();
            ticST = Convert.ToInt32(AgentListDGV.Rows[rowIndex].Cells[5].Value);
        }

        private void RevertStatusBtn_Click(object sender, EventArgs e)
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
            DataTable dt = TIC.SelectTicketsByAssignVal(Form1.id);
            AgentListDGV.DataSource = dt;
        }

        private void AgentChart_Click(object sender, EventArgs e)
        {

        }
        public void Fillchart()
        {
            SqlConnection conn = new SqlConnection("data source=7231AMRIND4168L;initial catalog=EMSS;trusted_connection=true");
            DataSet dt = new DataSet();
            conn.Open();
            string sql = "select AssignedTo,TicketIDre,Time_Taken_To_Activate,Time_Taken_To_Assign,Time_Taken_To_Resolve from Tickets right join TicketTime on Tickets.TicketID=TicketTime.TicketIDre where AssignedTo=@ato;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ato", Form1.id);

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
    }
}
