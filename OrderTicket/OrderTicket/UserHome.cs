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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void 列车信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryForm form = new QueryForm();
            form.Show();
        }

        private void 购票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyTicket form = new BuyTicket();
            form.Show();
            this.Close();
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublicMethod.loginFlag = 0;//全局变量是否登录恢复默认
            PublicMethod.user_id = "";//全局变量用户ID恢复默认
            PublicMethod.username = "";//全局变量用户名恢复默认

            this.Hide();
            HomeForm form = new HomeForm();
            form.Show();
            this.Close();
        }

        private void 查看用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckInfo form = new CheckInfo();
            form.Show();
            this.Close();
        }

        private void 查看订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyTicket form = new MyTicket();
            form.Show();
            this.Close();
        }

        private void 修改登录密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPwd form = new ModifyPwd();
            form.Show();
            this.Close();
        }
    }
}
