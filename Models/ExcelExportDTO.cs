using System.ComponentModel.DataAnnotations;

namespace ExcelFileSplit.Models
{
    public class ExcelExportDTO
    {
        private string _itemNm;
        private string _itemShelfNM;
    
        [Display(Name = "Team")]
        public string Team { get; set; }

        [Display(Name = "大分類負責人")]
        public string CatLv1Mgr { get; set; }

        [Display(Name = "中分類負責人")]
        public string CatLv2Mgr { get; set; }

        [Display(Name = "品號")]
        public string ItemCode { get; set; }

        [Display(Name = "商品名稱")]
        public string ItemNM
        {
            get
            {
                return _itemNm.Replace((char)11, ' ');
            }
            set
            {
                _itemNm = value;
            }
        }

        [Display(Name = "大分類編號")]
        public string CatID1 { get; set; }

        [Display(Name = "大分類名稱")]
        public string CatNM1 { get; set; }

        [Display(Name = "中分類編號")]
        public string CatID2 { get; set; }

        [Display(Name = "中分類名稱")]
        public string CatNM2 { get; set; }

        [Display(Name = "小分類編號")]
        public string CatID3 { get; set; }

        [Display(Name = "小分類名稱")]
        public string CatNM3 { get; set; }

        [Display(Name = "銷售開始日")]
        public string StSaleDate { get; set; }

        [Display(Name = "停售日期")]
        public string EnSaleDate { get; set; }

        [Display(Name = "原零售價")]
        public decimal? ItemPrice { get; set; }

        [Display(Name = "原成本(含稅)")]
        public decimal? ItemCost { get; set; }

        [Display(Name = "實際供應商")]
        public string VendorCode { get; set; }

        [Display(Name = "供應商名稱")]
        public string VendorName { get; set; }

        [Display(Name = "條碼1")]
        public string Barcode1 { get; set; }

        [Display(Name = "條碼2")]
        public string Barcode2 { get; set; }

        [Display(Name = "條碼3")]
        public string Barcode3 { get; set; }

        [Display(Name = "條碼4")]
        public string Barcode4 { get; set; }

        [Display(Name = "條碼5")]
        public string Barcode5 { get; set; }

        [Display(Name = "條碼6")]
        public string Barcode6 { get; set; }

        [Display(Name = "北倉訂貨狀態")]
        public string NorSuspendFlagName { get; set; }

        [Display(Name = "南倉訂貨狀態")]
        public string SouSuspendFlagName { get; set; }

        [Display(Name = "西園倉訂貨狀態")]
        public string ECSuspendFlagName { get; set; }

        [Display(Name = "商品規格")]
        public string Specification { get; set; }

        [Display(Name = "限量數量")]
        public decimal? LimitQty { get; set; }

        [Display(Name = "限量日期_起日")]
        public string LimitDateS { get; set; }

        [Display(Name = "限量日期_迄日")]
        public string LimitDateE { get; set; }

        [Display(Name = "收縮數")]
        public decimal? InnerQty { get; set; }

        [Display(Name = "外箱入數")]
        public decimal? OuterQty { get; set; }

        [Display(Name = "最大訂貨數")]
        public decimal? MaxStock { get; set; }

        [Display(Name = "最小訂貨數")]
        public decimal? MinStock { get; set; }

        [Display(Name = "保存期間(日)")]
        public decimal? ValidPeriod { get; set; }

        [Display(Name = "允收期限(日)")]
        public decimal? MinValidPeriod { get; set; }

        [Display(Name = "適用開始日")]
        public string EffDateFrom { get; set; }

        [Display(Name = "適用結束日")]
        public string EffDateTo { get; set; }

        [Display(Name = "品牌")]
        public string BrandID { get; set; }

        [Display(Name = "品牌名稱")]
        public string BrandNM { get; set; }

        [Display(Name = "商品身分別")]
        public string ChargeIDNM { get; set; }

        [Display(Name = "收費方式")]
        public string ChargeTypeNM { get; set; }

        [Display(Name = "不收費原因")]
        public string NoChargeReason { get; set; }

        [Display(Name = "稅別")]
        public string TaxTypeNM { get; set; }

        [Display(Name = "商品種類")]
        public string ItemTypeNM { get; set; }

        [Display(Name = "藥品分級")]
        public string MedTypeNM { get; set; }

        [Display(Name = "藥品保存條件")]
        public string MedSavingNM { get; set; }

        [Display(Name = "屬性1:藥品")]
        public string ItemAttr1 { get; set; }

        [Display(Name = "屬性2:短效品")]
        public string ItemAttr2 { get; set; }

        [Display(Name = "屬性3:買斷品")]
        public string ItemAttr3 { get; set; }

        [Display(Name = "屬性4:獨賣品")]
        public string ItemAttr4 { get; set; }

        [Display(Name = "屬性5:預購品")]
        public string ItemAttr5 { get; set; }

        [Display(Name = "屬性6:宅配品")]
        public string ItemAttr6 { get; set; }

        [Display(Name = "屬性7:轉倉品")]
        public string ItemAttr7 { get; set; }

