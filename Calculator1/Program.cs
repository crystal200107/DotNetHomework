using System;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n;
            string mark;
            Console.WriteLine("请输入第一个数字：\n");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：\n");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：\n");
            mark = Console.ReadLine();

            switch (mark)
            {
                case "+":
                    n = a + b;
                    Console.WriteLine("结果计算为：\n" + n);
                    break;
                case "-":
                    n = a - b;
                    Console.WriteLine("结果计算为：\n" + n);
                    break;
                case "*":
                    n = a + b;
                    Console.WriteLine("结果计算为：\n" + n);
                    break;
                case "/":
                   if(b== 0)
                    {
                        Console.WriteLine("除数不能为0！\n");
                      
                    }
                    else
                    {
                        n = a / b;
                        Console.WriteLine("结果计算为：\n" + n);
                    }
                    break;
                default:
                    Console.WriteLine("请输入正确的运算符！\n");
                    break;
                    

            }
           

        }
    }
}
