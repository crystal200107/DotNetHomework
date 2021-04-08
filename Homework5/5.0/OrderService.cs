using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0
{
    class OrderService
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

        public Order GetOrder(int orderID)
        {
            return orders.Where(o => o.OrderID == orderID).FirstOrDefault();
        }

        public List<Order> GetAll()
        {
            return orders;
        }
        public void Sort(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }





    }
}
