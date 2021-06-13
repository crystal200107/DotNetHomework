using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleCrawler SimpleCrawler = new SimpleCrawler();

        private void Form1_Load(object sender, EventArgs e)
        {
            lab_state.DataBindings.Add("Text", SimpleCrawler, "message");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            bindingSource_Urls.DataSource = SimpleCrawler.urlList;
            SimpleCrawler.initUrl = tb_web.Text;
            SimpleCrawler.urls.Add(SimpleCrawler.initUrl, false);
        }
    }
}
