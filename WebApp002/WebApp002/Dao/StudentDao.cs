using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using stud = WebApp002.Models.StudentModels;

namespace WebApp002.Dao
{
    public class StudentDao
    {
        string s = "server = localhost; database = test; user = root; password = 123456; charset = utf8";
        public int Add(stud stu)
        {
            int a = 0;
            using(MySqlConnection conn = new MySqlConnection(s))
            {
                try
                {
                    conn.Open();
                    string name = stu.name;
                    string sql = "insert into student(name) values ('"+name+"')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    a = cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return a;
        }
    }
}