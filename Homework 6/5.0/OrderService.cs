using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace _5._0
{
    [Serializable]
    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        public OrderService() { }

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new ApplicationException("当前订单已存在！");
            }
            orders.Add(order);
        }
  
        public void RemoveOrder(Order order)
        {
            if(!orders.Contains(order))
            {
                throw new MissingMemberException("后台中没有对应订单信息!");
            }
            orders.Remove(order);
        }

        public void UpdateOrder(Order order,int orderID)
        {
            Order order1 = orders.Where(o => o.OrderID == orderID).FirstOrDefault();
            if (order1 == null) { throw new ApplicationException("不存在订单号对应的订单"); }
            RemoveOrder(order1);
            AddOrder(order);
        }

        public Order GetByID(int orderID)
        {
            return orders.Where(o => o.OrderID == orderID).FirstOrDefault();
        }

        public List<Order> GetByMerchant(string name)
        {
           var list = orders.Where(o => o.Merchant.StoreName== name);
           if(list == null) { throw new ApplicationException("不存在该姓名对应商家的订单！"); }
            return list.ToList();
        }

        public List<Order> GetByCustomer(string name)
        {
            var list = orders.Where(o => o.Customer.Name == name);
            if (list == null) { throw new ApplicationException("不存在该姓名对应顾客的订单！"); }
            return list.ToList();
        }
        public List<Order> GetByPrice(double price)
        {
            var list = orders.Where(o => o.TotoalPrice  == price);
            if (list == null) { throw new ApplicationException("不存在对应总价的订单！"); }
            return list.ToList();
        }

        public List<Order> GetByGoods(string name)
        {
            var list = orders.Where(o => o.OrderDetails.Any(n => n.Goods.GoodsName == name));
            if (list == null) { throw new ApplicationException("不存在包含对应货物的订单！"); }
            return list.ToList();
        }
        
        public List<Order> GetAll()
        {
            return orders;
        }
        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }

        //序列化内容，第六次作业
        public void Export(string path)
        {
            Console.WriteLine("XML序列化");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            Console.WriteLine("XML反序列化");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                List<Order> orders = (List<Order>)xmlSerializer.Deserialize(fs);
                orders.ForEach(order =>
                {
                    if (!orders.Contains(order)) { orders.Add(order); }
                });

            }
        }



    }
}
