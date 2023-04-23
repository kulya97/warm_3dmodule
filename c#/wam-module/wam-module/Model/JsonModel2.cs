using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wam_module.Model2NS
{
    public class Owner
    {
        /// <summary>
        /// 
        /// </summary>
        public string uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar { get; set; }
    }

    public class Creator
    {
        /// <summary>
        /// 
        /// </summary>
        public string uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar { get; set; }
    }

    public class Modifier
    {
        /// <summary>
        /// 
        /// </summary>
        public string uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar { get; set; }
    }

    public class Parent_tag
    {
        /// <summary>
        /// 
        /// </summary>
        public string uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 电源芯片
        /// </summary>
        public string name_cn { get; set; }
    }

    public class Child_tag
    {
        /// <summary>
        /// 
        /// </summary>
        public string uuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 线性稳压器(LDO)
        /// </summary>
        public string name_cn { get; set; }
    }

    public class Tags
    {
        /// <summary>
        /// 
        /// </summary>
        public Parent_tag parent_tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Child_tag child_tag { get; set; }
    }

    public class Attributes
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LCSC Part Name")]
        public string LCSCPartName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Supplier Part")]
        public string SupplierPart{ get; set; }
    /// <summary>
    /// ADI(亚德诺)/LINEAR(凌特)
    /// </summary>
    public string Manufacturer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Manufacturer Part ")]
        public string ManufacturerPart { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Supplier Footprint")]
        public string SupplierFootprint
{ get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("JLCPCB Part Clas")]
        public string JLCPCBPartClass { get; set; }
/// <summary>
/// 
/// </summary>
public string Datasheet { get; set; }
/// <summary>
/// 
/// </summary>
public string Supplier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Add into BOM")]
        public string AddintoBOM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Convert to PCB")]
        public string ConverttoPCB { get; set; }
/// <summary>
/// 
/// </summary>
public string Symbol { get; set; }
/// <summary>
/// 
/// </summary>
public string Designator { get; set; }
/// <summary>
/// 
/// </summary>
public string Footprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("3D Model")]
        public string Model
{ get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("3D Model Title")] 
        public string ModelTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("3D Model Transform")] 
        public string ModelTransform { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Output Type")] 
        public string OutputType
{ get; set; }
/// <summary>
/// 
/// </summary>
public string Name { get; set; }
}
 
public class ResultItem
{
    /// <summary>
    /// 
    /// </summary>
    public string uuid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Owner owner { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Creator creator { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Modifier modifier { get; set; }
    /// <summary>
    /// 输出类型:-;
    /// </summary>
    public string description { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string title { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Tags tags { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> images { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Attributes attributes { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string source { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int version { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string project_uuid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int footprint_type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int symbol_type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string product_code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int updateTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int createTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string display_title { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int ticket { get; set; }
}

public class Model2
{
    /// <summary>
    /// 
    /// </summary>
    public string success { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<ResultItem> result { get; set; }
}
}
