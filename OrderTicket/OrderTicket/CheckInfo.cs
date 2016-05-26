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
    public partial class CheckInfo : Form
    {
        public CheckInfo()
        {
            InitializeComponent();
        }

        private void CheckForm_load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = PublicMethod._connectionString;
            connection.Open();
            string mysql = "select * from t_user where user_id='" + PublicMethod.user_id + "'";//定义查询语句 

            MySqlCommand sqlCom = new MySqlCommand(mysql, connection);
            MySqlDataAdapter myadp = new MySqlDataAdapter();
            myadp.SelectCommand = sqlCom;
            DataSet myset = new DataSet();
            myadp.Fill(myset, "t_user");
            myInfo.DataSource = myset.Tables["t_user"];
            connection.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.Show();
            this.Close();
        }

        private void modifyPwdButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyPwd form = new ModifyPwd();
            form.Show();
            this.Close();
        }

        private void buyTicketButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyTicket form = new BuyTicket();
            form.Show();
            this.Close();
        }
    }
}
