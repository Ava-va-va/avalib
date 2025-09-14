using System;



namespace ava
{
    internal class Pro2
    {

        static void Main()
        {
            //bool bo1 = false;

            //if (bo1)
            //{
            //    Console.WriteLine("这是if的内部");
            //    Console.WriteLine("bool只有为true,你才能看到我");
            //}
            //tab键是填入联想的
            //名称收集
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            //表达式  =优先值最低，先判断name和张三是否相等，等就是ture，不等就是false；再将值返还给check
            //bool ischeck = name != "张三";不等于
            // bool check1= name == "张三";
            if (name == "张三")
            {
                Console.WriteLine("你输入的是张三");
                name = "法外狂徒张三";
            }
            //else if (name == "法外狂徒张三")
            //{
            //    Console.WriteLine("你输入的是法外狂徒张三");
            //    name = "怎么老是张三";
            //}
            //else if (name == "李四")
            //{
            //    Console.WriteLine("你输入的是李四");
            //    name = "无情铁手李四";
            //}
            //else if (name == "王五")
            //{
            //    Console.WriteLine("你输入的是王五");
            //    name = "铁血柔情王五";
            //}
            else
            {
                Console.WriteLine("你输入的名字不满足条件，不对你进行修改了");
            }
            //Console.WriteLine("你输入的名字不满足条件，不对你进行修改了");
            //bool check2 = name == "李四";
            //if (check2)
            //{
            //    Console.WriteLine("你输入的是李四");
            //    name = "无情铁手李四";
            //}
            //bool check2 = name == "法外狂徒张三";
            //if (check2)
            //{
            //    Console.WriteLine("你输入的是法外狂徒张三");
            //    name = "怎么老是张三";

            //}

            //家乡收集
            Console.WriteLine("请输入你的故乡");
            string address = Console.ReadLine();

            //年龄收集
            Console.WriteLine("请输入你的年龄");
            string age = Console.ReadLine();

            //爱好收集
            Console.WriteLine("请输入你的爱好");
            string hobby = Console.ReadLine();


            //重新给变量赋值

            //组织格式
            //另一种格式：string info = "你的名字是: "
            //string info1 = info + name;
            //Conspole.WriteLine(info1);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //输出空行
            Console.WriteLine("你的名字是: "+ name);
            Console.WriteLine("你的年龄是: " + age +"岁"); 
            Console.WriteLine("你的故乡是: " + address);
            Console.WriteLine("你的爱好是: " + hobby);
            Console.ReadKey();
        }
    }
}