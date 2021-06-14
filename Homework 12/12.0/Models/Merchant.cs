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
    public class Merchant
    {

        [Key]
        public string StoreName { set; get; }
        public int ContactNum { get; set; }

        public Merchant(string storeName, int contactNum)
        {
            this.StoreName = storeName;
            this.ContactNum = contactNum;
        }

        public override string ToString()
        {
            return "商家名称：" + StoreName +  " 售后服务电话：" + ContactNum + "\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Merchant merchant &&
                   StoreName == merchant.StoreName &&
                   ContactNum == merchant.ContactNum;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StoreName,ContactNum);
        }
    }
}
