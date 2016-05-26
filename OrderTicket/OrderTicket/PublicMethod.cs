using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OrderTicket
{
    class PublicMethod
    {
        public static string _connectionString =
            string.Format("server={0};Port={1};User Id={2};database={3};password={4};Charset=utf8",
                           "localhost", 3300, "root", "orderticketsql", "123456")+ ";Allow Zero Datetime=True";
        public static int loginFlag = 0;//是否有登录标记量，0-未登录，1-已登录
        public static string user_id = "";//全局变量存储用户id
        public static string username = "";//全局变量存储用户名

        public int ExecuteNonQuery(string sql, string conStr)
        {
            using (MySqlConnection connection = new MySqlConnection(PublicMethod._connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                return cmd.ExecuteNonQuery();
            }
        }


    }
}
