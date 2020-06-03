using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace StudentTable.Student
{
    public class Student
    {
        string sqlselect = "server = localhost; database = test; user = root; password = 123456; charset = utf8";
        public void select()
        {
            using(MySqlConnection conn = new MySqlConnection(sqlselect))
            {
                try
                {
                    conn.Open();
                    string sqlselect = "select * from student";
                    MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}