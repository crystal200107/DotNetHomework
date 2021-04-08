using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer customerA = new Customer("张三", 111, "武汉");
                Customer customerB = new Customer("李四", 222, "北京");
                Customer customerC = new Customer("王五", 333, "长沙");

                Merchant merchant1 = new Merchant("天猫", 1, 666);
                Merchant merchant2 = new Merchant("淘宝", 2, 777);
                Merchant merchant3 = new Merchant("京东", 3, 888);

                Goods goods1 = new Goods(1, "花生", 15);
                Goods goods2 = new Goods(2, "瓜子", 5);
                Goods goods3 = new Goods(3, "矿泉水", 1);
                Goods goods4 = new Goods(4, "啤酒", 6);
                Goods goods5 = new Goods(5, "苹果", 2.5);
                Goods goods6 = new Goods(6, "八宝粥", 5.2);

                //order A
                Order orderA = new Order(1, merchant1, customerA);
                orderA.AddDetails(new OrderDetails(goods1, 5));
                orderA.AddDetails(new OrderDetails(goods2, 4));
                orderA.AddDetails(new OrderDetails(goods3, 5));

                //order B
                Order orderB = new Order(2, merchant2, customerB);
                orderB.AddDetails(new OrderDetails(goods4, 6));

                //order C
                Order orderC = new Order(3, merchant3, customerC);
                orderC.AddDetails(new OrderDetails(goods5, 3));
                orderC.AddDetails(new OrderDetails(goods6, 5));

                //order R
                Order orderR = new Order(3, merchant3, customerC);
                orderR.AddDetails(new OrderDetails(goods5, 4));
                orderR.AddDetails(new OrderDetails(goods6, 6));

                //创建订单服务对象
                OrderService orderService = new OrderService();
                orderService.AddOrder(orderA);
                orderService.AddOrder(orderB);
                orderService.AddOrder(orderC);
                //测试功能
                Console.WriteLine(orderService.GetOrder(2));
                Console.WriteLine("\n");

                //先打印所有的，再去修改删除试试
                orderService.Sort((o1, o2) => o2.TotoalPrice.CompareTo(o1.TotoalPrice));
                List<Order> before = orderService.GetAll();
                foreach(Order i in before) { Console.WriteLine(i); }
                Console.WriteLine("\n");

                orderService.RemoveOrder(orderA);
                orderService.UpdateOrder(orderR, 3);

                orderService.Sort((o1, o2) => o2.TotoalPrice.CompareTo(o1.TotoalPrice));
                List<Order> after = orderService.GetAll();
                foreach (Order i in after) { Console.WriteLine(i); }
                Console.WriteLine("\n");


            }
            catch(Exception e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("测试结束！"); }



        }
    }
}