        [Display(Name = "屬性8:區域性商品")]
        public string ItemAttr8 { get; set; }

        [Display(Name = "屬性9:乙類成藥")]
        public string ItemAttr9 { get; set; }

        [Display(Name = "屬性10:EC販售商品")]
        public string ItemAttr10 { get; set; }

        [Display(Name = "屬性11:試用品")]
        public string ItemAttr11 { get; set; }

        [Display(Name = "屬性12:PB")]
        public string ItemAttr12 { get; set; }

        [Display(Name = "屬性13:屬性未定")]
        public string ItemAttr13 { get; set; }

        [Display(Name = "屬性14:屬性未定")]
        public string ItemAttr14 { get; set; }

        [Display(Name = "屬性15:屬性未定")]
        public string ItemAttr15 { get; set; }

        [Display(Name = "屬性16:屬性未定")]
        public string ItemAttr16 { get; set; }

        [Display(Name = "屬性17:屬性未定")]
        public string ItemAttr17 { get; set; }

        [Display(Name = "屬性18:屬性未定")]
        public string ItemAttr18 { get; set; }

        [Display(Name = "屬性19:屬性未定")]
        public string ItemAttr19 { get; set; }

        [Display(Name = "屬性20:屬性未定")]
        public string ItemAttr20 { get; set; }

        [Display(Name = "品保狀態")]
        public string QAStateNM { get; set; }

        [Display(Name = "銷售狀態")]
        public string PosResFlag { get; set; }

        [Display(Name = "銷售狀態名稱")]
        public string PosResFlagNM { get; set; }

        [Display(Name = "販售單位代碼")]
        public string ItemUnit { get; set; }

        [Display(Name = "販售單位名稱")]
        public string ItemUnitNM { get; set; }

        [Display(Name = "供應商退貨")]
        public string VendorReturn { get; set; }

        [Display(Name = "進口國產")]
        public string ImpExpState { get; set; }

        [Display(Name = "販售區域")]
        public string SellZoneNM { get; set; }

        [Display(Name = "單品-寬(mm)")]
        public decimal? ItemWidth { get; set; }

        [Display(Name = "單品-高(mm)")]
        public decimal? ItemHeight { get; set; }

        [Display(Name = "單品-深(mm)")]
        public decimal? ItemDepth { get; set; }

        [Display(Name = "單品-重(g)")]
        public decimal? ItemWeight { get; set; }

        [Display(Name = "外箱-寬(mm)")]
        public decimal? OuterWidth { get; set; }

        [Display(Name = "外箱-高(mm)")]
        public decimal? OuterHeight { get; set; }

        [Display(Name = "外箱-深(mm)")]
        public decimal? OuterDepth { get; set; }

        [Display(Name = "外箱-重(g)")]
        public decimal? OuterWeight { get; set; }

        [Display(Name = "商品說明")]
        public string ItemDescribe { get; set; }

        [Display(Name = "貨架標籤名")]
        public string ItemShelfNM
        {
            get
            {
                return _itemShelfNM.Replace((char)11, ' ');
            }
            set
            {
                _itemShelfNM = value;
            }
        }

        [Display(Name = "發票列印名")]
        public string ItemInvNM
        { get; set; }

        [Display(Name = "配送商1")]
        public string DcCode1
        { get; set; }

        [Display(Name = "配送商1名稱")]
        public string DcCodeName1
        { get; set; }

        [Display(Name = "配送商2")]
        public string DcCode2
        { get; set; }

        [Display(Name = "配送商2名稱")]
        public string DcCodeName2
        { get; set; }

        [Display(Name = "配送商3")]
        public string DcCode3
        { get; set; }

        [Display(Name = "配送商3名稱")]
        public string DcCodeName3
        { get; set; }

        [Display(Name = "配送商4")]
        public string DcCode4
        { get; set; }

        [Display(Name = "配送商4名稱")]
        public string DcCodeName4
        { get; set; }

        [Display(Name = "配送商5")]
        public string DcCode5
        { get; set; }

        [Display(Name = "配送商5名稱")]
        public string DcCodeName5
        { get; set; }

        [Display(Name = "配送商6")]
        public string DcCode6
        { get; set; }

        [Display(Name = "配送商6名稱")]
        public string DcCodeName6
        { get; set; }

        [Display(Name = "配送商7")]
        public string DcCode7
        { get; set; }

        [Display(Name = "配送商7名稱")]
        public string DcCodeName7
        { get; set; }

        [Display(Name = "配送商8")]
        public string DcCode8
        { get; set; }

        [Display(Name = "配送商8名稱")]
        public string DcCodeName8
        { get; set; }

        [Display(Name = "配送商9")]
        public string DcCode9
        { get; set; }

        [Display(Name = "配送商9名稱")]
        public string DcCodeName9
        { get; set; }

        [Display(Name = "配送商10")]
        public string DcCode10
        { get; set; }

        [Display(Name = "配送商10名稱")]
        public string DcCodeName10
        { get; set; }
    }
}
