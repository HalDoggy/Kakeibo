using System;
using Consts;


namespace StatementProcessor
{
    public class StatementFactory
    {
        public StatementFactory()
        {

        }

        public Statement Create(string statementPath, Constants.CardCompanies company)
        {
            Statement statement = new Statement(statementPath, company);

            switch (company)
            {
                case Constants.CardCompanies.VPass:
                    statement.SetConverter(new ConverterVPass(statement.Extension));
                    break;
                default:
                    statement = null;
                    break;
            }
            return statement;
        }
    }
}
