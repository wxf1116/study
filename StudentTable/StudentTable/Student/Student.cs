using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using StudentTable.Models;

namespace StudentTable.Student
{
    public class Student
    {
        string sqlselect = "server = localhost; database = test; user = root; password = 123456; charset = utf8";
        public List<StudentModel> select(StudentModel stumod)
        {

            using(MySqlConnection conn = new MySqlConnection(sqlselect))
            {
                try
                {
                    conn.Open();
                    string sqlselect = "select * from student";
                    MySqlCommand cmd = new MySqlCommand(sqlselect, conn);
                    DataSet ds = new DataSet();
                    MySqlDataAdapter msda = new MySqlDataAdapter();
                    msda.SelectCommand = cmd;
                    msda.Fill(ds);
                    DataTable stu = ds.Tables[0];
                    List<StudentModel> sss = new List<StudentModel>();
                    for (int i = 0; i < stu.Rows.Count; i++)
                    {
                        StudentModel ssssss = new StudentModel();
                        DataRow row = stu.Rows[i];
                        ssssss.id = Convert.ToInt32(row["id"]);
                        ssssss.name = Convert.ToString(row["name"]);
                        ssssss.sex = Convert.ToString(row["sex"]);

                        sss.Add(ssssss);
                    }

                    return sss;
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                return null;
            }
            
        }

        public int Add(StudentModel stu)
        {
            int a = 0;
            using (MySqlConnection conn = new MySqlConnection(sqlselect))
            {
                try
                {
                    conn.Open();
                    
                    string name = stu.name;
                    string sex = stu.sex;
                    string sqladd = "insert into student(name, sex) values ('"+name+"','"+sex+"')";
                    MySqlCommand cmd = new MySqlCommand(sqladd,conn);

                    a = cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return a;
        }

        public int Delete(StudentModel stu)
        {
            int a = 0;
            using (MySqlConnection conn = new MySqlConnection(sqlselect))
            {
                try
                {
                    conn.Open();
                    int id = stu.id;
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from student where id = " + id;
                    a = cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return a;
        }

        public int Update(StudentModel stumod)
        {
            int a = 0;
            using(MySqlConnection conn = new MySqlConnection(sqlselect))
            {
                try
                {
                    conn.Open();
                    int id = stumod.id;
                    string name = stumod.name;
                    string sex = stumod.sex;
                    string upsql = "update student set name = '"+name+"', sex = '"+sex+"' where id = "+id;
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = upsql;
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