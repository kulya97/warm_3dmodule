

using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace wam_module
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //            var resp = await "https://pro.lceda.cn/api/eda/product/search".PostMultipartAsync(mp => mp
            //.AddString("keyword", "C670492")
            //.AddString("needAggs", "true")
            //.AddString("url", "/api/eda/product/list")
            //.AddString("currPage", "1")
            //.AddString("pageSize", "10"));

            //            Console.WriteLine(resp);

            var resp = await "https://pro.lceda.cn/api/eda/product/search".PostUrlEncodedAsync(new
            {
                keyword = "C670492",
                needAggs = "true",
                url = " / api / eda / product / list",
                currPage = "1",
                pageSize = "10"
            }).ReceiveString();

            Console.WriteLine(resp);

                //form - data格式发送Post请求
                // Dictionary<string, string> dic = new Dictionary<string, string>();
                // dic.Add("keyword", "C670492");
                // dic.Add("needAggs", "true");
                // dic.Add("url", "/api/eda/product/list");
                // dic.Add("currPage", "1");
                //dic.Add("pageSize", "10"); 
                // string reuslt = NetHelper.Post("https://pro.lceda.cn/api/eda/product/search", dic);
                // Console.WriteLine(reuslt);
            }

    }

}
