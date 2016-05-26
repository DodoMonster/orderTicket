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
    public partial class BuyTicket : Form
    {

        public BuyTicket()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void InsertData_UserControlBtnClicked(object sender, EventArgs e)
        {
           
            List<string> selectItem = UserControl1.selectedTicket;

            var username = usernameTextBox.Text;//获取用户名字
            var userID = userIDTextBox.Text;//获取用户身份证
            username = "dodo";
            userID = "441881199410083124";
            bool flag = true;
            userTip.Visible = false;
            checkUser.Visible = false;
            userIDTip.Visible = false;
            checkUserID.Visible = false;
            if (username == "")
            {
                userTip.Visible = true;
                checkUserID.Visible = false;
                flag = false;
            }
            else if (username.Length < 2)
            {
                userTip.Visible = false;
                checkUser.Visible = true;
                userIDTip.Visible = false;
                checkUserID.Visible = false;
                flag = false;
            }
            if (userID == "")
            {
                userIDTip.Visible = true;
                checkUserID.Visible = false;
                flag = false;
            }
            else if (userID.Length !=18)
            {
                userIDTip.Visible = false;
                checkUserID.Visible = true;
                flag = false;
            }
            if (flag)
            {
                
                flag = true;
                if (PublicMethod.loginFlag != 0)//如果用户已经登录,则可以订票
                {
      
                    string strSql = "insert into t_order(order_id,username,idNum,ticket_id,ticketNo,startPlace,startDay,startTime,destination,achieveDay,achieveTime,price,user_id) values (LEFT(MD5(RAND()), 5),'" +
                        username + "','" + userID + "','" + selectItem[0] + "','" + selectItem[1] + "','" + selectItem[2] + "','" + selectItem[3] + "','" + selectItem[4] +
                         "','" + selectItem[5] + "','" + selectItem[8] + "','" + selectItem[6] + "','" + selectItem[7] + "','"+ PublicMethod.user_id+ "')";
  
                    PublicMethod query = new PublicMethod();
                    if (query.ExecuteNonQuery(strSql, PublicMethod._connectionString) > 0)
                    {
                        MySqlConnection connection =new MySqlConnection(PublicMethod._connectionString);
                        connection.Open();
                        string updateSql = "update t_ticket set ticketNum=ticketNum-1 where ticket_id=" + selectItem[0];
                        MySqlCommand updateCom = new MySqlCommand(updateSql, connection);
                        updateCom.ExecuteNonQuery();
                        connection.Close();
                        this.Hide();
                        OrderSuccess successForm = new OrderSuccess();
                        successForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("预订失败！", "信息提示");
                    }
                }
                else
                {
                    MessageBox.Show("请先进行登录才可以进行订票", "信息提示");
                }
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserHome form = new UserHome();
            form.Show();
            this.Close();
        }
    }
}
