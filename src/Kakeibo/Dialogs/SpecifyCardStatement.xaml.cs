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
using Microsoft.Win32;
using Consts;
using StatementProcessor;

namespace Kakeibo
{
    /// <summary>
    /// SpecifyCardStatement.xaml の相互作用ロジック
    /// </summary>
    public partial class SpecifyCardStatement : Window
    {
        public Array CardCompanies { get; private set; }
        public SpecifyCardStatement()
        {
            CardCompanies = Enum.GetValues(typeof(Constants.CardCompanies));
            InitializeComponent();
            DataContext = this;
        }

        private void SpecifyPath(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = Constants.FileFormat((Constants.CardCompanies)comboBox_CardCompany.SelectedItem);
            if (dialog.ShowDialog() == true)
            {
                textBox_Path.Text = dialog.FileName;
            }
        }

        private void comboBox_CardCompany_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            button_SpecifyPath.IsEnabled = comboBox_CardCompany.SelectedItem != null;
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            StatementFactory factory = new StatementFactory();
            Statement statement = factory.Create(textBox_Path.Text, (Constants.CardCompanies)comboBox_CardCompany.SelectedItem);
            // TODO : return statement object to somewhere
        }
    }
}
