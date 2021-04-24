using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0
{
    public class Order :IComparable<Order>
    {
        public int OrderID { get; set;}
        public DateTime OrderTime { get; set;}
        public Merchant Merchant { get; set;}
        public Customer Customer { get; set; }
        public double TotoalPrice
        {
            get
            {
                double sum = 0;
                foreach (OrderDetails o in OrderDetails)
                {
                    sum += o.GoodsTotalPrice;
                }
                return sum;
            }
            set
            {
                this.TotoalPrice = value;
            }
        }

        public List<OrderDetails> OrderDetails = new List<OrderDetails>();

        public Order() { }

        public Order(int orderID,Merchant merchant,Customer customer)
        {
            this.OrderID = orderID;
            this.Merchant = merchant;
            this.Customer = customer;
            this.OrderTime = DateTime.Now;
        }
        public override string ToString()
        {
            return "订单号：" + OrderID + " 订单时间：" + OrderTime +" "+ Merchant +" "+ Customer + " 订单总价：" + TotoalPrice;
        }

        public void AddDetails(OrderDetails orderDetails)
        {
            if (this.OrderDetails.Contains(orderDetails))
            {
                throw new ArgumentException("订单中已经有相对应的商品！");
            }
            OrderDetails.Add(orderDetails);
        }

        public void RemoveDetails(OrderDetails orderDetails)
        {
            if (!this.OrderDetails.Contains(orderDetails))
            {
                throw new MissingMemberException("该订单中没有对应商品信息");
            }
            OrderDetails.Remove(orderDetails);
        }

 

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderID);
        }
        public int CompareTo(Order order)
        {   if(order == null)
            {
                throw new ApplicationException("订单不存在");
            }
            return OrderID - order.OrderID;
        }
    }
}
