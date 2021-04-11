using System.Collections.Generic;
using StatementProcessor.payment;

namespace StatementProcessor
{
    interface IConverter
    {
        List<Payment> Do(string dataPath);
    }
}
