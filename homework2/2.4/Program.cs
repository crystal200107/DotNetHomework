using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请分别输入矩阵的行数和列数m,n：");
            string str1 = Console.ReadLine();
            string[] a = str1.Split(' ');
            int m= int.Parse(a[0]);
            int n= int.Parse(a[1]);
            int[,] array = new int[m,n];

            Console.WriteLine("请从上到下，从左到右输入元素：");
            string str2 = Console.ReadLine();
            string[] b= str2.Split(' ');

            for(int i = 0; i <= m-1; i++)
            {
                for(int j = 0; j <= n-1; j++) { array[i, j] = int.Parse(b[i*n + j]); }
            }

            bool judge(int[,] array)
            {
                bool sign = true;
                for (int i = 0; i< m-1; i++)
                {
                    for(int j = 0;j < n-1; j++)
                    {
                        
                        if (array[i, j] != array[i + 1, j + 1]) { sign = false; }
                    }
                }

                return sign;
            }

            if (judge(array))
            {
                Console.WriteLine("该矩阵是托普利茨矩阵");
            }
            else
            {
                Console.WriteLine("该矩阵不是托普利茨矩阵");
            }



        }
    }
}
