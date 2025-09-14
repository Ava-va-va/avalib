 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeFile
{
    internal class ChangeFile
    {
        static void Main(string[] args)
        {
            //删除桌面文件
            //string path = "C:\\Users\\autumn\\Desktop";直接复制文件路径是这样，也可以手动将“\\”改成“/”
            // \是转义符，意思是转义符的下一个字符按字面意思写，不要当作特殊的符号。此处\\的意思就是一个\符号
            string path1 = "C:/Users/autumn/Desktop";//记录路径

            //获取该路径下的所有文件
            DirectoryInfo root = new DirectoryInfo(path1);//实例化，调用的DirectoryInfo()是构造函数，DirectoryInfo(string path),修饰符 类型名称（）
                                                          //之前括号内为空的是无参隐式构造函数。
                                                          //在进行实例化的时候，可以初始化类型里面的参数，接收参数之后会调用一些方法或者执行一些代码
                                                          //这里是通过实例来调用方法

            //数组，存储同一类型的数据，类比于List<>，此处为FileInfo类型的数组
            FileInfo[] files = root.GetFiles();
            //将数组转换LIst<>，List<数据类型> 变量名称=数组的名称.ToList
            //数组转换为泛型集合
            List<FileInfo> ListFiles = files.ToList();// List<FileInfo>这个集合中存的是一系列的FileInfo
            //循环文件
            int count = ListFiles.Count;
            for (int i = 0; i < count; i++)
            {
                string fileName = ListFiles[i].Name;//获取文件名
                //Console.WriteLine(fileName);////打印文件名

                if (fileName == "123.txt")
                {
                    Console.WriteLine("找到了文件123.txt");
                }

                //删除指定的文件
                if (ListFiles[i].Name == "123.txt")//判断文件名是否等于123.txt。ListFiles[i].Name是ListFiles集合中第i个FileInfo的Name属性
                {

                    System.IO.File.Delete(ListFiles[i].FullName);
                    Console.WriteLine("文件123.txt已经被删除了");
                }

                //判断文件名中是否包含指定内容
                bool isContains = fileName.ToLower().Contains("hello");//返回bool值，判断fileName中是否包含Hello
                                                                       //Contains是大小写敏感的，需要先全部同一形式，此处统一成小写，调用ToLower()方法
                                                                       //大写是ToUpper()，后面的判断也要跟前面的统一形式

                //判断是否有包含Hello的文件，并且给文件重命名
                if (isContains)
                {
                   
                    string srcFileName = ListFiles[i].FullName;//文件的源路径//文件原来的名字


                    ////使用File类的Move()方法来重命名文件
                    //string destFileName = ListFiles[i].Directory.FullName + "\\222" + ListFiles[i].Extension;//此处为拼接写法。文件夹的完整名字+文件需要修改的名字+文件的后缀（拓展名）



                    //使用Replace()方法来替换字符串
                                                                                                                          
                    
                    string destFileName = ListFiles[i].Directory.FullName +"\\"+ListFiles[i].Name.Replace("Hello", "222");//上面虽然先统一了大小写，但是替换的时候还是区分大小写的



                    //string destFileName = ListFiles[i].Directory.FullName+"\\222.txt";//// 目标路径//文件的目标名字

                    //Console.WriteLine(srcFileName);
                    //Console.WriteLine(destFileName);
                    File.Move(srcFileName, destFileName);//因为在同一目录下，所以将源文件重命名

                    
                    Console.WriteLine(fileName);
                    Console.WriteLine(isContains);

                    ////打印文件名和完整的文件名
                    //Console.WriteLine(ListFiles[i].FullName);//这里的ListFiles[i]访问的是FileInfo，这里的ListFiles[i].的“.”后面是FileInfo里的内容
                    //Console.WriteLine(ListFiles[i].Name);

                }

            }
            Console.ReadKey();

        }


    }
}
