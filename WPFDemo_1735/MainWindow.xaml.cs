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
        private StockService _repository;

        public MainWindow()
        {
            InitializeComponent();
            _repository = new StockService();

            // 取得資料並綁定到 DataGrid
            LoadStockData();
        }

        private void LoadStockData()
        {
            IEnumerable<Stock> stocks = _repository.GetStocks();
            StockDataGrid.ItemsSource = stocks;
        }
    }
}