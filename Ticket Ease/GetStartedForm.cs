using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticket_Ease;


namespace ConcertTicketingSystem
{
    public partial class GetStartedForm : Form
    {
        //private VlcControl vlcControl;
        public GetStartedForm()
        {
            InitializeComponent();
            //InitializeVlcControl();
        }

       /* private void GetStartedBtn_Click(object sender, EventArgs e)
        {
            
        }*/

        private void GetStartedBtn_Click_1(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
