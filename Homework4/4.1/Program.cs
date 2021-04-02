using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for (int i  = 0; i <= 5; i++) { list.Add(i); }
            int sum = 0;
            int min, max;
            min = max = list.Head.Data;


            Console.WriteLine("该列表的元素如下：" );
            list.ForEach(list, m => Console.Write(m+" "));
            Console.WriteLine("\n");

            list.ForEach(list, m =>min =  Math.Max(max, m));
            Console.WriteLine("该列表的最大值如下："+max);

            list.ForEach(list, m => min = Math.Min(min, m));
            Console.WriteLine("该列表的最小值如下："+min);

            list.ForEach(list, m => sum += m); 
            Console.WriteLine("该列表的总数如下："+sum);

        }
    }
}
