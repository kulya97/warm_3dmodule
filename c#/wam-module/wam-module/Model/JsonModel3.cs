using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wam_module.Model3NS
{
    public class Modifier
    {
        /// <summary>
        /// 
        /// </summary>
        public string? uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? avatar { get; set; }
    }

    public class Creator
    {
        /// <summary>
        /// 
        /// </summary>
        public string? uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? avatar { get; set; }
    }

    public class Owner
    {
        /// <summary>
        /// 
        /// </summary>
        public string? uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? avatar { get; set; }
    }

    public class Tags
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string>? parent_tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string>? child_tag { get; set; }
    }

    public class ResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string? uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Modifier? modifier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Creator? creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Owner? owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int docType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? dataStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Tags? tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int updateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? display_title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ticket { get; set; }
    }

    public class Model3
    {
        /// <summary>
        /// 
        /// </summary>
        public string? success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ResultItem>? result { get; set; }
    }

}
