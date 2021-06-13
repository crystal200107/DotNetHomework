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
using Microsoft.VisualBasic;

namespace OrderWinForm
{
    public partial class FormReload : Form
    {
        public Order orderModified = new Order();
        private OrderService orderService = new OrderService();
        private OrderDetails orderDetails = new OrderDetails();
        
        public FormReload(Order order)
        {
            InitializeComponent();
            orderModified = order;
            orderModified.OrderDetails.Add(orderDetails);
            textBoxID.DataBindings.Add("Text",OrderBindingSource, "OrderID");
            cbBoxMerchant.DataBindings.Add("SelectedItem", OrderBindingSource, "Mechant");
            cbBoxCustomer.DataBindings.Add("SelectedItem", OrderBindingSource, "Customer");
            labTime.Text = orderModified.OrderTime.ToString();

            cbBoxMerchant.Items.Add("merchant1");
            cbBoxMerchant.Items.Add("merchant2");
            cbBoxMerchant.Items.Add("merchant3");

            cbBoxCustomer.Items.Add("customerA");
            cbBoxCustomer.Items.Add("customerB");
            cbBoxCustomer.Items.Add("customerC");

        }
      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = (FormAdd)this.Owner;
            formAdd.Show();
            textBoxID.DataBindings.Add("Text", OrderDetailBindingSource, "OrderID");
            cbBoxMerchant.DataBindings.Add("SelectedItem", OrderDetailBindingSource, "Mechant");
            cbBoxCustomer.DataBindings.Add("SelectedItem", OrderDetailBindingSource, "Customer");
            orderModified.OrderDetails.Add(orderDetails);
            OrderBindingSource.ResetBindings(false);
            OrderDetailBindingSource.ResetBindings(false);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < DetailGridView.Rows.Count - 1; i++)
            {
                orderModified.OrderDetails[i].Goods.GoodsName = DetailGridView.Rows[i].Cells[0].Value.ToString();
                orderModified.OrderDetails[i].Num = int.Parse(DetailGridView.Rows[i].Cells[1].Value.ToString());
                orderModified.OrderDetails[i].GoodsTotalPrice = double.Parse(DetailGridView.Rows[i].Cells[2].Value.ToString());
            }
            OrderBindingSource.ResetBindings(false);
            OrderDetailBindingSource.ResetBindings(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = DetailGridView.CurrentCell.RowIndex;
            orderModified.RemoveDetails(orderModified.OrderDetails[selectedIndex]);
            OrderBindingSource.ResetBindings(false);
            OrderDetailBindingSource.ResetBindings(false);
        }
    }
}
