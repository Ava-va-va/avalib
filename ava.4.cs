using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ava
{
    internal class Pro5
    {
        static void Main()
        {
            //构建for循环实现不断输入，直到输对了跳出循环。
            bool ischeck = true;
            int age = 0;
            for(;ischeck ;)//循环输入，直到输入正确为止。通过对布尔变量赋值来控制循环
            {
               Console.WriteLine("请输入你的年龄：");
                string str = Console.ReadLine();
                try
                {
                    age = int.Parse(str);
                    ischeck = false;//转换成功，输入的是正确形式的年龄，跳出循环。

                }
                catch
                {
                   
                    Console.WriteLine("请输入一个正确的年龄!");
                    ischeck = true;//转换失败，输入的不是正确形式的年龄，继续循环。
                }

            }
            age = age + 10;
            
            GetUserInfo();

            Console.WriteLine("你十年后的年龄是：" + age.ToString());
            Console.ReadKey();

        }

        ////程序错误处理
        //Console.WriteLine("请输入你的年龄：");
        //string str = Console.ReadLine();
        //int age = 0;
        //try//将有可能报错的代码放入其中,可以放多行。如果不报错，会正常执行try内的代码，会跳出组合（try  catch），直接进行后续代码
        //{
        //     age = int.Parse(str);
        //}
        //catch//try内的报错，会直接进入catch内
        //{ 
        //    Console.WriteLine("请输入一个正确的年龄（必须是数字）");
        //    Console.ReadKey();
        //    return;//直接return，下面的代码全部不执行，提前结束////这里main函数没有返回值，可以直接写return
        //}
        ////int age = int.Parse(str);////若只有这个转换，如果输入的是qq，无法将其转换成int变量并赋值给age，会报错，要用以上方法（try）。
        //Console.WriteLine("  ");
        //age = age + 10;
        //Console.WriteLine("你十年后的年龄是："+age.ToString());//所有类型转string类型直接用xx.Tostring()
        ////如果不使用xx.Tostring()，当遇到字符串类型和整形（int）相加的时候，c #会自动把整型转换成字符串类型，并将其进行拼接
        //Console.ReadKey();


        //泛型集合 ////eg：判断10个名字中里面几个叫张三
        //数组是用来存储同一类型数据的，但是泛型集合也可以用来做这个事情。（泛型集合可以理解为高级数组）
        /*List<string> names = new List<string>();*/////创建一个字符串类型的集合names，并且进行初始化
         ////加入数据
         //names.Add(Console.ReadLine());
         //names.Add("张三");
         //names.Add("李四");
         //names.Add("王五");
         //names.Add(Console.ReadLine());
         //names.Add("张三");
         //int num = 0;
         //for (int i = 0; i < names.Count; i++)////names.count：集合names中的（元素）数据个数
         //{
         //    if (names[i] == "张三")////集合names中的第i个数据（元素）是否为张三
         //    {
         //        num++;
         //    }
         //}
         //Console.WriteLine(num);
         //Console.ReadKey();


        //不好的麻烦方法
        //string name1 = " 张三 ";
        //string name2 = "李四";
        //string name3 = "王五";
        //int num = 0;
        //if(name1== " 张三 ")
        //{
        //    num++;
        //}
        //if (name2 == " 张三 ")
        //{
        //    num=num+1;
        //}
        //if (name3 == " 张三 ")
        //{
        //    num++;
        //}
        //以上一个一个写if很麻烦，要新的方法（泛型集合）很简便


        //变量的作用域，for里面定义的变量外面无法访问重新赋值
        //string name = "abc";
        //for (; name=="abc"; )
        //{
        //    string name11 = "bcd";
        //}
        //name11= "def";


        //启动for循环的方法
        //string name = " ";
        // for (; name!="张三"; )
        // {
        //     name=Console.ReadLine();
        // }
        //  Console.ReadKey();


        //for循环一般形式
        //for循环的例子和介绍
        //int i = 0;可以写到括号里，如下
        //for (int i = 0; i<=3 ; i = i + 1)
        ////for(初始值;对初始值进行判断;for循环完成之后对初始值进行的改变)
        //{
        //    GetUserInfo();
        //    //i = i + 1;
        //}
        //Console.ReadKey();


        static void GetUserInfo()
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
            //参数传递，接收
            name=ChangeData(name);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //输出空行
            Console.WriteLine("你的名字是: " + name);
            Console.WriteLine("你的年龄是: " + age + "岁");
            Console.WriteLine("你的故乡是: " + address);
            Console.WriteLine("你的爱好是: " + hobby);
        }
        
        static string ChangeData(string name1)//传递的参数(方法)类型以及名称
        {
            //string类型的返回值
            //判断表达式
            if (name1 == "张三")
            {
                Console.WriteLine("你输入的是张三");
                name1 = "法外狂徒张三";
            }
            else if (name1 == "李四")
            {
                Console.WriteLine("你输入的是李四");
                name1 = "无情铁手李四";
            }
            else if (name1 == "王五")
            {
                Console.WriteLine("你输入的是王五");
                name1 = "铁血柔情王五";
            }
            else

            {
                Console.WriteLine("你输入的名字不满足条件，不对你进行修改了");
            }
            //将处理完的name1返回
            return name1;
        }
    }
}
