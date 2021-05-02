using System.Collections.ObjectModel;
using StatementProcessor.payment;

namespace StatementProcessor
{
    interface IConverter
    {
        ObservableCollection<Payment> Do(string dataPath);
    }
}
