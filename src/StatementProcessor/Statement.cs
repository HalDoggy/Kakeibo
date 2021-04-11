using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consts;
using StatementProcessor.payment;

namespace StatementProcessor
{
    public class Statement
    {
        private string statementPath;
        private Constants.CardCompanies company;
        private string extension;

        private IConverter converter;
        private List<Payment> dataSet;

        public Statement(string statementPath, Constants.CardCompanies company)
        {
            this.statementPath = statementPath;
            this.company = company;
            extension = System.IO.Path.GetExtension(this.statementPath);
        }

        public string StatementPath { get { return statementPath; } }

        public Constants.CardCompanies Company { get { return company; } }

        public string Extension { get { return extension; } }

        public List<Payment> DataSet { get => dataSet; }

        internal void SetConverter(IConverter converter)
        {
            this.converter = converter;
            dataSet = ConvretToDataSet();
        }

        private List<Payment> ConvretToDataSet() { return converter.Do(StatementPath); }
    }
}
