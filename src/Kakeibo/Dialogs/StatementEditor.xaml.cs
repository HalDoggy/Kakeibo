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
using System.ComponentModel;
using System.Collections.ObjectModel;
using Consts;
using StatementProcessor;
using StatementProcessor.DataStructure;

namespace Kakeibo.Dialogs
{
    /// <summary>
    /// StatementEditor.xaml の相互作用ロジック
    /// </summary>
    public partial class StatementEditor : Window
    {
        public string[] categoryList;
        public StatementEditor(Statement statement)
        {
            InitializeComponent();
            this.DataContext = new StatementViewModel(statement);
            StoreCol.IsReadOnly = true;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // non-implement
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // non-implement
        }

        private void AddRow_()
        {
            var p = new Payment();
            p.Date = DateTime.Now;
            ((StatementViewModel)DataContext).Payments.Add(p);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddRow_();
        }
    }

    public class StatementViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Payment> payments;
        private ObservableCollection<Constants.Category> categories;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Payment> Payments
        {
            get => payments;
        }

        public ObservableCollection<Constants.Category> GetCategories
        {
            get
            {
                if (categories != null) return categories;

                categories = new ObservableCollection<Constants.Category>();
                Constants.Category[] cats = Enum.GetValues(typeof(Constants.Category)).Cast<Constants.Category>().ToArray();
                foreach(Constants.Category _c in cats)
                {
                    categories.Add(_c);
                }
                return categories;
            }
        }

        public StatementViewModel(Statement statement)
        {
            this.payments = statement.DataSet;
        }

        public StatementViewModel()
        {

        }
    }
}
