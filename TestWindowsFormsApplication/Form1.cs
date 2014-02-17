using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsFormsApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void AddText(string text)
        {
            logTextBox.Text += text;
        }
        void Callback(WebProxy wb,object o, DownloadStringCompletedEventArgs ea)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Proxy: {0}\r\n", wb.Address);
            try
            {
                sb.AppendFormat("Data: {0}\r\n", ea.Result);
            }
            catch (Exception E)
            {
                sb.AppendFormat("Exception: {0}\r\n", E.Message);
                Exception inner = E.InnerException;
                if (inner != null)
                    sb.AppendFormat("Inner Exception: {0}\r\n", inner.Message);
            }
            string str=sb.ToString();
            AddText(str);
        }
        void ButtonClick()
        {
            string url = @"http://2ip.ru";
            WebProxy[] wb = NetworkLib.GetProxyListFromTopdan();
            
            foreach (var proxy in wb)
            {
                Action<object, DownloadStringCompletedEventArgs> a = (o, ea) => {Callback(proxy,o,ea); };
                NetworkLib.GetRequestAsync(new Uri(url), proxy,a);
            }
        }
        private void WorkButton_Click(object sender, EventArgs e)
        {
            ButtonClick();
        }
    }
}
