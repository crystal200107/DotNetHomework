using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            a = new int[99];
            
            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = i + 2;
            }
            
           //遍历数组，将不符合埃氏筛法的数字换成-1，再将所有素数输出
            for(int j = 2;j <= 100; j++)
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    if (a[i] % j == 0 && a[i] != j) { a[i] = -1; }
                }
            }
                    
                  
             


            

            Console.WriteLine("2~100的素数如下：");
            for (int i = 0; i <= a.Length-1; i++)
            {
                if (a[i] > 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
