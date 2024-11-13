using System.Configuration;
using System.Data;
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
        /// StockService建構子，讀取 Oracle 資料庫連線字串
        /// </summary>
        public StockService()
        {
            // ConfigurationManager: 讀取應用程式的配置檔案(App.config)
            // ConnectionStrings: 返回資料庫連線字串的集合
            // .connectionString: 提取與名稱(OracleDbConnection)相關的實際連線字串
            _connectionString = ConfigurationManager.ConnectionStrings["OracleDbConnection"].ConnectionString;
        }
        /// <summary>
        /// 取得股票資料
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Stock> GetStocks()
        {
            // 透過Oracle.ManagedDataAccess連線
            IDbConnection connection = new Oracle.ManagedDataAccess.Client.OracleConnection(_connectionString);
            using (connection)
            {
                connection.Open();
                string queryString = "select stock_no,stock_name, low_price, high_price, modify_date, modify_user from STOCK t";
                return connection.Query<Stock>(queryString);
            }
        }
    }
}

// IDbConnection 是 .NET 中的資料庫連線介面，處理資料庫連線、命令和查詢的基本組件。