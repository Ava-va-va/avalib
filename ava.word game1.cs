using ava.ClassLib;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace ava
{
    internal class Pro6
    {
        static void Main()
        {
            Console.WriteLine("在一个月黑风高的夜晚");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();  

            Console.WriteLine("微风拂动着路旁的小草");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            Console.WriteLine("这时，缓缓的走过来一个人：");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();
            Console.WriteLine("请输入大侠的名字：");
           
            Hero hr1=new Hero();//实例化处理，实例化了一个hr1  
            hr1.name=Console.ReadLine();
            
            Console.WriteLine("原来你就是"+ hr1.name + "!");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            ////基础属性1（默认值）
            ////实例  实例化
            //string Gender1 = "女";
            //int Age1 = 20;
            //int Damage1 = 100;
            //int HP1 = 100;//health points
            //int Tall1 = 175;
            //string Skill1 = "飞檐走壁";
            //int SkillDamage1 = 30;
            //string Skill2 = "小李飞刀";
            //int SkillDamage2 = 60;

            //Console.WriteLine("性别："+Gender1 );
            //Console.WriteLine("年龄：" + Age1);
            //Console.WriteLine("基础伤害：" + Damage1 );
            //Console.WriteLine("生命值：" + HP1);
            //Console.WriteLine("身高：" + Tall1);
            //Console.WriteLine("技能1：" + Skill1);
            //Console.WriteLine("技能1伤害：" + SkillDamage1);
            //Console.WriteLine("技能2：" + Skill2);
            //Console.WriteLine("技能2伤害：" + SkillDamage2);
            
            //使用实例化优化代码,便于理解
            hr1.Gender = "女";
            hr1. Age = 20;
            hr1.Damage = 100;
            hr1.HP = 100;//health points
            hr1.Tall = 175;
            hr1.Skill1  = "飞檐走壁"; 
            hr1.SkillDamage1 = 30;
            hr1.Skill2 = "小李飞刀";
            hr1.SkillDamage2 = 60;
            hr1.SkillDamage2 = 60;

            // hr1.ShowInfo();////通过方法直接输出
            //ShowInfo show1 = new ShowInfo();//创建实例
            //show1.ShowhrInfo(hr1);//实例方法调用
            ShowInfo.ShowhrInfo(hr1);//当输出的方法为static时，不需要区别对待，不需要实例化
                                     //直接通过ShowInfo这个类调用方法，括号内是需要处理的变量

            Console.ReadKey(); 
           
            //Console.WriteLine("性别：" + hr1.Gender);
            //Console.WriteLine("年龄：" + hr1.Age);
            //Console.WriteLine("基础伤害：" + hr1.Damage);
            //Console.WriteLine("生命值：" + hr1.HP);
            //Console.WriteLine("身高：" + hr1.Tall);
            //Console.WriteLine("技能1：" + hr1.Skill1);
            //Console.WriteLine("技能1伤害：" + hr1.SkillDamage1);
            //Console.WriteLine("技能2：" + hr1.Skill2);
            //Console.WriteLine("技能2伤害：" + hr1.SkillDamage2);
            //Console.WriteLine("请按任意键继续...");
            //Console.ReadKey();

            Console.WriteLine("此时，传来了一个男人的声音");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();
            Console.WriteLine("走近一看，原来是：");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            Console.WriteLine("请输入大侠的名字：");
           
            //使用实例化进行变量赋值，不易出错。
            Hero hr2= new Hero();//创建了一个实例，后续的都可以用与这一实例相关的变量来处理
            hr2.name=Console.ReadLine();

            Console.WriteLine("我天！是"+hr2.name +"!");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            ////基础属性2
            //string Gender2 = "男";
            //int Age2 = 21;
            //int Damage2 = 120;
            //int HP2 = 80;//health points
            //int Tall2 = 180;
            //string Skill11 = "蜻蜓点水";
            //int SkillDamage11 = 35;
            //string Skill12 = "铁砂掌";
            //int SkillDamage12 = 40;

            hr2.Gender = "男";
            hr2.Age = 21;
            hr2.Damage = 120;
            hr2.HP = 80;//health points
            hr2.Tall =  180;
            hr2.Skill1 = "蜻蜓点水";
            hr2.SkillDamage1 = 35;
            hr2.Skill2 = "铁砂掌";
            hr2.SkillDamage2 = 40;

            //ShowInfo show2 = new ShowInfo();
            //show2.ShowhrInfo(hr2);
            //不用按以上方法写，因为之前已经实例化过ShowInfo类型了
            //这时只用改变实例方法调用中的变量就行，这只是方法调用，不需要对实例进行赋值处理。
            //show1.ShowhrInfo(hr2);
            ShowInfo.ShowhrInfo(hr2);
            //Console.WriteLine("性别：" + hr2.Gender);
            //Console.WriteLine("年龄：" + hr2.Age);
            //Console.WriteLine("基础伤害：" + hr2.Damage);
            //Console.WriteLine( "生命值：" + hr2.HP);
            //Console.WriteLine("身高：" + hr2.Tall);
            //Console.WriteLine("技能1：" + hr2.Skill1);
            //Console.WriteLine("技能1伤害：" + hr2.SkillDamage1);
            //Console.WriteLine("技能2：" + hr2.Skill2);
            //Console.WriteLine("技能2伤害：" + hr2.SkillDamage2);

            Console.ReadKey();


        }
    }
   
}    
