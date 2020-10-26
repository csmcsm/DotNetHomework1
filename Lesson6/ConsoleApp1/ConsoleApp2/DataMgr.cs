using MySql.Data.MySqlClient;
using System;
namespace Chatter
{
    public class DataMgr
    {

        public MySqlConnection sqlConn;
        //单例模式
        public static DataMgr instance;
        public DataMgr()
        {
            instance = this;
            Connect();
        }
        //连接
        public void Connect()
        {
            //database
            string connStr = "Database=test;Data Source=127.0.0.1;";
            connStr += "User Id=root;Password=csm301301;port=3306";
            sqlConn = new MySqlConnection(connStr);
            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                Console.Write("[Database]fail to link" + e.Message);
                return;
            }
        }
        public bool createDetails (byte[] bytes,int id=0)
        {
            string cmdStr = string.Format("insert into OD set id ='{0}' ,details =@data;", id);
            MySqlCommand cmd = new MySqlCommand(cmdStr, sqlConn);

            cmd.Parameters.Add("@data", MySqlDbType.Blob);
            Console.WriteLine("register3");
            cmd.Parameters[0].Value = bytes;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("[DataMgr]CreatePlayer 写入 " + e.Message);
                return false;
            }
        }
        public byte[] getDetails(int id = 0)
        {
            string cmdstr = string.Format("select * from" +
             " OD where id='{0}';", id);
            MySqlCommand cmd = new MySqlCommand(cmdstr,
                sqlConn);
            MySqlDataReader dataReader = cmd.
                   ExecuteReader();
            bool hasRows = dataReader.HasRows;
            byte[] bytes=null;
            try
            {
                dataReader.Read();
                long len = dataReader.GetBytes(1, 0, null, 0, 0);//1是data
                bytes = new byte[len];
                dataReader.GetBytes(1, 0, bytes, 0, (int)len);
                dataReader.Close();
            }
            catch (Exception e)
            {
                dataReader.Close();
                Console.WriteLine("[DataMgr]Register1 使用非法字符" + e.Message);
                return bytes;
            }
            return bytes;
        }
        public bool updataDetails(byte[] bytes, int id = 0)
        {
            string cmdStr = string.Format("update OD set details =@data where id ='{0}';", id);
            MySqlCommand cmd = new MySqlCommand(cmdStr, sqlConn);

            cmd.Parameters.Add("@data", MySqlDbType.Blob);
            Console.WriteLine("register3");
            cmd.Parameters[0].Value = bytes;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("[DataMgr]CreatePlayer 写入 " + e.Message);
                return false;
            }
        }
        public bool deleteDetails(int id = 0)
        {
            string cmdStr = string.Format("delete from OD where id ='{0}';", id);
            MySqlCommand cmd = new MySqlCommand(cmdStr, sqlConn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("[DataMgr]CreatePlayer 写入 " + e.Message);
                return false;
            }
        }
    }
}