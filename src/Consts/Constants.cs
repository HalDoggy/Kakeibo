using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consts
{
    public static class Constants
    {
        public enum CardCompanies
        {
            VPass,
            Epos,
            View
        }

        public static string FileFormat(CardCompanies cardCompanies)
        {
            switch (cardCompanies)
            {
                case CardCompanies.VPass:
                    return "csv (*.csv)|*.csv|all (*.*)|*.*";
                case CardCompanies.Epos:
                case CardCompanies.View:
                    return "all (*.*)|*.*";
                default:
                    throw new InvalidCastException();
            }
        }

        public enum Category
        {
            Food,
            FurnitureAndAppliances,
            Water,
            Gas,
            Electricity,
            Entertainment,
            Communication,
            Stock,
            Clothes,
            Book,
            NULL
        }
    }
}
