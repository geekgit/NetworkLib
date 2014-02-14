using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections;
using System.IO;
namespace TestConsoleApp
{
    class Program
    {
        static void HelloTest()
        {
            Console.WriteLine(NetworkLib.Hello());
        }
        static void TopdanTest()
        {
            WebProxy[] wb = NetworkLib.GetProxyListFromTopdan();
            foreach (WebProxy proxy in wb)
            {
                Console.WriteLine("proxy: {0}", proxy.Address);
            }
        }
        static void FetchWithProxyTest()
        {
            string url = @"http://2ip.ru";
            WebProxy[] wb = NetworkLib.GetProxyListFromTopdan();

            foreach (var proxy in wb)
            {
                string data=NetworkLib.GetRequest(new Uri(url), proxy);
                Console.WriteLine(data);
                File.WriteAllText(@"output.html", data);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                FetchWithProxyTest();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }

        }
    }
}
