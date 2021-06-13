using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5._0;

namespace OrderWinForm
{
    public partial class FormAdd : Form
    {
        Order newOrder = new Order();
        OrderDetails newOrderDetails = new OrderDetails();
        public FormAdd(Order order,OrderDetails orderDetails)
        {
            this.newOrder = order;
            InitializeComponent();
            IDTB.DataBindings.Add("Text", newOrder, "OrderID");
            merchantCB.DataBindings.Add("SelectedItem", newOrder, "Merchant");
            customerCB.DataBindings.Add("SelectedItem", newOrder, "Customer");
            labelTime.Text = System.DateTime.Now.ToString();
            goodsCB.DataBindings.Add("SelectedItem", newOrderDetails, "Goods");
            numTB.DataBindings.Add("Text", newOrderDetails, "Num");

            merchantCB.Items.Add("merchant1");
            merchantCB.Items.Add("merchant2");
            merchantCB.Items.Add("merchant3");

            customerCB.Items.Add("customerA");
            customerCB.Items.Add("customerB");
            customerCB.Items.Add("customerC");

            goodsCB.Items.Add("花生");
            goodsCB.Items.Add("瓜子");
            goodsCB.Items.Add("矿泉水");
            goodsCB.Items.Add("啤酒");
            goodsCB.Items.Add("苹果");
            goodsCB.Items.Add("八宝粥");
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            FormMain formMain = (FormMain)this.Owner;
            newOrder.AddDetails(newOrderDetails);
            formMain.orderService.AddOrder(newOrder);
            formMain.OrderbindingSource.ResetBindings(false);
            formMain.OrderdetailbindingSource.ResetBindings(false);
            this.Close();
        }
    }
}
