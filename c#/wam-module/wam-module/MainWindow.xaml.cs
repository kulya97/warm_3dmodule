

using Flurl.Http;
using Microsoft.Win32;
using System.Text.Json;
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
using static System.Net.Mime.MediaTypeNames;

namespace wam_module
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static string path = "0819f05c4eef4c71ace90d822a990e87";


        public MainWindow()
        {
            InitializeComponent();

        }

        private void Check_Button_Click(object sender, RoutedEventArgs e)
        {

        }
        static JsonSerializerSettings mJsonSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };


        private async void Down_Button_Click(object sender, RoutedEventArgs e)
        {
            string code = footcode_txbox.Text;
            var resp0 = await "https://pro.lceda.cn/api/eda/product/search".PostMultipartAsync(mp => mp
                .AddString("keyword", code)
                .AddString("needAggs", "true")
                    .AddString("url", "/ api / eda / product / list")
                 .AddString("currPage", "1")
                    .AddString("pageSize", "10")
                ).ReceiveString();
            var model1 = JsonConvert.DeserializeObject<Model1>(resp0, mJsonSettings);
            string hasDevice;
            try { hasDevice = model1.result.productList[0].hasDevice; }
            catch (Exception ex)
            { MessageBox.Show("元器件不存在！"); return; }

            var resp1 = await "https://pro.lceda.cn/api/devices/searchByIds".PostMultipartAsync(mp => mp
            .AddString(" uuids[]", hasDevice)
            .AddString("path", path)
            ).ReceiveString();
            Console.WriteLine(resp1);
            var model2 = JsonConvert.DeserializeObject<Model2>(resp1, mJsonSettings);

            string Modelattr;

            try { Modelattr = model2.result[0].attributes.Model; }
            catch (Exception ex)
            { MessageBox.Show("元器件不存在！"); return; }

            var resp2 = await "https://pro.lceda.cn/api/components/searchByIds?forceOnline=1".PostMultipartAsync(mp => mp
            .AddString(" uuids[]", Modelattr)
            .AddString("dataStr", "yes")
            .AddString("path", path)
            ).ReceiveString();

            
            var model3 = JsonConvert.DeserializeObject<Model3>(resp2, mJsonSettings);
            string datastr ;
            try { datastr = model3.result[0].dataStr; }
            catch (Exception ex)
            { MessageBox.Show("元器件不存在！"); return; }
            var model4 = JsonConvert.DeserializeObject<Model4>(datastr, mJsonSettings);
            string ModelID = null;
            try { ModelID = model4.model; }
            catch (Exception ex)
            { MessageBox.Show("元器件不存在！"); return; }

            string FootName = model4.src + ".step";

            string download_url = "https://modules.lceda.cn/qAxj6KHrDKw4blvCG8QJPs7Y/" + ModelID;
            string text = await download_url.GetStringAsync();
            Console.WriteLine(text);
            saveFile(text, FootName);
            Console.WriteLine(FootName);

        }
        public void saveFile(string url, string FileName)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "保存封装";
            save.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory; // 默认的保存路径
            save.FileName = FileName;
            save.ShowDialog();
            if (save.FileName != string.Empty)
            {
                string path = save.FileName;

                File.WriteAllText(path, url);



            }


        }
    }
}