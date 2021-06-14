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
    public class Goods
    {
        [Key]

        public int GoodsID { get; set; }
        public string GoodsName { get; set; }
        public double UnitPrice { get; set; }

        public Goods(int goodsID, string goodsName, double unitPrice)
        {
            this.GoodsID = goodsID;
            this.GoodsName = goodsName;
            this.UnitPrice = unitPrice;
        }


        public override string ToString()
        {
            return "商品货码：" + GoodsID + "商品名称：" + GoodsName + "商品单价：" + UnitPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   GoodsID == goods.GoodsID &&
                   GoodsName == goods.GoodsName &&
                   UnitPrice == goods.UnitPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GoodsID, GoodsName, UnitPrice);
        }
    }
}
