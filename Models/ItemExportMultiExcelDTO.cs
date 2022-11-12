using System.ComponentModel.DataAnnotations;

namespace ExcelFileSplit.Models
{
    public class ItemExportMultiExcelDTO
    {
        /// <summary>
        /// 檔案名稱
        /// </summary>
        [Display(Name = "檔案名稱")]
        public string fileName { get; set; }

        /// <summary>
        /// base64編碼
        /// </summary>
        [Display(Name = "base64編碼")]
        public string base64Data { get; set; }
    }
}
