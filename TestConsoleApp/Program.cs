using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NetworkLib.Hello());
            WebProxy[] wb = NetworkLib.GetProxyListFromTopdan();
            foreach (WebProxy proxy in wb)
            {
                Console.WriteLine("proxy: {0}", proxy.Address);
            }
        }
    }
}
