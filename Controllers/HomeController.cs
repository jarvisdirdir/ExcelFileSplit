using ExcelFileSplit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ExcelFileSplit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ExportMulitExcel()
        {
            var queryData = GetExcelExportDTOs();

            string now = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            int exportCount = GetParameterExcelDataCount();
            var excels = new List<ItemExportMultiExcelDTO>();
            var count = queryData.Count % exportCount == 0 ? (queryData.Count / exportCount) : (queryData.Count / exportCount) + 1;

            for (int i = 0; i < count; i++)
            {
                var filename = "商品主檔匯出_" + now + "_(" + i + ")";
                var result = queryData.Skip(i * exportCount).Take(exportCount);
                //using (OpenXmlExcelWriter writer = new OpenXmlExcelWriter())
                //{
                //    writer.Export(result.AsQueryable(), filename);
                //    excels.Add(new ItemExportMultiExcelDTO { fileName = filename + ".xlsx", base64Data = Convert.ToBase64String(writer.ToByte()) });
                //}
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.SaveAs(result);
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    excels.Add(new ItemExportMultiExcelDTO { fileName = filename + ".xlsx", base64Data = Convert.ToBase64String(memoryStream.ToArray()) });
                }
            }
            return new JsonResult(excels);
        }


        /// <summary>
        /// 取得資料匯出切分筆數的參數
        /// </summary>
        /// <returns></returns>
        private int GetParameterExcelDataCount()
        {
            int exportCount = 50000;
            //var paramM = uow.Get<IParameterRepository>().Get(x => x.ParamType == "120");
            //if (paramM != null && paramM.Param1 != null)
            //{
            //    exportCount = Convert.ToInt32(paramM.Param1);
            //}
            return exportCount;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<ExcelExportDTO> GetExcelExportDTOs() 
        {
            List<ExcelExportDTO> query = new List<ExcelExportDTO>();

            for (var i = 0; i < 150000; i++)
            {
                query.Add(new ExcelExportDTO()
                {
                    Barcode1 = "aaaaa",
                    Barcode2 = "bbbbb",
                    Barcode3 = "ccccc",
                    Barcode4 = "ccccc",
                    Barcode5 = "ccccc",
                    Barcode6 = "ccccc",
                    DcCode1 = "123456789"+i,
                    DcCode2 = "123456789"+i,
                    DcCode3 = "123456789"+i,
                    DcCode4 = "123456789"+i,
                    DcCode5 = "123456789"+i,
                    DcCode6 = "123456789"+i,
                    DcCode7 = "123456789"+i,
                    DcCode8 = "123456789"+i,
                    DcCode9 = "123456789" + i,
                    DcCode10 = "123456789" + i,
                    DcCodeName1 = "廠商名字"+i,
                    DcCodeName2 = "廠商名字"+i,
                    DcCodeName3 = "廠商名字"+i,
                    DcCodeName4 = "廠商名字"+i,
                    DcCodeName5 = "廠商名字"+i,
                    DcCodeName6 = "廠商名字"+i,
                    DcCodeName7 = "廠商名字"+i,
                    DcCodeName8 = "廠商名字"+i,
                    DcCodeName9 = "廠商名字" + i,
                    DcCodeName10 = "廠商名字" + i,
                    CatID1 = "******",
                    CatID2 = "&&&&&&",
                    CatID3 = "@@@@@@",
                    BrandID = "******",
                    ECSuspendFlagName = "******",
                    EffDateFrom = "2022/11/08",
                    EffDateTo = "9999/12/31",
                    EnSaleDate = "2025/12/31",
                    LimitDateE = "******",
                    ImpExpState = "1",
                    BrandNM = "廠商名稱"+i,
                    ChargeIDNM= "******",
                    QAStateNM = "******",
                    CatLv1Mgr = "******",
                    CatLv2Mgr = "******",
                    NoChargeReason = "******",
                    TaxTypeNM = "******",
                    Team = "******",
                    CatNM1 = "******",
                    CatNM2 = "******",
                    CatNM3 = "******",
                    ItemUnit = "******",
                    ChargeTypeNM = "******",
                    InnerQty = 123123,
                    ItemAttr1 = "******",
                    ItemAttr10 = "******",
                    ItemAttr11 = "******",
                    ItemAttr12 = "******",
                    ItemAttr13 = "******",
                    ItemAttr14 = "******",
                    ItemAttr15 = "******",
                    ItemAttr16 = "******",
                    ItemAttr17 = "******",
                    ItemAttr18 = "******",
                    ItemAttr19 = "******",
                    ItemAttr2 = "******",
                    ItemAttr20 = "******",
                    ItemAttr3 = "******",
                    ItemAttr4 = "******",
                    ItemAttr5 = "******",
                    ItemAttr6 = "******",
                    ItemAttr7 = "******",
                    ItemAttr8 = "******",
                    ItemAttr9 = "******",
                    ItemCode = i.ToString("000000"),
                    ItemCost = 123566,
                    ItemDepth =122345,
                    ItemDescribe = i+"*******&%%%%%%%#@#@#@!#!@#!@#!@#!@#!@#!@##@$%%^%&^*&&(*&^%$#@$%^&*((^%%$#",
                    ItemHeight = 432255,
                    ItemInvNM = "******",
                    ItemNM = "******12345678iuytrsaSDFGHJKLKJHGFDSA2345678",
                    ItemPrice = 987655,
                    ItemShelfNM = "EWSDFGHJKGFDS3456UYHGFDFGH******",
                    ItemTypeNM = "******",
                    ItemUnitNM = "******",
                    ItemWeight = 353467,
                    LimitDateS = "******",
                    OuterDepth = 777666,
                    VendorName = "******",
                    NorSuspendFlagName = "******",
                    PosResFlag = "******",
                    PosResFlagNM = "******",
                    SouSuspendFlagName = "******",
                    ItemWidth = 852334,
                    LimitQty = 677688,
                    StSaleDate = "******",
                    MaxStock = 314567,
                    MedSavingNM = "******",
                    MedTypeNM = "******",
                    MinStock = 10788,
                    MinValidPeriod = 98899,
                    OuterHeight = 2222,
                    OuterQty = 33333,
                    OuterWeight = 444444,
                    OuterWidth = 55555,
                    SellZoneNM = "******",
                    VendorReturn = "1",
                    Specification = "******",
                    ValidPeriod = 0,
                    VendorCode = "******",
                });
            }
            return query;
        }
    }
}
