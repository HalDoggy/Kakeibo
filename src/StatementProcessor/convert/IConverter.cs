using System.Collections.ObjectModel;
using StatementProcessor.DataStructure;

namespace StatementProcessor
{
    interface IConverter
    {
        ObservableCollection<Payment> Do(string dataPath);
    }
}
