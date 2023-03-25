using System;
using System.Windows.Forms;

namespace JosueBaca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void backStageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TicketToolStripButton_Click(object sender, EventArgs e)
        {
            TicketsForm ticketform = new TicketsForm();
            ticketform.MdiParent = this;
            ticketform.Show();
        }
    }
}
