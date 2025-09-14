using System;
//关键字
//类型
namespace ava
    //门牌号
{
    class Pro1
    {
        //函数（方法）
        static void Main()
        {
            //入口点 函数直接或间接,都要写在这里.   
            //CPU只管执行指令,不管数据存储,数据存储在内存中.
            //变量类型 变量名称 = 初始值;
            //=:赋值符号,把右边的值赋给左边的变量.
            int n = 100;
            int m = 200;
            int sum = 0;
            sum = n + m;
            //无法再定义m，但是可以继续使用m
            m = m + 100;
            //重新赋值
            int n1 = 20;
            Console.WriteLine(n1);
            int n2 = 30;
            Console.WriteLine(n2);
            int temp = 0;
            Console.WriteLine(temp);
            temp = n1;
            Console.WriteLine(temp);
            n1 = n2;
            Console.WriteLine(n1);
            n2 = temp;
            Console.WriteLine(n2);         
            //交换两个变量的值
            string name = "你的计算结果是";
            Console.WriteLine(name);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
