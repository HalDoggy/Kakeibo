using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Consts;
using StatementProcessor.payment;

namespace StatementProcessor
{
    internal class ConverterVPass : IConverter
    {
        private string extention;
        internal ConverterVPass(string extention)
        {
            this.extention = extention;
        }

        public ObservableCollection<Payment> Do(string dataPath)
        {
            ObservableCollection<Payment> returnValue;

            switch (extention)
            {
                case ".csv":
                    returnValue = ConvertFromCSV(dataPath);
                    break;
                default:
                    returnValue = null;
                    break;
            }

            return returnValue;
        }

        private ObservableCollection<Payment> ConvertFromCSV(string dataPath)
        {
            string[] contents;
            int rowNum = 0;
            //Payment payment;
            ObservableCollection<Payment> payments = new ObservableCollection<Payment>();
            DateTime t;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (StreamReader reader = new StreamReader(dataPath, Encoding.GetEncoding(932))) //Shift_JIS
            {
                while (reader.Peek() >= 0)
                {
                    contents = reader.ReadLine().Split(",");
                    Payment payment = new Payment();
                    if(!DateTime.TryParse(contents[0], out t))
                    {
                        continue;
                    }
                    payment._Date = t;
                    payment.Store = contents[1];
                    payment.Amount = int.Parse(contents[2]);
                    payment.RowNumOfStatement = rowNum;

                    payments.Add(payment);
                    rowNum++;
                }
            }
            return payments;
        }
    }
}
