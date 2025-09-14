using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ava.ClassLib
{
     public class Hero
    //internal class Hero////internal只能再在同一程序集（.dll或.exe)内使用，对程序外全部隐藏
    {
        //相当于创建了一个类型， 在主函数中可以将类型实例化（把类实例化）
        //不加public的话默认是private，无法进行外部访问
        public string name;
        public string Gender;
        public int Age;
        public int Damage;
        public int HP;
        public int Tall;
        public string Skill1;
        public int SkillDamage1;
        public string Skill2;
        public int SkillDamage2;

        //public static string staticInfo = "520";////在代码运行时已经创建完成（类似预加载），可直接通过Hero来调用该变量的值
        ////通过比如说上面的hr1，根本 访问不到，只能通过Hero来访问
        ////不是模板，就是定义了一个值  



        //创建方法，相当于之前的创建函数，然后可以调用。
        public void ShowInfo()//不写static，是实例方法。适用于需要访问或修改对象的状态
                              //eg：ShowInfo要显示对象的特定属性（如用户名、年龄），它必须通过对象实例来调用
                              //public是可以在类之外进行外部访问
                              //static不需要实例化（在程序运行时，就存在于内存空间中，不需要实例化去申请内存空间）

        {
            Console.WriteLine("性别：" + Gender);
            Console.WriteLine("年龄：" + Age);
            Console.WriteLine("基础伤害：" + Damage);
            Console.WriteLine("生命值：" + HP);
            Console.WriteLine("身高：" + Tall);
            Console.WriteLine("技能1：" + Skill1);
            Console.WriteLine("技能1伤害：" + SkillDamage1);
            Console.WriteLine("技能2：" + Skill2);
            Console.WriteLine("技能2伤害：" + SkillDamage2);
        }

    }

}
