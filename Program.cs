using System;
using System.IO;
namespace ava1
{
    internal class Pro2
    {
        static void Main()
        {
            ////不同类型数据处理要转换成同一个类型，运算之后要存在同一类型变量中
            //Console.WriteLine("请输入一个数字");
            //string str = Console.ReadLine();
            //string str1 = str + 20.ToString();
            //Console.WriteLine(str);
            //Console.WriteLine(str1);
            //Console.ReadKey();
            
            //将字符串数组组合成一个路径
            string[] paths = { @"d:\archives", "2001", "media", "images" };
            string fullPath = Path.Combine(paths);
            Console.WriteLine(fullPath);
            Console.ReadKey();
        }
    }
}
