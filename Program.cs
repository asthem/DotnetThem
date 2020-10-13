using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace them
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;

            var command = args[flag];
            flag++;
            if (command.Equals("new"))
            {
                Console.WriteLine($"创建项目名字为{args[flag]}");
                // //创建app 名字为
                // // args[1];
                // // var root=Directory.GetCurrentDirectory();
                // Console.WriteLine(root);
            }

            if (command.Equals("generate") || command.Equals("g"))
            {
                command = args[flag];
                flag++;
                if (command.Equals("model"))
                {
                    Console.WriteLine($"创建对象名字{args[flag]}");
                    flag++;
                    for (var i = flag++; i <= args.Length - 1; i++)
                    {
                        Console.WriteLine($"对象属性名字{args[i]}");
                    }

                    var key = "";
                    do
                    {
                        Console.WriteLine("存在文件是否覆盖 f c");
                        key = Console.ReadKey().ToString();
                    } while (!key.Equals("q"));
                }
            }

            // String createTable = "them new app";
            Console.WriteLine("Hello them!");
        }
    }
}