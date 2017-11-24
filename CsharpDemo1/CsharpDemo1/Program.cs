using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];//姓名数组
            int[] score = new int[5];
            for(int i =0; i<name.Length;i++)
            {
                Console.Write("请输入第" + (i + 1) + "名同学姓名");
                name[i] = Console.ReadLine();
                Console.Write("请输入第"+(i+1)+"位同学分数");
                score[i] = int.Parse(Console.ReadLine());
            }
            //求出所有2同学总分和平均值并打印
            //添加断点F9;调试F5;单步执行F10
            int sum = 0,avg;
            for(int i=0;i<score.Length;i++)
            {
                sum += score[i];
            }
            avg = sum / score.Length;
            Console.WriteLine("总分:{0}，平均分{1}", sum, avg);
        }
    }
}
