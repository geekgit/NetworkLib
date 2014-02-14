using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using HtmlAgilityPack;

public static class NetworkLib
{
    public static int Hello()
    {
        
        return 4;
    }

    public static WebProxy[] GetProxyListFromTopdan()
    {
        HtmlDocument htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(new HttpClient().GetStringAsync(@"http://www.topdan.ru/proxy-list").Result);
        var proxy = from row in htmlDoc.DocumentNode.SelectNodes("//div[@style=\"width:820px;height:20px;\"]")
                    let cols = row.SelectNodes("div")
                    let ip = IPAddress.Parse(cols[0].InnerText)
                    let port = int.Parse(cols[1].InnerText)
                    select new WebProxy(ip.ToString(), port);
        return proxy.ToArray<WebProxy>();
    }
}

