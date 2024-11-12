using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WPFDemo_1735
{
    /// <summary>
    /// 存取Stock資料
    /// </summary>
    public class StockService
    {
        /// <summary>
        /// 連線字串
        /// </summary>
        private string _connectionString;

        /// <summary>
        /// StockService建構子，連線
        /// </summary>
        public StockService()
        {
            // 從 App.config 中讀取 Oracle 資料庫連線字串
            _connectionString = ConfigurationManager.ConnectionStrings["OracleDbConnection"].ConnectionString;
        }

        public IEnumerable<Stock> GetStocks()
        {
            using (IDbConnection connection = new Oracle.ManagedDataAccess.Client.OracleConnection(_connectionString))
            {
                connection.Open();
                string sql = "select stock_no,stock_name, low_price, high_price, modify_date, modify_user from STOCK t";
                return connection.Query<Stock>(sql);
            }
        }
    }
}
