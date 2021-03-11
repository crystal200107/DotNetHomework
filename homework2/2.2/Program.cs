using System;

namespace _2._2
{
    class Program
    {    
       

        static void Main(string[] args)
        {
            Console.WriteLine("请输入数列:");
            string str = Console.ReadLine();
            string[] a= str.Split(" ");

            double getMax()//获取最大数的方法
            {
                double max = double.Parse(a[0]);
                double currentNum;
                for(int i=0;i <= a.Length - 1; i++)
                {
                    currentNum = double.Parse(a[i]);
                    if(currentNum > max)
                    {
                        max = currentNum;
                    }
                }
                return max;
            }

            double getMin()//获取最小数的方法
            {
                double min = int.Parse(a[0]);
                double currentNum;
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    currentNum = double.Parse(a[i]);
                    if (currentNum < min)
                    {
                        min = currentNum;
                    }
                }
                return min;
            }

            double getAverage()//获取平均数的方法
            {
                double average=0;
                for(int i = 0;i <= a.Length - 1; i++)
                {
                    average += double.Parse(a[i]);
                }
                average = average / a.Length;
                return average;
            }
            
            double getAll()//获取平均数的方法
            {
                double all = 0;
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    all += double.Parse(a[i]);
                }
                return all;
                
            }

            Console.WriteLine("最大数为：" +getMax());
            Console.WriteLine("最小数为：" + getMin());
            Console.WriteLine("平均数为：" + getAverage());
            Console.WriteLine("总数为：" + getAll());





        }
    }
}
