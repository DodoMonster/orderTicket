using MySql.Data.MySqlClient;
using QueryTicket;
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
    public partial class QueryForm : Form
    {

        public QueryForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void backButton_Click(object sender, EventArgs e)
        {
            if (PublicMethod.loginFlag == 1)
            {
                this.Hide();
                UserHome form = new UserHome();
                form.Show();
                this.Close();
            }
            else
            {
                this.Hide();
                HomeForm form = new HomeForm();
                form.Show();
                this.Close();
            }
            
        }

        private void InsertData_UserControlBtnClicked(object sender, EventArgs e)
        {
            List<string> selectItem = UserControl1.selectedTicket;

            if (PublicMethod.loginFlag != 0)//如果用户已经登录,则可以订票
            {
                this.Hide();
                BuyTicket form = new BuyTicket();
                form.Show();
                this.Close();
                }
            else
            {
                MessageBox.Show("请先进行登录方可进行订票操作！", "信息提示");
            }
        }
    }
}
