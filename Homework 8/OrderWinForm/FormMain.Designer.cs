
namespace OrderWinForm
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merchantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totoalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailGridView = new System.Windows.Forms.DataGridView();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderdetailbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdetailbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBoxOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxOrder);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 56);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(880, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 45);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Location = new System.Drawing.Point(578, 17);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(269, 25);
            this.textBoxOrder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Location = new System.Drawing.Point(405, 19);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOrder.TabIndex = 1;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(32, 22);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(338, 15);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "欢迎来到订单查询系统!请选择对应信息进行查询~";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInput);
            this.panel2.Controls.Add(this.btnOutput);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1118, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 589);
            this.panel2.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(25, 370);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 45);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "导入订单";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(25, 290);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 45);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "导出订单";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(25, 210);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 45);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改订单";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除订单";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "创建订单";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OrderGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1118, 589);
            this.splitContainer1.SplitterDistance = 649;
            this.splitContainer1.TabIndex = 2;
            // 
            // OrderGridView
            // 
            this.OrderGridView.AutoGenerateColumns = false;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.orderTimeDataGridViewTextBoxColumn1,
            this.merchantDataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn1,
            this.totoalPriceDataGridViewTextBoxColumn1});
            this.OrderGridView.DataSource = this.OrderbindingSource;
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGridView.Location = new System.Drawing.Point(0, 0);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowHeadersWidth = 51;
            this.OrderGridView.RowTemplate.Height = 27;
            this.OrderGridView.Size = new System.Drawing.Size(649, 589);
            this.OrderGridView.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "订单号";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderTimeDataGridViewTextBoxColumn1
            // 
            this.orderTimeDataGridViewTextBoxColumn1.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn1.HeaderText = "订单时间";
            this.orderTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderTimeDataGridViewTextBoxColumn1.Name = "orderTimeDataGridViewTextBoxColumn1";
            this.orderTimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // merchantDataGridViewTextBoxColumn1
            // 
            this.merchantDataGridViewTextBoxColumn1.DataPropertyName = "Merchant";
            this.merchantDataGridViewTextBoxColumn1.HeaderText = "商家";
            this.merchantDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.merchantDataGridViewTextBoxColumn1.Name = "merchantDataGridViewTextBoxColumn1";
            this.merchantDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "顾客";
            this.customerDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            this.customerDataGridViewTextBoxColumn1.Width = 125;
            // 
            // totoalPriceDataGridViewTextBoxColumn1
            // 
            this.totoalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotoalPrice";
            this.totoalPriceDataGridViewTextBoxColumn1.HeaderText = "总价";
            this.totoalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totoalPriceDataGridViewTextBoxColumn1.Name = "totoalPriceDataGridViewTextBoxColumn1";
            this.totoalPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // OrderbindingSource
            // 
            this.OrderbindingSource.DataSource = typeof(_5._0.Order);
            // 
            // detailGridView
            // 
            this.detailGridView.AutoGenerateColumns = false;
            this.detailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.goodsTotalPriceDataGridViewTextBoxColumn});
            this.detailGridView.DataSource = this.OrderdetailbindingSource;
            this.detailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGridView.Location = new System.Drawing.Point(0, 0);
            this.detailGridView.Name = "detailGridView";
            this.detailGridView.RowHeadersWidth = 51;
            this.detailGridView.RowTemplate.Height = 27;
            this.detailGridView.Size = new System.Drawing.Size(465, 589);
            this.detailGridView.TabIndex = 0;
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
            // OrderdetailbindingSource
            // 
            this.OrderdetailbindingSource.DataSource = typeof(_5._0.OrderDetails);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 645);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdetailbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.DataGridView detailGridView;
        public System.Windows.Forms.BindingSource OrderbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn merchantDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totoalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.BindingSource OrderdetailbindingSource;
    }
}

