using System;

namespace _2._1
{
    class Program
    {
      
        
     
        static void Main(string[] args)
        {
            int n;
          

            Console.WriteLine("请输入所需求解素数因子的数据");
            n = int.Parse(Console.ReadLine());


            bool isPrime(int prime)
            {
                for (int i = 2; i < prime; i++)
                {
                    if (prime % i == 0)
                    {
                       return false;
                    }
                   
                }
                return true;
            }

            if (n <= 1)
            {
                Console.WriteLine("该数字没有素数因子");
                return;
            }
            Console.WriteLine("素数因子如下：");
            for (int k = 2; k <= n; k++)
            {
                 if (n % k == 0)
                  {
                     if (isPrime(k))
                       {
                          Console.WriteLine(k);
                       }
                  }
             }
            
            
                
           
        }
    }
}
