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
    public partial class MyTicket : Form
    {
        public MyTicket()
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


        private void buyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyTicket form = new BuyTicket();
            form.Show();
            this.Close();
        }

        private void MyTicket_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void ReadData()
        {
            MySqlConnection connection = new MySqlConnection(PublicMethod._connectionString);
            connection.Open();
            string mysql = "select * from t_order where user_id='" + PublicMethod.user_id + "'";//定义查询语句 
            MySqlCommand sqlCom = new MySqlCommand(mysql, connection);
            MySqlDataAdapter myadp = new MySqlDataAdapter();
            myadp.SelectCommand = sqlCom;
            DataSet myset = new DataSet();
            myadp.Fill(myset, "t_order");
            myTicketInfo.DataSource = null;
            myTicketInfo.DataSource = myset.Tables["t_order"];
            connection.Close();
            myTicketInfo.Columns["备注"].DisplayIndex = 12;
            //myTicketInfo.Columns["车票ID"].DisplayIndex = 13;
            //myTicketInfo.Columns["用户ID"].DisplayIndex = 14;
        }

        private void myTicketInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string order_id = "";
            if (myTicketInfo.Rows[e.RowIndex].Cells[1].Value != null)
            {
                order_id = myTicketInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            if (myTicketInfo.Columns[e.ColumnIndex].Name=="备注")
            {
                if (MessageBox.Show("确定退票吗！", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string ticket_id = myTicketInfo.Rows[e.RowIndex].Cells[13].Value.ToString();
                    MySqlConnection connection = new MySqlConnection(PublicMethod._connectionString);
                    connection.Open();
                    string deleteSql = "delete from t_order where order_id='" + order_id + "'";
                    MySqlCommand deleteCom = new MySqlCommand(deleteSql, connection);
                    deleteCom.ExecuteNonQuery();
                    string updateSql = "update t_ticket set ticketNum=ticketNum+1 where ticket_id=" + ticket_id;
                    MySqlCommand updateCom = new MySqlCommand(updateSql, connection);
                    updateCom.ExecuteNonQuery();
                    connection.Close();
                    ReadData();
                }
            }
        }
    }
}
