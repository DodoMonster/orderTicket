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
    public partial class ModifyPwd : Form
    {
        public ModifyPwd()
        {
            InitializeComponent();
            newAgainPwdTextBox.PasswordChar = '*';
            newPwdTextBox.PasswordChar = '*';
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome form = new UserHome();
            form.Show();
            this.Close();
        }

        private void newPwdTextBox_Enter(object sender, EventArgs e)
        {
            pwdInputTip.Visible = true;
        }

        private void newPwdTextBox_Leave(object sender, EventArgs e)
        {
            pwdInputTip.Visible = false;
        }

        private void modifyButtonClick(object sender, EventArgs e)
        {
            var originPwd = OriginPwdTextBox.Text;//获取原登录密码
            var newPwd = newPwdTextBox.Text;//获取修改的新密码
            var newAgainPwd = newAgainPwdTextBox.Text;//获取重复修改的新密码
            originPwdTip.Visible = false;
            checkOriginPwd.Visible = false;
            newPwdTip.Visible = false;
            checkNewPwd.Visible = false;
            againPwdTip.Visible = false;
            checkAgainPwd.Visible = false;
            checkUser.Visible = false;
            int flag = 0;
            if (originPwd == "")
            {
                originPwdTip.Visible = true;
            }else if (originPwd.Length < 6 || originPwd.Length > 10)
            {
                checkOriginPwd.Visible = true;
            }
            if (newPwd == "")
            {
                newPwdTip.Visible = true;
            }
            else if (newPwd.Length < 6 || newPwd.Length > 10)
            {
                checkNewPwd.Visible = true;
            }
            else
            {
                if (newAgainPwd == "")
                {
                    againPwdTip.Visible = true;
                }
                else if (newPwd != newAgainPwd)
                {
                    checkAgainPwd.Visible = true;
                }
                else
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = PublicMethod._connectionString;
                connection.Open();
                string mysql = "select password from t_user where user_id='" + PublicMethod.user_id + "'";//定义查询语句 

                MySqlCommand sqlCom = new MySqlCommand(mysql, connection);
                MySqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["password"].ToString().Trim() != originPwd)
                    {
                        checkOriginPwd.Visible = true;
                        reader.Close();
                        connection.Close();
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        string updateSql = "update t_user set password='" + newPwd + "'where user_id='" + PublicMethod.user_id+"'";
                        MySqlConnection updateCon = new MySqlConnection(PublicMethod._connectionString);
                        MySqlCommand updateCom = new MySqlCommand(updateSql, updateCon);
                        updateCon.Open();
                        updateCom.ExecuteNonQuery();

                        if (MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            OriginPwdTextBox.Text = "";
                            newPwdTextBox.Text = "";
                            newAgainPwdTextBox.Text = "";
                        }
                    }
                }
                else
                {
                    checkUser.Visible = true;
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void checkInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckInfo form = new CheckInfo();
            form.Show();
            this.Close();
        }
    }
}
