using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


//已参照老师示例代码进行修改
namespace _9._0
{
    public class Urls
    {
        public string url { get; set; }
        public string information { get; set; }
    }
    public class SimpleCrawler
    {
        //课本示例代码内容
        public Hashtable urls = new Hashtable();
        private int count = 0;

        //针对需求修改的内容
        public List<Urls> urlList { get; set; }
        public string initUrl { get; set; }
        public string message { get; set; }

        //课本示例内容
       /* static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }
       */

        public SimpleCrawler()
        {
            urlList = new List<Urls>();
            message = "请输入网站";
        }

        //以下是针对各项限制条件进行的判定函数
        //已修改

        public bool WebJudge(string url) { return Regex.IsMatch(url, "^" + initUrl); }
        public bool HeadJudge(string url) { return Regex.IsMatch(url, @".(html|jsp|aspx)$"); }
        
        //相对地址转化为完整地址
        public string Transfrom(string url)
        {
            if (!Regex.IsMatch(url, @"^(https|http)://"))
            {
                return initUrl+ @"/" + url;
            }
            else return url;
        }
        private void Crawl()
        {
            message = "开始爬行了....";
            Console.WriteLine(message);
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                else if (!WebJudge(current)) { break; }
                Console.WriteLine("爬行" + current + "页面!");
                current = Transfrom(current);//转换为完整地址
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                if (!HeadJudge(current)) break;
                Parse(html);//解析,并加入新的链接

                message = "爬行结束";
                Console.WriteLine(message);
            }
        }

        //显示爬取的信息
        public void showInfo()
        {
            for(int i = 0; i<urlList.Count; i++)
            {
                Console.WriteLine(urlList[i].url + " : " + urlList[i].information);
            }
        }

        public string DownLoad(string url)
        {
            showInfo();
            Urls urls = new Urls();
            urls.url = url;
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                urls.information = "该地址爬取成功";
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
            urlList.Add(urls);
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
