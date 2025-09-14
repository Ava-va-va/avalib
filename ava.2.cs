using System;

namespace ava
{
    internal class Pro3
    {
        static void Main()
        {
            string n = Console.ReadLine();
            //判断成绩在什么范围
            int m = int.Parse(n);
            bool bo1=m >60 && m < 80;
            if(m<60)
            {
                Console.WriteLine("成绩不合格");
            }
            else if((m>60 || m>71)||m ==80)
            {
                Console.WriteLine("成绩还行");
            }
            //多条件之间的运算
                //名称收集
                Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();

            //家乡收集
            Console.WriteLine("请输入你的故乡");
            string address = Console.ReadLine();

            //年龄收集
            Console.WriteLine("请输入你的年龄");
            string age = Console.ReadLine();

            //爱好收集
            Console.WriteLine("请输入你的爱好");
            string hobby = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //输出空行
            Console.WriteLine("你的名字是: " + name);
            Console.WriteLine("你的年龄是: " + age + "岁");
            Console.WriteLine("你的故乡是: " + address);
            Console.WriteLine("你的爱好是: " + hobby);
            Console.ReadKey();
        }
    }
}
