
namespace OrderWinForm
{
    partial class FormReload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxMerchant = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.DetailGridView = new System.Windows.Forms.DataGridView();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbBoxCustomer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbBoxMerchant);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 112);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 9;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(121, 63);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(55, 15);
            this.labTime.TabIndex = 8;
            this.labTime.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "下单时间：";
            // 
            // cbBoxCustomer
            // 
            this.cbBoxCustomer.FormattingEnabled = true;
            this.cbBoxCustomer.Location = new System.Drawing.Point(837, 25);
            this.cbBoxCustomer.Name = "cbBoxCustomer";
            this.cbBoxCustomer.Size = new System.Drawing.Size(121, 23);
            this.cbBoxCustomer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "顾客：";
            // 
            // cbBoxMerchant
            // 
            this.cbBoxMerchant.FormattingEnabled = true;
            this.cbBoxMerchant.Location = new System.Drawing.Point(612, 25);
            this.cbBoxMerchant.Name = "cbBoxMerchant";
            this.cbBoxMerchant.Size = new System.Drawing.Size(121, 23);
            this.cbBoxMerchant.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "商家：";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(121, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(407, 25);
            this.textBoxID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "订单号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单明细";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.DetailGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 370);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(424, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 48);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除明细";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(232, 310);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(136, 48);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改明细";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加明细";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DetailGridView
            // 
            this.DetailGridView.AutoGenerateColumns = false;
            this.DetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.goodsTotalPriceDataGridViewTextBoxColumn});
            this.DetailGridView.DataSource = this.OrderDetailBindingSource;
            this.DetailGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailGridView.Location = new System.Drawing.Point(0, 0);
            this.DetailGridView.Name = "DetailGridView";
            this.DetailGridView.RowHeadersWidth = 51;
            this.DetailGridView.RowTemplate.Height = 27;
            this.DetailGridView.Size = new System.Drawing.Size(1163, 304);
            this.DetailGridView.TabIndex = 0;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "商品";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsTotalPriceDataGridViewTextBoxColumn
            // 
            this.goodsTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodsTotalPrice";
            this.goodsTotalPriceDataGridViewTextBoxColumn.HeaderText = "商品总价";
            this.goodsTotalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsTotalPriceDataGridViewTextBoxColumn.Name = "goodsTotalPriceDataGridViewTextBoxColumn";
            this.goodsTotalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderDetailBindingSource
            // 
            this.OrderDetailBindingSource.DataSource = typeof(_5._0.OrderDetails);
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(_5._0.Order);
            // 
            // FormReload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormReload";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBoxCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxMerchant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView DetailGridView;
        private System.Windows.Forms.BindingSource OrderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource OrderBindingSource;
    }
}