using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DataTable dt = TIC.SelectTicketsByAssignVal(Form1.id);
            AgentListDGV.DataSource = dt;
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
    }
}
