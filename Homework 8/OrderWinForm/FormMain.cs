using System;
using _5._0;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderWinForm
{
    public partial class FormMain : Form
    {
        public OrderService orderService = new OrderService();
        public FormMain()
        {
            InitializeComponent();
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
            Order orderR = new Order(3, merchant3, customerC);
            orderR.AddDetails(new OrderDetails(goods5, 4));
            orderR.AddDetails(new OrderDetails(goods6, 6));

            //创建订单服务对象
            OrderService orderService = new OrderService();
            orderService.AddOrder(orderA);
            orderService.AddOrder(orderB);
            orderService.AddOrder(orderC);

            OrderbindingSource.DataSource = orderService.orders;

            comboBoxOrder.Items.Add("订单号");
            comboBoxOrder.Items.Add("客户");
            comboBoxOrder.Items.Add("商品");
            comboBoxOrder.Items.Add("商家");
            comboBoxOrder.Items.Add("总金额");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int type = comboBoxOrder.SelectedIndex;
            string index = textBoxOrder.Text;
            for (int i = 0; i < OrderGridView.Rows.Count; i++)
            {
                if (index == OrderGridView.Rows[i].Cells[type].Value.ToString()) 
                    { OrderGridView.Rows[i].Cells[0].Selected = true; }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            OrderDetails newOrderDetails = new OrderDetails();
            newOrder.AddDetails(newOrderDetails);
            FormAdd formAdd = new FormAdd(newOrder,newOrderDetails);
            formAdd.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string type = comboBoxOrder.SelectedItem.ToString();
            string index = textBoxOrder.Text;
            switch (type)
            {
                case "订单号":
                    Order order1 = orderService.GetByID(int.Parse(index));
                    orderService.RemoveOrder(order1);
                    break;
                case "客户":
                    List<Order> order2 = orderService.GetByCustomer(index);
                    for(int i = 0; i < order2.Count - 1; i++) { orderService.RemoveOrder(order2[i]); }
                    break;
                case "商家":
                    List<Order> order3 = orderService.GetByMerchant(index);
                    for (int i = 0; i < order3.Count - 1; i++) { orderService.RemoveOrder(order3[i]); }
                    break;
                case "商品":
                    List<Order> order4 = orderService.GetByGoods(index);
                    for (int i = 0; i < order4.Count - 1; i++) { orderService.RemoveOrder(order4[i]); }
                    break;
                case "总金额":
                    List<Order> order5 = orderService.GetByPrice(int.Parse(index));
                    for (int i = 0; i < order5.Count - 1; i++) { orderService.RemoveOrder(order5[i]); }
                    break;

            }
            OrderbindingSource.ResetBindings(false);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(OrderGridView.CurrentRow.Cells[0].Value.ToString());
            
            for(int i = 0;i <= orderService.orders.Count-1;i++)
            {
                if(orderService.orders[i].OrderID == ID)
                {
                    FormReload formReload = new FormReload(orderService.orders[i]);
                    formReload.Show();
                }
            }

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) { orderService.Export(folderBrowserDialog.SelectedPath); }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) { orderService.Import(folderBrowserDialog.SelectedPath); }
        }
    }
}
