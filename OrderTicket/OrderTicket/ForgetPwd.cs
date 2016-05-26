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
    public partial class ForgetPwd : Form
    {
        public ForgetPwd()
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
            var userID = IDTextBox.Text;//获取原登录密码
            var newPwd = newPwdTextBox.Text;//获取修改的新密码
            var newAgainPwd = newAgainPwdTextBox.Text;//获取重复修改的新密码
            IDTip.Visible = false;
            checkID.Visible = false;
            newPwdTip.Visible = false;
            checkNewPwd.Visible = false;
            againPwdTip.Visible = false;
            checkAgainPwd.Visible = false;
            checkUser.Visible = false;
            int flag = 0;
            if (userID == "")
            {
                IDTip.Visible = true;
            }
            else if (userID.Length !=18 )
            {
                checkID.Visible = true;
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
                string mysql = "select * from t_user where idNum='" + userID + "'";//定义查询语句 

                MySqlCommand sqlCom = new MySqlCommand(mysql, connection);
                MySqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.Read())
                {
                    string userRealID = reader["user_id"].ToString().Trim();
                    if (reader["idNum"].ToString().Trim() != userID)
                    {
                        checkID.Visible = true;
                    }
                    else
                    {
                        reader.Close();
                        string updateSql = "update t_user set password='" + newPwd + "'where user_id='" + userRealID + "'";
                        MySqlCommand updateCom = new MySqlCommand(updateSql, connection);
                        updateCom.ExecuteNonQuery();

                        if (MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            IDTextBox.Text = "";
                            newPwdTextBox.Text = "";
                            newAgainPwdTextBox.Text = "";
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    checkUser.Visible = true;
                    reader.Close();
                    connection.Close();
                }
            }
        }

    }
}
