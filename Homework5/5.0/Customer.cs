using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0
{
    class Customer
    {
        public string Name { get; set; }
        public int PhoneNum { get; set; }
        
        public string Address { get; set; }

        public Customer(string name,int phoneNum,string address)
        {
            this.Name = name;
            this.PhoneNum = phoneNum;
            this.Address = address;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Name == customer.Name &&
                   PhoneNum == customer.PhoneNum &&
                   Address == customer.Address;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, PhoneNum, Address);
        }

        public override string ToString()
        {
            return "顾客姓名：" + Name + " 顾客联系电话：" + PhoneNum + " 顾客地址："+Address;

        }



    }
}
