

using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Media3D;
using wam_module.Model1NS;
using wam_module.Model2NS;
using wam_module.Model3NS;
using wam_module.Model4NS;
namespace wam_module
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static string path = "0819f05c4eef4c71ace90d822a990e87";
        public static string code = "C670492";
        string FootName;

        public MainWindow()
        {
            InitializeComponent();

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            var resp0 = await "https://pro.lceda.cn/api/eda/product/search".PostMultipartAsync(mp => mp
            .AddString("keyword", "C670492")
            .AddString("needAggs", "true")
            .AddString("url", "/ api / eda / product / list")
            .AddString("currPage", "1")
            .AddString("pageSize", "10")
            ).ReceiveString();
            var json = resp0;

            Model1 model1 = JsonConvert.DeserializeObject<Model1>(resp0);
            string hasDevice = model1.result.productList[0].hasDevice;

            var resp1 = await "https://pro.lceda.cn/api/devices/searchByIds".PostMultipartAsync(mp => mp
            .AddString(" uuids[]", hasDevice)
            .AddString("path", path)
            ).ReceiveString();
            Model2 model2 = JsonConvert.DeserializeObject<Model2>(resp1);
            string Modelattr = model2.result[0].attributes.Model;
           

            var resp2 = await "https://pro.lceda.cn/api/components/searchByIds?forceOnline=1".PostMultipartAsync(mp => mp
            .AddString(" uuids[]", Modelattr)
            .AddString("dataStr", "yes")
            .AddString("path", path)
            ).ReceiveString();
            Model3 model3 = JsonConvert.DeserializeObject<Model3>(resp2);
            string datastr = model3.result[0].dataStr;
            Model4 model4 = JsonConvert.DeserializeObject<Model4>(datastr);
            string ModelID = model4.model;
            FootName = model4.src;

          
            string download_url = "https://modules.lceda.cn/qAxj6KHrDKw4blvCG8QJPs7Y/" + ModelID;
            string text = await download_url.GetStringAsync();
            Console.WriteLine(text);
            File.WriteAllText("D:\\"+ FootName+".step", text);
            //Console.WriteLine(FootName);


        }

    }

}
