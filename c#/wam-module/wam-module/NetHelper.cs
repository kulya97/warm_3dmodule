using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
/// <summary>
/// http协议请求方法封装
/// </summary>
public class NetHelper
{
    #region Get请求
    /// <summary>
    /// get请求,无参
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static async Task<string> GetAsync(string url)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage resp = await client.GetAsync(url);
        //获取响应状态
        //respMsg.StatusCode==200请求成功
        //获取请求内容
        HttpContent respContent = resp.Content;
        return await respContent.ReadAsStringAsync();
    }
    /// <summary>
    /// Get 请求，指定参数
    /// </summary>
    /// <param name="url"></param>
    /// <param name="dic"></param>
    /// <returns></returns>
    public static async Task<string> GetAsync(string url, Dictionary<string, string> dic)
    {
        //参数处理
        StringBuilder builder = new StringBuilder();
        builder.Append(url);
        if (dic.Count > 0)
        {
            builder.Append("?");
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
        }
        return await GetAsync(builder.ToString());
    }

    /// <summary>
    /// get 请求 -同步处理
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string Get(string url)
    {
        Task<string> result = GetAsync(url);
        result.Wait();
        return result.Result;
    }
    /// <summary>
    /// Get请求-同步处理
    /// </summary>
    /// <param name="url">请求地址</param>
    /// <param name="dic">请求参数</param>
    /// <returns></returns>
    public static string Get(string url, Dictionary<string, string> dic)
    {
        //参数处理
        StringBuilder builder = new StringBuilder();
        builder.Append(url);
        if (dic.Count > 0)
        {
            builder.Append("?");
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
        }
        return Get(builder.ToString());
    }
    #endregion

    #region Post 请求处理
    /// <summary>
    /// Post 请求，无参
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static async Task<string> PostAsync(string url, string content = "")
    {
        HttpClient client = new HttpClient();
        using (MemoryStream ms = new MemoryStream())
        {
            byte[] bytes = Encoding.Unicode.GetBytes(content);
            ms.Write(bytes, 0, bytes.Length);
            HttpContent hc = new StreamContent(ms);
            HttpResponseMessage resp = await client.PostAsync(url, null);
            return await resp.Content.ReadAsStringAsync();
        }
    }
    /// <summary>
    /// Post 请求，处理参数
    /// </summary>
    /// <param name="url"></param>
    /// <param name="dic"></param>
    /// <returns></returns>
    public static async Task<string> PostAsync(string url, Dictionary<string, string> dic)
    {
        HttpClient client = new HttpClient();
        FormUrlEncodedContent data = new FormUrlEncodedContent(dic);
        var r = await client.PostAsync(url, data);
        return await r.Content.ReadAsStringAsync();
        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/html"));
        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xhtml+xml"));
        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml", 0.9));
        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("image/webp"));
        //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*", 0.8));
        //hc.Headers.Add("UserAgent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36");
        //hc.Headers.Add("Timeout", timeOut.ToString());
        //hc.Headers.Add("KeepAlive", "true");
    }

    /// <summary>
    /// Post请求，同步，无参
    /// </summary>
    /// <param name="url"></param>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string Post(string url, string content = "")
    {
        Task<string> str = PostAsync(url, content);
        str.Wait();
        return str.Result;
    }
    /// <summary>
    /// Post 请求，同步，参数处理
    /// </summary>
    /// <param name="url"></param>
    /// <param name="dic"></param>
    /// <returns></returns>
    public static string Post(string url, Dictionary<string, string> dic)
    {
        Task<string> str = PostAsync(url, dic);
        str.Wait();
        return str.Result;
    }
    #endregion

    #region 下载文件处理
    /// <summary>
    /// 下载文件
    /// </summary>
    /// <param name="url">链接地址</param>
    /// <param name="target">存储地址</param>
    /// <returns></returns>
    public static bool DownLoad(string url, string target)
    {
        try
        {
            HttpClient client = new HttpClient();
            var t = client.GetByteArrayAsync(url);
            t.Wait();

            var bytes = t.Result;
            using (FileStream fs = new FileStream(target, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception("下载文件失败，", ex);
        }
    }
    #endregion
}