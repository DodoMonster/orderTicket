using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderTicket
{
    public partial class OrderSuccess : Form
    {
        public OrderSuccess()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome form = new UserHome();
            form.Show();
            this.Close();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyTicket form = new MyTicket();
            form.Show();
            this.Close();
        }
    }
}
