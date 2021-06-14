using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._0
{
    [Serializable]
    public class OrderDetails
    {
        [Key]
        public int DetailID { get; set; }
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

        public OrderDetails()
        {}

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
