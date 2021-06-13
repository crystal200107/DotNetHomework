using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0
{
    public class Merchant
    {
        public string StoreName { set; get; }
        public int StoreId { get; set; }
        public int ContactNum { get; set; }

        public Merchant(string storeName,int storeID,int contactNum)
        {
            this.StoreName = storeName;
            this.StoreId = storeID;
            this.ContactNum = contactNum;
        }

        public override string ToString()
        {
            return "商家名称：" + StoreName + " 商家店铺号：" + StoreId + " 售后服务电话：" + ContactNum + "\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Merchant merchant &&
                   StoreName == merchant.StoreName &&
                   StoreId == merchant.StoreId &&
                   ContactNum == merchant.ContactNum;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StoreName, StoreId, ContactNum);
        }
    }
}
