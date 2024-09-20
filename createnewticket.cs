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
    public partial class create_new_ticket : Form
    {
        public create_new_ticket()
        {
            InitializeComponent();
        }

        private void NewTicketBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source = 7231AMRIND4168L; initial catalog = EMSS; trusted_connection = true");
            bool created = false;

            try
            {
                if (TicketSubjectTextBox.Text != "" && DiscTextBox.Text != "")
                    {
                        string sql = "INSERT INTO Tickets (TicketID, CreatedBy,Subject,Description,Status,CreatedAt) Values ('TICKET-' + LEFT(NEWID(),8),@id,@subject,@disc,2,SYSDATETIME())";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", Form1.id);
                        cmd.Parameters.AddWithValue("@subject", TicketSubjectTextBox.Text);
                        cmd.Parameters.AddWithValue("@disc", DiscTextBox.Text);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("ticket created");
                        created = true;
                        }
                        else
                        {
                            MessageBox.Show("ticket not created");
                        created = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ticket not created");
                    created = false;

                }

            }
            catch { }
            finally
            {
                conn.Close();
            }
            if(created)this.Close();
        }

        private void DiscTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
