using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using NewStudent.Models;

namespace NewStudent.Dao
{
    public class StudentDao
    {
        string sql = "server = localhost; database = stutest; user = root; password = 123456; charset = utf8";
        
        public List<StudentMod> select()
        {
            using (MySqlConnection conn = new MySqlConnection(sql))
            {
                try
                {
                    conn.Open();
                    
                    string select = "select * from student";

                    MySqlDataAdapter sqlda = new MySqlDataAdapter(select,conn); //数据适配器 包含从数据库查询的结果

                    DataSet sqlds = new DataSet(); //创建数据集 用来接收表

                    sqlda.Fill(sqlds); //把sqlda得到的表格填充进sqlds数据表

                    DataTable stutab = sqlds.Tables[0]; //创建表

                    List<StudentMod> stumod = new List<StudentMod>();

                    for (int i = 0; i < stutab.Rows.Count; i++)  //循环赋值
                    {
                        DataRow row = stutab.Rows[i];

                        StudentMod sm = new StudentMod();

                        sm.Id = Convert.ToInt32(row["id"]);

                        sm.Name = Convert.ToString(row["name"]);

                        sm.Class = Convert.ToString(row["class"]);

                        stumod.Add(sm);
                    }
                    return stumod;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return null;
        }

    }
}