using System;

namespace ava
{
    internal class Pro4
    {
        static void Main()
        {
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
            //判断表达式
            if (name == "张三")
            {
                Console.WriteLine("你输入的是张三");
                name = "法外狂徒张三";
            }
            else
            {
                Console.WriteLine("你输入的名字不满足条件，不对你进行修改了");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //输出空行
            Console.WriteLine("你的名字是: " + name);
            Console.WriteLine("你的年龄是: " + age + "岁");
            Console.WriteLine("你的故乡是: " + address);
            Console.WriteLine("你的爱好是: " + hobby);
            //名称收集
            //通过对变量重新赋值，实现多个数据的收集
            Console.WriteLine("请输入你的姓名");
            name = Console.ReadLine();

            //家乡收集
            Console.WriteLine("请输入你的故乡");
            address = Console.ReadLine();

            //年龄收集
            Console.WriteLine("请输入你的年龄");
            age = Console.ReadLine();

            //爱好收集
            Console.WriteLine("请输入你的爱好");
            hobby = Console.ReadLine();
            //判断表达式
            if (name == "张三")
            {
                Console.WriteLine("你输入的是张三");
                name = "法外狂徒张三";
            }
            else
            {
                Console.WriteLine("你输入的名字不满足条件，不对你进行修改了");
            }
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