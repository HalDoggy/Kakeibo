using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Consts;
using StatementProcessor;
using StatementProcessor.payment;

namespace Kakeibo.Dialogs
{
    /// <summary>
    /// StatementEditor.xaml の相互作用ロジック
    /// </summary>
    public partial class StatementEditor : Window
    {
        private TestDataSet tds;
        private List<Payment> payments;
        public string[] categoryList;
        public StatementEditor(Statement statement)
        {
            InitializeComponent();

            payments = statement.DataSet;
            categoryList = Enum.GetNames(typeof(Constants.Category));

            var c = new TestData();
            tds = new TestDataSet();
            dataGrid.DataContext = this;
            //dataGrid.ItemsSource = statement.DataSet;
            
        }

        public List<Payment> Payments
        {
            get => payments;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            int w = tds.Set[0].Who;
        }
    }

    public class ViewModel
    {
        public TestDataSet _Model = new TestDataSet();
    }

    public class TestDataSet
    {
        public List<TestData> Set = new List<TestData> { new TestData() };
    }

    public class TestData
    {
        private int who;
        private DateTime dt = DateTime.Now.Date;
        public string Date { 
            get 
            {
                return dt.ToString("d");
            }  
        }
        public DateTime _Date { get { return dt; } set { dt = value; } }

        public Consts.Constants.Category Money { get; set; }
        public int Who {
            get { return who; }
            set
            {
                if (true)
                {
                    return;
                }
                else
                {
                    who = value;
                }
            }
        }

        public bool RO { get { return true; } }

        public TestData()
        {

        }
    }
}
