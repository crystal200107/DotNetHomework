using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _10._0
{
    public partial class Form1 : Form
    {
        SimpleCrawler SimpleCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            SimpleCrawler.PageDownloaded += Download;
            SimpleCrawler.CrawlerStopped += Stop;
        }
        
        //以下事件以进行修改，参照群内第十次作业的模板
        private void Stop(SimpleCrawler crawler)
        {
            Action action = () => Lab_state.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Download(SimpleCrawler crawler,string url,string info)
        {
            var pageInfo = new { Index = bindingSourceUrls.Count + 1, URL = url, Status = info };
            Action action = () => { bindingSourceUrls.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }

        }
        
        //原来版本代码，修改后按示例代码写的

        /*private void btn_start_Click(object sender, EventArgs e)
        {
            bindingSource_Urls.DataSource = SimpleCrawler.urlList;
            SimpleCrawler.initUrl = tb_web.Text;
            SimpleCrawler.urls.Add(SimpleCrawler.initUrl, false);
        }*/


        private void Btn_start_Click(object sender, EventArgs e)
        {
            Lab_state.Text = "正在爬取中";
            SimpleCrawler.StartURL = TB_web.Text;
            Match match = Regex.Match(SimpleCrawler.StartURL, SimpleCrawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            SimpleCrawler.HostFilter = "^" + host + "$";
            SimpleCrawler.FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";
            Task task = Task.Run(() => SimpleCrawler.Start());
        }


    }
}
