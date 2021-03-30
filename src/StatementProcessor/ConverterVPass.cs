using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consts;

namespace StatementProcessor
{
    internal class ConverterVPass : IConverter
    {
        private string extention;
        internal ConverterVPass(string extention)
        {
            this.extention = extention;
        }

        public System.Data.DataSet Do()
        {
            System.Data.DataSet returnValue;

            switch (extention)
            {
                case "csv":
                    returnValue = ConvertFromCSV();
                    break;
                default:
                    returnValue = null;
                    break;
            }

            return returnValue;
        }

        private System.Data.DataSet ConvertFromCSV()
        {
            return null;
        }

    }
}
