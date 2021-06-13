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
using System.Windows.Forms;

namespace _10._0
{
    //以9.0代码为基础进行修改，并将不合理部分进行注释
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

        //10.0中增加内容，参考示例代码进行编辑，以下代码均已作理解
        public event Action<SimpleCrawler> CrawlerStopped;

        public event Action<SimpleCrawler, string, string> PageDownloaded;

        //待下载队列
        public Queue<string> pending = new Queue<string>();
        //已下载网页
        public Dictionary<string, bool> DownloadedPages = new Dictionary<string, bool>();
        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string urlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //主机过滤规则
        public string HostFilter { get; set; }
        //文件过滤规则
        public string FileFilter { get; set; }
        //最大下载数量
        public int MaxPage { get; set; }
        //起始网址
        public string StartURL { get; set; }
        //网页编码
        public Encoding HtmlEncoding { get; set; }


        //9.0版本构造函数
        /*public SimpleCrawler()
            {
                urlList = new List<Urls>();
                message = "请输入网站";
            }
        */
        public SimpleCrawler()
        {
            MaxPage = 50;
            HtmlEncoding = Encoding.UTF8;
        }

        public void Start()
        {
            DownloadedPages.Clear();
            pending.Clear();
            pending.Enqueue(StartURL);
            Crawl();
        }

        //以下是针对各项限制条件进行的判定函数
        //已修改

        public bool WebJudge(string url) { return Regex.IsMatch(url, "^" + initUrl); }
        public bool HeadJudge(string url) { return Regex.IsMatch(url, @".(html|jsp|aspx)$"); }

        //相对地址转化为完整地址，9.0版本
        /*public string Transfrom(string url)
        {
            if (!Regex.IsMatch(url, @"^(https|http)://"))
            {
                return initUrl + @"/" + url;
            }
            else return url;
        }*/
        private void Crawl()
        {
            /*9.0版本爬行
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
            */
            while (DownloadedPages.Count < MaxPage && pending.Count > 0)
            {
                string url = pending.Dequeue();
                try
                {
                    string html = DownLoad(url); // 下载
                    DownloadedPages[url] = true;
                    PageDownloaded(this, url, "success");
                    Parse(html, url);//解析,并加入新的链接
                }
                catch (Exception ex)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
            CrawlerStopped(this);
        }

        //显示爬取的信息
        public void showInfo()
        {
            for (int i = 0; i < urlList.Count; i++)
            {
                Console.WriteLine(urlList[i].url + " : " + urlList[i].information);
            }
        }

        public string DownLoad(string url)
        {
            // showInfo();
            // Urls urls = new Urls();
            // urls.url = url;
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                //urls.information = "该地址爬取成功";
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
            //urlList.Add(urls);
        }

        private void Parse(string html, string Url)
        {
            //string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(urlDetectRegex).Matches(html);
            //foreach (Match match in matches)
            //{
            //  strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
            //          .Trim('"', '\"', '#', '>');
            // if (strRef.Length == 0) continue;
            //if (urls[strRef] == null) urls[strRef] = false;
            // }
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;

                linkUrl = FixUrl(linkUrl, Url);//转绝对路径
                                               //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !DownloadedPages.ContainsKey(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                }
            }

            //将非完整路径转为完整路径,参考课本示例
                string FixUrl(string url, string pageUrl)
                {
                if (url.Contains("://"))
                {
                    return url;
                }
                if (url.StartsWith("//"))
                {
                    Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                    string protocal = urlMatch.Groups["protocal"].Value;
                    return protocal + ":" + url;
                }
                if (url.StartsWith("/"))
                {
                    Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                    String site = urlMatch.Groups["site"].Value;
                    return site.EndsWith("/") ? site + url.Substring(1) : site + url;
                }

                if (url.StartsWith("../"))
                {
                    url = url.Substring(3);
                    int idx = pageUrl.LastIndexOf('/');
                    return FixUrl(url, pageUrl.Substring(0, idx));
                }

                if (url.StartsWith("./"))
                {
                    return FixUrl(url.Substring(2), pageUrl);
                }


                //其他相对路径
                int end = pageUrl.LastIndexOf("/");
                return pageUrl.Substring(0, end) + "/" + url;
            }

        }
    }
}
    

