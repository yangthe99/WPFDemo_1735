using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo_1735
{
    /// <summary>
    /// 股票
    /// </summary>
    public class Stock // 根據需求設計模型
    {
        /// <summary>
        /// 股票代號
        /// </summary>
        [Display(Name = "股票號碼")]
        public string Stock_No { get; set; }
        /// <summary>
        /// 股票中文簡稱
        /// </summary>
        [Display(Name = "股票名稱")]
        public string Stock_Name { get; set; }
        /// <summary>
        /// 最低成交價
        /// </summary>
        [Display(Name = "最低成交價")]
        public decimal Low_Price { get; set; }
        /// <summary>
        /// 最高成交價
        /// </summary>
        [Display(Name = "最高成交價")]
        public decimal High_Price { get; set; }
        /// <summary>
        /// 異動日期
        /// </summary>
        [Display(Name = "異動日期")]
        public string Modify_Date { get; set; }
        /// <summary>
        /// 異動人員
        /// </summary>
        [Display(Name = "異動人員")]
        public string Modify_User { get; set; }
    }
}
