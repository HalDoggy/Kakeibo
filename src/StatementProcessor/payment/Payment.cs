using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consts;
using System.Security.Cryptography;

namespace StatementProcessor.DataStructure
{
    public class Payment
    {
        public virtual DateTime Date { get; set; }

        public virtual string Store { get; set; }

        public virtual int Amount { get; set; }

        private Constants.Category category = Constants.Category.NULL;
        public virtual Constants.Category Category { get => category; set { category = value; } }

        public int RowNumOfStatement { get; set; }

        public int Sha256OfThis
        {
            get
            {
                string computedString = Date + Store + Amount.ToString() + RowNumOfStatement.ToString();
                SHA256 myHash = SHA256.Create();
                return computedString.GetHashCode();
            }

            private set { }
        }
    }
}
