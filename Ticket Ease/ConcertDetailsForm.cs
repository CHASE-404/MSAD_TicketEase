using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Ease
{
    public partial class ConcertDetailsForm : Form
    {
        private bool isFirstClick = true;
        public ConcertDetailsForm()
        {
            InitializeComponent();
            //textBox2.Text = "Name of Concert";
            //textBox2.ForeColor = System.Drawing.Color.Gray;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (isFirstClick)
            {
                //textBox2.Text = " ";
                //textBox2.ForeColor = System.Drawing.Color.Gray;
                isFirstClick = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
