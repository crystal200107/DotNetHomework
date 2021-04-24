using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5._0.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();

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

        [TestInitialize]
        public void Init()
        {
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
            Order orderR = new Order(5, merchant3, customerC);
            orderR.AddDetails(new OrderDetails(goods5, 4));
            orderR.AddDetails(new OrderDetails(goods6, 6));

            //创建订单服务对象
            OrderService orderService = new OrderService();
            orderService.AddOrder(orderA);
            orderService.AddOrder(orderB);
            orderService.AddOrder(orderC);
        }

        [TestMethod()]
        public void OrderServiceTest()
        {   
            Assert.Fail();
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Order order = new Order(4, merchant3, customerC);
            orderService.AddOrder(order);
            Assert.IsTrue(orderService.orders.Count == 4);
            Assert.IsTrue(orderService.orders.Contains(order));
        }
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrderTest2()
        {
            Order order = new Order(4, merchant3, customerC);
            orderService.AddOrder(order);
        }
        [TestMethod()]
        public void RemoveOrderTest()
        {
            Order order = new Order();
            for (int i = 0;i <orderService.orders.Count -1;i ++)
            {
                if (orderService.orders[i].OrderID == 1)
                {
                    order = orderService.orders[i];
                    return;
                }
            }
            orderService.RemoveOrder(order);
            Assert.IsTrue(orderService.orders.Count == 2);
            Assert.IsTrue(orderService.orders.Contains(order));
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            Order orderBefore = new Order();
            Order orderAfter = new Order();
            for (int i = 0; i < orderService.orders.Count - 1; i++)
            {
                if (orderService.orders[i].OrderID == 3)
                {
                    orderBefore = orderService.orders[i];
                    return;
                }
            }
            for (int i = 0; i < orderService.orders.Count - 1; i++)
            {
                if (orderService.orders[i].OrderID == 5)
                {
                    orderAfter = orderService.orders[i];
                    return;
                }
            }
            orderService.UpdateOrder(orderAfter, 3);
            Assert.IsTrue(orderService.orders.Count == 3);
            Assert.IsTrue(orderService.orders.Contains(orderAfter));
        }

        [TestMethod()]
        public void GetByIDTest()
        {
            Order order1 = orderService.GetByID(1);
            Order order2 = orderService.GetByID(2);
            Order order3 = orderService.GetByID(3);
            Assert.IsTrue(order1 != null);
            Assert.IsTrue(order2 != null);
            Assert.IsTrue(order3 != null);
        }

        [TestMethod()]
        public void GetByMerchantTest()
        {
            List<Order> order1 = orderService.GetByMerchant("天猫");
            List<Order> order2 = orderService.GetByMerchant("淘宝");
            List<Order> order3 = orderService.GetByMerchant("京东");
            Assert.IsTrue(order1 != null);
            Assert.IsTrue(order2 != null);
            Assert.IsTrue(order3 != null);
        }

        [TestMethod()]
        public void GetByCustomerTest()
        {
            List<Order> order1 = orderService.GetByCustomer("张三");
            List<Order> order2 = orderService.GetByCustomer("李四");
            List<Order> order3 = orderService.GetByCustomer("王五");
            Assert.IsTrue(order1 != null);
            Assert.IsTrue(order2 != null);
            Assert.IsTrue(order3 != null);
        }

        [TestMethod()]
        public void GetByPriceTest()
        {
            List<Order> order1 = orderService.GetByPrice(100);
            Assert.IsTrue(order1 != null);

        }

        public void GetByGoodsTest()
        {
            List<Order> order1 = orderService.GetByGoods("瓜子");
            Assert.IsTrue(order1 != null);

        }

        [TestMethod()]
        public void GetAllTest()
        {
            List<Order> orders = orderService.GetAll();
            Assert.IsTrue(orders == orderService.orders);
        }

        [TestMethod()]
        public void SortTest()
        {
            orderService.orders.Sort();


            Assert.AreEqual(1, orderService.orders[0]);
            Assert.AreEqual(2, orderService.orders[1]);
            Assert.AreEqual(3, orderService.orders[2]);
            Assert.AreEqual(5, orderService.orders[3]);

        }

        [TestMethod()]
        public void ExportTest()
        {
            String path = "Test.xml";
            orderService.Export(path);
            Assert.AreEqual(File.ReadAllText(path), File.ReadAllText("ExportText.xml"));
            File.Delete(path);

        }

        [TestMethod()]
        public void ImportTest()
        {
            String path = "ExportText.xml";
            OrderService test = new OrderService();
            test.Import(path);
            Assert.AreEqual(test.orders, orderService.orders);
        }
    }
}