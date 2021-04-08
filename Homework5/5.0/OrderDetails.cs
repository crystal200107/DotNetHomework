using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0
{
    class OrderDetails
    {
        public Goods Goods { get; set; }
        public int Num { get; set; }
        public double GoodsTotalPrice
        {
            get
            {
                return Num * Goods.UnitPrice;
            }
            set
            {
                this.GoodsTotalPrice = value;
            }
        }

        public OrderDetails(Goods goods, int num)
        {
            this.Goods = goods;
            this.Num = num;
        }

        public override string ToString()
        {
            return "商品名称：" + Goods.GoodsName + "商品个数：" + Num + "商品总价：" + GoodsTotalPrice + "\n";
        }
        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Goods>.Default.Equals(Goods, details.Goods) &&
                   Num == details.Num &&
                   GoodsTotalPrice == details.GoodsTotalPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Goods, Num, GoodsTotalPrice);
        }



 

    }
}
