using MySql.Data.MySqlClient;
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
    public partial class HomeForm : Form
    {
        
        public HomeForm()
        {
            InitializeComponent();
            passwordTextbox.PasswordChar = '*';
        }

        

        private void longinButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextbox.Text;//获取用户名
            var password = passwordTextbox.Text;//获取密码
            username = "dodo";
            password = "123456";
            if (username == "")
            {
                usernameTip.Visible=true;
            }
            else if (password == "")
            {
                pwdTip.Visible=true;
            }
            else
            {
                MySqlConnection connection =
                new MySqlConnection();
                connection.ConnectionString = PublicMethod._connectionString;
                connection.Open();
                string findUserSql = "select * from t_user where username='" + username + "'and password='" + password + "'";//定义查询语句
                MySqlCommand sqlCom = new MySqlCommand(findUserSql, connection);
                MySqlDataReader sdr= sqlCom.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    PublicMethod.user_id = sdr[0].ToString();//把获取的用户id存到全局变量
                    this.Hide();
                    UserHome form = new UserHome();
                    form.Show();
                    PublicMethod.loginFlag = 1;//用户是否登录标志量，0为未登录，1为登录
                    PublicMethod.username= sdr[1].ToString();//把获取的用户名存到全局变量
                }
                else
                {
                    loginTip.Visible=true;
                }
                connection.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            usernameTextbox.Text = "";
            passwordTextbox.Text="";
            loginTip.Visible = false;
            pwdTip.Visible = false;
            usernameTip.Visible = false;
        }

        private void 列车信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏当前窗体
            QueryForm queryForm = new QueryForm();//新建查询窗体对象
            queryForm.Show(); //打开查询窗体
        }

        private void 网上购票用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register form = new Register();
            form.Show();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ModifyPwdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPwd form = new ForgetPwd();
            form.Show();
        }
    }
}
