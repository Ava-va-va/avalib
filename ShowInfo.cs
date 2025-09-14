using ava.ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ava
{
    internal class ShowInfo
    {
        // .dll文件，发给别人之后，c#会对内部类型的访问，但是必须是public，访问类型要是对外设置访问
        //public void ShowhrInfo(Hero hr)这里是静态的，只是执行一个简单的输出，不需要对实例化变量进行处理，可以用static的
        public static void ShowhrInfo(Hero hr)
        {
            Console.WriteLine("性别：" + hr.Gender);
            Console.WriteLine("年龄：" + hr.Age);
            Console.WriteLine("基础伤害：" + hr.Damage);
            Console.WriteLine("生命值：" + hr.HP);
            Console.WriteLine("身高：" + hr.Tall);
            Console.WriteLine("技能1：" + hr.Skill1);
            Console.WriteLine("技能1伤害：" + hr.SkillDamage1);
            Console.WriteLine("技能2：" + hr.Skill2);
            Console.WriteLine("技能2伤害：" + hr.SkillDamage2);
        }
    }
}
       

