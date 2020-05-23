using System;

namespace ConsoleApp2sa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            int[] score = new int[5];
            for (int i = 0; i < name.Length; i++)
            {

                Console.Write("请输入第"+(i+1)+"位同学姓名:");
                name[i] = Console.ReadLine();
                Console.Write("请输入第" + (i + 1) + "位同学分数:");
                score[i] =int.Parse( Console.ReadLine());

            }
            int sum = 0, avg;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            avg = sum / score.Length;

            Console.WriteLine("总分：" + sum + "平均分：" + avg);
        }
    }
}
