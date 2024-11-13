using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo_1735
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            StockService stockService = new StockService();

            // 取得資料並綁定到 DataGrid(dgStock)
            // ItemsSource: 用來指定資料集合，dgStock會根據資料集合顯示資料。
            IEnumerable<Stock> stocks = stockService.GetStocks();
            dgStock.ItemsSource = stocks;

            //非同步寫法:
            //LoadStocksAsync();
        }
        #region
        /// <summary>
        /// 非同步執行取得股票資料
        /// </summary>
        /// <returns></returns>
        //private async Task LoadStocksAsync()
        //{
        //    StockService stockService = new StockService();
        //    var stocks = await stockService.GetStocks();
        //    dgStock.ItemsSource = stocks;
        //}
        #endregion
    }
}