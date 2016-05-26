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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.Show();
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;//获取注册的用户名
            string sex="";
            
            var password = passwordTextBox4.Text;//获取注册的用户密码
            var againPassword = pwdAgainiTextBox5.Text;//获取注册的重复用户密码
            var userNO = idNumTextBox3.Text;//获取注册用户的身份证
            bool[] flag = { false, false, false,false };

            //username = "do";
            //sex = "女";
            //password = "111111";
            //againPassword = "111111";
            //userNO = "111111111111111111";
            userTip.Visible = false;
            checkUsername.Visible = false;
            sexTip.Visible = false;
            pwdTip.Visible = false;
            checkPwd.Visible = false;
            againPwdTip.Visible = false;
            checkAgainpwd.Visible = false;
            checkID.Visible = false;
            IDTip.Visible = false;
            checkUser.Visible = false;

            if (sexComboBox1.SelectedItem != null)
            {
                sex = sexComboBox1.SelectedItem.ToString();//获取注册的用户性别
                flag[1] = true;
            }
            else
            {
                sexTip.Visible = true;
            }
           
            if (username == "")
            {
                userTip.Visible = true;
            }else if (username.Length < 2)
            {
                checkUsername.Visible = true;
            }
            else
            {
                flag[0] = true;
            }
            if (password == "")
            {
                pwdTip.Visible = true;
            }else if (password.Length < 6 || password.Length > 10)
            {
                checkPwd.Visible = true;
            }
            else
            {
                if (againPassword == "")
                {
                    againPwdTip.Visible = true;
                }else if (password != againPassword)
                {
                    checkAgainpwd.Visible = true;
                }
                else
                {
                    flag[2] = true;
                }
            }
            if (userNO == "")
            {
                IDTip.Visible = true;
            }else if (userNO.Length != 18)
            {
                checkID.Visible = true;
            }
            else
            {
                flag[3] = true;
            }
            if (flag[0]&&flag[1]&&flag[2]&&flag[3])
            {
                
                for (var i = 0; i < 4; i++)
                {
                    flag[i] = false;
                }
                
               
                MySqlConnection connection = new MySqlConnection(PublicMethod._connectionString);
                connection.Open();
                string findIDSql = "select idNum from t_user where idNum='" + userNO + "'";
                MySqlCommand sqlCom = new MySqlCommand(findIDSql, connection);
                MySqlDataReader sdr = sqlCom.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    checkUser.Visible = true;
                }
                else
                {
                    PublicMethod query = new PublicMethod();
                    string strSql = "insert into t_user(user_id,username,password,sex,idNum) values (LEFT(MD5(RAND()), 5),'" +
                        username + "','" + password + "','" + sex + "','" + userNO + "')";
                    if (query.ExecuteNonQuery(strSql, PublicMethod._connectionString) > 0)
                    {
                        if (MessageBox.Show("注册成功！确定返回登录", "提示", MessageBoxButtons.OK)==DialogResult.OK){
                            this.Hide();
                            HomeForm form = new HomeForm();
                            form.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("注册失败！", "信息提示");
                    }
                }
                sdr.Close();
                connection.Close();
            }
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            nameInputTip.Visible = true;
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            nameInputTip.Visible = false;
        }

        private void passwordTextBox4_Enter(object sender, EventArgs e)
        {
            pwdInputTip.Visible = true;
        }

        private void passwordTextBox4_Leave(object sender, EventArgs e)
        {
            pwdInputTip.Visible = false;
        }

        private void pwdAgainiTextBox5_Enter(object sender, EventArgs e)
        {
            againInputTip.Visible = true;
        }

        private void pwdAgainiTextBox5_Leave(object sender, EventArgs e)
        {
            againInputTip.Visible = false;
        }

        private void idNumTextBox3_Leave(object sender, EventArgs e)
        {
            IDInputTip.Visible = false;
        }

        private void idNumTextBox3_Enter(object sender, EventArgs e)
        {
            IDInputTip.Visible = true;
        }

        private void sexComboBox1_Enter(object sender, EventArgs e)
        {
            sexInputTip.Visible = true;
        }

        private void sexComboBox1_Leave(object sender, EventArgs e)
        {
            sexInputTip.Visible = false;
        }
    }
}
