using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Singleton
{
    class DBManager
    {
        private static DBManager instance_ = new DBManager();

        public static DBManager GetInstance()
        {
            return instance_;
        }

        private string connection_string = "Server=49.50.174.201;Database=s5533142;Uid=s5533142;Pwd=s5533142;Charset=utf8";

        public DBManager()
        {

        }

        public void Query(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
        public string Select(string name)
        {
            string num;
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                string sql = "SELECT * FROM student WHERE name = '"+name+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                num = rdr["id"].ToString();
                rdr.Close();
            }
            return num;
        }

        public List<StudentInfo> SelectStudent(string q)
        {
            List<StudentInfo> l = new List<StudentInfo>();
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                string sql = "SELECT * FROM student "+q;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    StudentInfo s = new StudentInfo((string)rdr["name"],(string)rdr["studentID"],(string)rdr["gender"],(string)rdr["major"]);
                    l.Add(s);
                    Console.WriteLine(l);
                }
                rdr.Close();
            }
            return l;
        }

        public List<MajorInfo> SelectMajor()
        {
            List<MajorInfo> l = new List<MajorInfo>();
            using (MySqlConnection conn = new MySqlConnection(connection_string))
            {
                conn.Open();
                string sql = "SELECT * FROM major";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MajorInfo s = new MajorInfo((string)rdr["major"]);
                    l.Add(s);
                    Console.WriteLine(l);
                }
                rdr.Close();
            }
            return l;
        }

    }
}
