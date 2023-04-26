using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wam_module.Model1NS
{
    public class PriceListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int startNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int endNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double price { get; set; }
    }

    public class ProductListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int catalogId { get; set; }
        /// <summary>
        /// 线性稳压器(LDO)
        /// </summary>
        public string catalogName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? catalogNameEn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int brandId { get; set; }
        /// <summary>
        /// ADI(亚德诺)
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// 国际品牌
        /// </summary>
        public string brandLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string standard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string model { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stockNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string batchStockLimit { get; set; }
        /// <summary>
        /// 个
        /// </summary>
        public string stockUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int packageNumber { get; set; }
        /// <summary>
        /// 管
        /// </summary>
        public string packageUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int splitRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PriceListItem> priceList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string recentSold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hasSample { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string highlightName { get; set; }
        /// <summary>
        /// 线性稳压器(LDO)
        /// </summary>
        public string highlightCatalogName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string highlightCode { get; set; }
        /// <summary>
        /// ADI(亚德诺)
        /// </summary>
        public string highlightBrandName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string highlightStandard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string highlightModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string highlightDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string couponAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string couponThresholdMoney { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string listProductDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string productDiscountList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isProductRebate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isPlusDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isFavorite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hasPlusCoupon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string canPaster { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isReturnCoupon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isPromotionDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string returnCouponDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string productArrange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string productParams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pdfFileUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pdfImgUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string maxPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string preSale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hasStock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string onsale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string updateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string minPacketNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string minPacketUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hasDevice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("JLCPCB Part Class")]
        public string JLCPCBPartClass { get; set; }
    }

    public class ParamListItem
    {
        /// <summary>
        /// 类目
        /// </summary>
        public string parameterName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string parameterCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string frontSort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> parameterValueList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string paramSearchValueList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string strMaxLength { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string parameterType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unitList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unitConversionList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string normUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string minNumAndMaxNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mergeParameterValuePointList { get; set; }
    }

    public class Result
    {
        /// <summary>
        /// 
        /// </summary>
        public List<ProductListItem> productList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ParamListItem> paramList { get; set; }
    }

    public class Model1
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Result result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
    }
}
